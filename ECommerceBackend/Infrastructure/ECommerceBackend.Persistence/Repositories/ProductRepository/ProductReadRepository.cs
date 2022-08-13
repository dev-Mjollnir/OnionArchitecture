using ECommerceBackend.Application.Repositories.ProductRepository;
using ECommerceBackend.Domain.Entites;
using ECommerceBackend.Persistence.Contexts;

namespace ECommerceBackend.Persistence.Repositories.ProductRepository
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(ECommerceBackendDbContext context) : base(context)
        {
        }
    }
}
