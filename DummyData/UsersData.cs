using DataAccessObject;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DummyData
{
    public class UsersData: IUsersRepository
    {
        private static List<User> userList = new List<User>();

        public void ChangeEntityState(EntityState entityState)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return userList;
        }

        public User GetById(int id)
        {
            return userList.FirstOrDefault(n => n.UserID == id);
        }

        public User GetUserByCredentials(string email, string password)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdatePassword(int userId, string password)
        {
            throw new NotImplementedException();
        }
    }
}
