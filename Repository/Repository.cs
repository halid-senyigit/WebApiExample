

using System.Linq;
using DataAccessObject;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;

namespace Repository
{

    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly ModelContext _db;
        protected DbSet<T> entity;

        public Repository(
            ModelContext db
        )
        {
            this._db = db;
            entity = _db.Set<T>();
        }

        public System.Collections.Generic.IEnumerable<T> GetAll()
        {
            return entity.ToList();
        }

        public T GetById(int id)
        {
            return entity.Find(id);
        }

        public void ChangeEntityState(EntityState entityState)
        {
            _db.Entry(entity).State = entityState;
        }

        public int SaveChanges()
        {
            return _db.SaveChanges();
        }
    }

}
