using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer
{
    class ShoppingAppContextFactory:IDesignTimeDbContextFactory<ShoppingAppContext>
    {
        private IConfiguration configuration;
        public ShoppingAppContext CreateDbContext(string [] args)
        {

            AppConfigurations appConfig = new AppConfigurations();
            var opsBuilder = new DbContextOptionsBuilder<ShoppingAppContext>();
            opsBuilder.UseSqlServer(appConfig.sqlconstring);
            return new ShoppingAppContext(opsBuilder.Options);
        }
    }
}
