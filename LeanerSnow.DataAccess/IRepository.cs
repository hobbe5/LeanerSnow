using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LeanerSnow.DataAccess
{
    public interface IRepository<T> where T : class
    {
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Reload(T entity);
        DbPropertyValues GetOriginalValues(T entity);
        DbPropertyValues GetCurrentValues(T entity);
        T CreateWithValues(DbPropertyValues values);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        T GetById(int id);
        int ExecuteSql(string sql, object[] parameters);
        IEnumerable<T> SqlQuery(string sql, object[] parameters);
        IQueryable<T> Take(int count);
    }
}
