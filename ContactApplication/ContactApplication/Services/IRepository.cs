using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ContactApplication.Services
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> ListAsync(bool track = false);
        Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> predicate, bool track = false);
        Task<int> AddAsync(T entity);
        Task<int> DeleteAsync(T entity);
        Task<int> UpdateAsync(T entity);
    }
}
