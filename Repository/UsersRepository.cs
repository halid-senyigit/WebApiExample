using DataAccessObject;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class UsersRepository : Interfaces.IUsersRepository
    {
        public IEnumerable<Users> GetAll()
        {
            return new List<Users>(){
                new Users{
                    Email = "",
                    DateOfBirth = DateTime.Now,
                    FullName = "deneme",
                    UserID = 1
                }
            };
        }

        public Users GetUserById(int id)
        {
            return new Users
            {
                Email = "",
                DateOfBirth = DateTime.Now,
                FullName = "deneme",
                UserID = 1
            };
        }
    }
}
