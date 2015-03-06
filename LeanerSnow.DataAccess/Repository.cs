using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LeanerSnow.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private DbContext db = null;
        private DbSet<T> entities = null;

        public Repository(DbContext db)
        {
            this.db = db;
            entities = db.Set<T>();
        }

        public void Reload(T entity)
        {
            db.Entry(entity).Reload();
        }

        public void Insert(T entity)
        {
            entities.Add(entity);
        }

        public void Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            if (db.Entry(entity).State == EntityState.Detached)
            {
                entities.Attach(entity);
            }
            entities.Remove(entity);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return entities.Where(predicate);
        }

        public IEnumerable<T> FindNew(Expression<Func<T, bool>> predicate)
        {
            return entities.AsNoTracking().Where(predicate);
        }

        public DbPropertyValues GetCurrentValues(T entity)
        {
            return db.Entry(entity).CurrentValues;
        }

        public DbPropertyValues GetOriginalValues(T entity)
        {
            return db.Entry(entity).State == EntityState.Modified ? db.Entry(entity).OriginalValues : null;
        }

        public T CreateWithValues(DbPropertyValues values)
        {
            T entity = new T();
            Type type = typeof(T);

            foreach (var name in values.PropertyNames)
            {
                var property = type.GetProperty(name);
                property.SetValue(entity, values.GetValue<object>(name));
            }

            return entity;
        }

        public IQueryable<T> GetAll()
        {
            return entities;
        }

        public T GetById(int id)
        {
            return entities.Find(id);
        }

        public int ExecuteSql(string sql, object[] parameters)
        {
            return db.Database.ExecuteSqlCommand(sql, parameters);
        }

        public IEnumerable<T> SqlQuery(string sql, object[] parameters)
        {
            return db.Database.SqlQuery<T>(sql, parameters).ToList();
        }

        public IQueryable<T> Take(int count)
        {
            return entities.Take(count);
        }
    }
}
