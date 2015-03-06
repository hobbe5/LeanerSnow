using LeanerSnow.Core.Entities;
using System;

namespace LeanerSnow.Core.Interfaces.Data
{
    public interface IUserRepository
    {
        User GetUserById(int userId);
        User GetUserByLogin(string email, string password);
        void Insert(User user);
    }
}
