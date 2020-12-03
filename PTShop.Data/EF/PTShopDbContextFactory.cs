using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PTShop.Data.EF
{
    public class PTShopDbContextFactory : IDesignTimeDbContextFactory<PTShopDbContext>
    {
        public PTShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("PTShopDb");

            var optionsBuilder = new DbContextOptionsBuilder<PTShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new PTShopDbContext(optionsBuilder.Options);
        }
    }
}
