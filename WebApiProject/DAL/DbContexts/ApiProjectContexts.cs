using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;
using Microsoft.Extensions.Configuration;

namespace DAL.DbContexts
{
    public class ApiProjectContexts:DbContext
    {
        private IConfiguration _configuration;
        public ApiProjectContexts(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("MsComm");
            base.OnConfiguring(optionsBuilder.UseSqlServer(connectionString));
           

        }
    }
}
