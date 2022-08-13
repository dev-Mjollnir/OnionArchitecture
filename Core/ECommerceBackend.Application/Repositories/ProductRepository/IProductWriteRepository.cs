using ECommerceBackend.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Application.Repositories.ProductRepository
{
    public interface IProductWriteRepository : IWriteRepository<Product>
    {
    }
}
