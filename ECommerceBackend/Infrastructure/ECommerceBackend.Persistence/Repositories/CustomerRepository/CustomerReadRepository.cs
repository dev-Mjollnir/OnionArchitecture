using ECommerceBackend.Application.Repositories.CustomerRepository;
using ECommerceBackend.Domain.Entites;
using ECommerceBackend.Persistence.Contexts;

namespace ECommerceBackend.Persistence.Repositories.CustomerRepository
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ECommerceBackendDbContext context) : base(context)
        {
        }
    }
}
