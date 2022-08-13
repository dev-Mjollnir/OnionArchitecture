using ECommerceBackend.Application.Repositories.ProductRepository;
using ECommerceBackend.Domain.Entites;
using ECommerceBackend.Persistence.Contexts;

namespace ECommerceBackend.Persistence.Repositories.ProductRepository
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ECommerceBackendDbContext context) : base(context)
        {
        }
    }
}
