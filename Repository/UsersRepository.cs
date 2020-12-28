using DataAccessObject;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class UsersRepository : Repository<Users>, IUsersRepository
    {
        private readonly ModelContext _db;

        public UsersRepository(
            ModelContext db
            )
        {
            this._db = db;
        }

        public void UpdatePassword(int userId, string password)
        {
            throw new NotImplementedException();
        }
    }
}
