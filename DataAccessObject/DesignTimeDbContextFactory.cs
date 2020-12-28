using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataAccessObject
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ModelContext>
    {
        public ModelContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(@Directory.GetCurrentDirectory() + "/appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<ModelContext>();
            var connectionString = configuration.GetConnectionString("MySQLConnection");
            builder.UseMySQL(connectionString);
            return new ModelContext(builder.Options);
        }
    }
}
