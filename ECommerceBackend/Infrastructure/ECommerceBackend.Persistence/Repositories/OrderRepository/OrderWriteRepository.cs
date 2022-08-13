using ECommerceBackend.Application.Repositories.OrderRepository;
using ECommerceBackend.Domain.Entites;
using ECommerceBackend.Persistence.Contexts;

namespace ECommerceBackend.Persistence.Repositories.OrderRepository
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(ECommerceBackendDbContext context) : base(context)
        {
        }
    }
}
