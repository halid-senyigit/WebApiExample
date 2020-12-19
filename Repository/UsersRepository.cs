﻿using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class UsersRepository : Interfaces.IUsersRepository
    {
        private readonly ModelContext _db;

        public UsersRepository(
            ModelContext db
            )
        {
            this._db = db;
        }

        public IEnumerable<Users> GetAll()
        {
            return _db.Users.ToList();
        }

        public Users GetUserById(int id)
        {
            return _db.Users.FirstOrDefault(n => n.UserID == id);
        }
    }
}
