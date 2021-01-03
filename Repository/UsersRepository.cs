using DataAccessObject;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class UsersRepository : Repository<User>, IUsersRepository
    {
        private readonly ModelContext _db;

        public UsersRepository(
            ModelContext db
            ): base(db)
        {
            this._db = db;
        }

        public void UpdatePassword(int userId, string password)
        {
            base.GetById(userId).Password = password;
            base.ChangeEntityState(Microsoft.EntityFrameworkCore.EntityState.Modified);
        }

        public User GetUserByCredentials(string email, string password){
            User user = _db.Users.FirstOrDefault(n => n.Email == email && n.Password == password);
            if(user != null){
                return user;
            }
            return null;
        }
    }
}
