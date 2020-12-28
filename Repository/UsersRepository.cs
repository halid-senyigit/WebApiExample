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
            ): base(db)
        {
            this._db = db;
        }

        public void UpdatePassword(int userId, string password)
        {
            base.GetById(userId).Password = password;
            base.ChangeEntityState(Microsoft.EntityFrameworkCore.EntityState.Modified);
        }
    }
}
