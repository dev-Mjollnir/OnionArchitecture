using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Persistence.Configurations
{
    static class DbContextConnectionString
    {
        /// <summary>
        /// Get connection string for DesignTimeDbContextFactory
        /// </summary>
        public static string ECommerceDbContext
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ECommerceBackend.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("ECommerceBackendDbConnectionString");
            }
        }
    }
}
