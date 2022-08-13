using ECommerceBackend.Domain.Entites.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool isTracked);
        IQueryable<T> GetByFilter(Expression<Func<T, bool>> filter, bool isTracked);
        Task<T> GetByIdAsync(string id);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> filter);
    }
}
