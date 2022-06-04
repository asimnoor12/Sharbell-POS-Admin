using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Database.Core
{
    public class POSContext : DbContext
    {
        public POSContext()
        {
        }
        public POSContext(DbContextOptions<POSContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration["ConnectionString:POSLocalDB_CONNECTION"];
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
