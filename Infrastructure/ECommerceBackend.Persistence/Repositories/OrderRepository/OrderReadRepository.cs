using ECommerceBackend.Application.Repositories.OrderRepository;
using ECommerceBackend.Domain.Entites;
using ECommerceBackend.Persistence.Contexts;

namespace ECommerceBackend.Persistence.Repositories.OrderRepository
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(ECommerceBackendDbContext context) : base(context)
        {
        }
    }
}
