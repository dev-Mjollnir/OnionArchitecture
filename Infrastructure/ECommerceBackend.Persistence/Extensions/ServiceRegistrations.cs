using ECommerceBackend.Application.Repositories.CustomerRepository;
using ECommerceBackend.Application.Repositories.OrderRepository;
using ECommerceBackend.Application.Repositories.ProductRepository;
using ECommerceBackend.Persistence.Configurations;
using ECommerceBackend.Persistence.Contexts;
using ECommerceBackend.Persistence.Repositories.CustomerRepository;
using ECommerceBackend.Persistence.Repositories.OrderRepository;
using ECommerceBackend.Persistence.Repositories.ProductRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Persistence.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            AddDbContext(services);
            AddRepositories(services);
        }

        private static void AddDbContext(IServiceCollection services)
        {
            services.AddDbContext<ECommerceBackendDbContext>(options => options.UseNpgsql(DbContextConnectionString.ECommerceDbContext));
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
