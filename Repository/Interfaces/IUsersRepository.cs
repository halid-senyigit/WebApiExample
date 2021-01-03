using DataAccessObject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IUsersRepository: IRepository<User>
    {
        void UpdatePassword(int userId, string password);

        User GetUserByCredentials(string email, string password);
    }
}
