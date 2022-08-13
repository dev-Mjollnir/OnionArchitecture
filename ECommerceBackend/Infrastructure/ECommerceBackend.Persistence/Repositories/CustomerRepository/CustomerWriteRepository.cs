using ECommerceBackend.Application.Repositories.CustomerRepository;
using ECommerceBackend.Domain.Entites;
using ECommerceBackend.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Persistence.Repositories.CustomerRepository
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ECommerceBackendDbContext context) : base(context)
        {
        }
    }
}
