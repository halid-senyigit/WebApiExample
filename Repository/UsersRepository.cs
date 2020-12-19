using DataAccessObject;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class UsersRepository : Interfaces.IUsersRepository
    {
        public IEnumerable<User> GetAllUsers()
        {
            return new List<User>(){
                new User{ Email = "", DateOfBirth = DateTime.Now, FullName = "deneme", UserID = 1 } 
            };
        }
    }
}
