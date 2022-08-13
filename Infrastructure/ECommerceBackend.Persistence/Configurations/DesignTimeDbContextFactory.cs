using ECommerceBackend.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Persistence.Configurations
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ECommerceBackendDbContext>
    {
        public ECommerceBackendDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ECommerceBackendDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(DbContextConnectionString.ECommerceDbContext);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
