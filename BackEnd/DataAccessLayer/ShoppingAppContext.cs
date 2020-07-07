using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class ShoppingAppContext : DbContext
    {
        public class OptionsBuild 
        {
            private IConfiguration configuration;
            public OptionsBuild()
            {
                settings = new AppConfigurations();
                optionsBuilder = new DbContextOptionsBuilder<ShoppingAppContext>();
                optionsBuilder.UseSqlServer(settings.sqlconstring);
                dbOptions = optionsBuilder.Options;
            }
            public DbContextOptionsBuilder<ShoppingAppContext> optionsBuilder { get; set; }
            public DbContextOptions<ShoppingAppContext> dbOptions { get; set; }
            private AppConfigurations settings { get; set; }
        }

        public static OptionsBuild ops = new OptionsBuild();

        public ShoppingAppContext(DbContextOptions<ShoppingAppContext> options): base(options) { }
        public DbSet<Category> Categories { get; set;}
        public DbSet<Product> Products { get; set; }
    }
}
        