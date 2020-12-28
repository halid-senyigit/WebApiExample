using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Repository.Interfaces
{
    public interface IRepository<T> where T: class, new()
    {
        IEnumerable<T> GetAll();
        T GetById(int id);

        void ChangeEntityState(EntityState entityState);
        
        int SaveChanges();
    }
}
