using ECommerceBackend.Application.Repositories;
using ECommerceBackend.Domain.Entites.Common;
using ECommerceBackend.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ECommerceBackend.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly ECommerceBackendDbContext _context;

        public WriteRepository(ECommerceBackendDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();
        public async Task<bool> AddAsync(T model)
        {
            var entity = await Table.AddAsync(model);
            return entity.State == EntityState.Added;
        }
        public async Task<bool> AddRangeAsync(List<T> model)
        {
            await Table.AddRangeAsync(model);
            return true;
        }

        public bool Remove(T model)
        {
            var entity = Table.Remove(model);
            return entity.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveByIdAsync(string id)
        {
            var record = await Table.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
            return Remove(record);
        }

        public bool RemoveRange(List<T> model)
        {
            Table.RemoveRange(model);
            return true;
        }

        public bool Update(T model)
        {
            var entity = Table.Update(model);
            return entity.State == EntityState.Modified;
        }

        public bool UpdateRange(List<T> model)
        {
            Table.UpdateRange(model);
            return true;
        }

        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();
    }
}
