using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessObject
{
    public class ModelContext : DbContext
    {
        public ModelContext(DbContextOptions opt) : base(opt)
        {

        }

        public DbSet<Users> Users { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasData(
                new Users {  UserID = 1,  FullName = "isim soyisim", DateOfBirth = DateTime.Now, Email = "mail@mail.com", Password = "123" }
            );
        }
    }
}
