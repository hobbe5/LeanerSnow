using CoreUser = LeanerSnow.Core.Entities.User;
using LeanerSnow.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanerSnow.DataAccess
{
    public class UserRepository : IUserRepository
    {
        public static readonly object DBNullValue = (object)DBNull.Value;

        private IRepository<User> _userRepository;
        private socialdinerEntities _dbContext;

        public UserRepository(socialdinerEntities context)
            : this(context, new Repository<User>(context)) { }
        public UserRepository(socialdinerEntities dbContext, IRepository<User> userRepository)
        {
            _dbContext = dbContext;
            _userRepository = userRepository;
            AutoMapperConfiguration.ConfigureUserMapping();
        }
        
        public CoreUser GetUserById(int userId)
        {
            var user = _userRepository.Find(u => u.Id == userId).FirstOrDefault();
            return AutoMapper.Mapper.Map(user, new CoreUser());
        }

        public CoreUser GetUserByLogin(string email, string password)
        {
            var user = _userRepository.Find(u => u.Email == email && u.Password == password).FirstOrDefault();
            return AutoMapper.Mapper.Map(user, new CoreUser());
        }

        public void Insert(CoreUser user)
        {
            _userRepository.Insert(AutoMapper.Mapper.Map(user, new User()));            
        }
    }
}
