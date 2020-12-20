using DataAccessObject;
using Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace DummyData
{
    public class UsersData: IUsersRepository
    {
        private static List<Users> userList = new List<Users>();

        public IEnumerable<Users> GetAll()
        {
            return new List<Users>(){
                new Users{
                    Email = "dummy data mail",
                    DateOfBirth = DateTime.Now,
                    FullName = "dummy data deneme",
                    UserID = 2
                }
            };
        }

        public Users GetById(int id)
        {
            return new Users
            {
                Email = "dummy data  mail get by id",
                DateOfBirth = DateTime.Now,
                FullName = "dummy data deneme",
                UserID = 2
            };
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
