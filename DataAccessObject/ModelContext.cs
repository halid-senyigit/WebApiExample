using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessObject
{
    public class ModelContext: DbContext
    {
        public ModelContext(DbContextOptions opt): base(opt)
        {

        }

        public DbSet<User> Users { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }
    }
}
