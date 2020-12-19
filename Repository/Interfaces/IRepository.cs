using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IRepository<T> where T: class, new()
    {
        IEnumerable<T> GetAll();
        T GetUserById(int id);
    }
}
