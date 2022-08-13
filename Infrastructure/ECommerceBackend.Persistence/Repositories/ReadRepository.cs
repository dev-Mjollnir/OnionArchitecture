using ECommerceBackend.Application.Repositories;
using ECommerceBackend.Domain.Entites.Common;
using ECommerceBackend.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ECommerceBackendDbContext _context;

        public ReadRepository(ECommerceBackendDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool isTracked) => !isTracked ? Table.AsNoTracking() : Table.AsTracking();

        public IQueryable<T> GetByFilter(Expression<Func<T, bool>> filter, bool isTracked) =>
            !isTracked ? Table.Where(filter).AsNoTracking() : Table.Where(filter).AsTracking();

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> filter) => await Table.FirstOrDefaultAsync(filter);

        public async Task<T> GetByIdAsync(string id) => await Table.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
    }
}
