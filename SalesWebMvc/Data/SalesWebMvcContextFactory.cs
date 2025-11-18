using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SalesWebMvc.Data
{
    public class SalesWebMvcContextFactory : IDesignTimeDbContextFactory<SalesWebMvcContext>
    {
        public SalesWebMvcContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<SalesWebMvcContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("SalesWebMvcContext"));

            return new SalesWebMvcContext(optionsBuilder.Options);
        }
    }
}