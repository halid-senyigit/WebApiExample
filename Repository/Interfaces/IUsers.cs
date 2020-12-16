using DataAccessObject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IUsers
    {
        IEnumerable<User> GetAllUsers();
    }
}
