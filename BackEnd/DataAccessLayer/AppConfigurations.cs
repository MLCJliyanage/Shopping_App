using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Text;

namespace DataAccessLayer
{
    class AppConfigurations
    {
        
        public string sqlconstring { get; set; }
        public AppConfigurations()
        {
            var configbuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configbuilder.AddJsonFile(path, false);
            var root = configbuilder.Build();
            var appsetting = root.GetSection("ConnectionStrings:DefaultConnection");
            sqlconstring = appsetting.Value;
        }
    }
}
