using DataAccessObject;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class UsersRepository : Interfaces.IUsersRepository
    {
        public IEnumerable<User> GetAll()
        {
            return new List<User>(){
                new User{
                    Email = "",
                    DateOfBirth = DateTime.Now,
                    FullName = "deneme",
                    UserID = 1
                }
            };
        }

        public User GetUserById(int id)
        {
            return new User
            {
                Email = "",
                DateOfBirth = DateTime.Now,
                FullName = "deneme",
                UserID = 1
            };
        }
    }
}
