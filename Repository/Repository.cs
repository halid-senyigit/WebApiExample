

using Repository.Interfaces;

namespace Repository
{

    public class Repository<T>: IRepository<T> where T: class, new()
    {
        public System.Collections.Generic.IEnumerable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }

}
