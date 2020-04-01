using ContactApplication.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ContactApplication.Services
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DataBaseContext _context;
        private DbSet<T> entities;

        public Repository(DataBaseContext context)
        {
            _context = context;
            entities = context.Set<T>();
        }

        public async Task<int> AddAsync(T entity)
        {
            await entities.AddAsync(entity);
            return await SaveChangesAsync();

        }

        public async Task<int> DeleteAsync(T entity)
        {
            entities.Remove(entity);
            return await SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await entities.FindAsync(id);
        }

        public async Task<IEnumerable<T>> ListAsync(bool track = false)
        {
            var query = Query(entities, true);
            if (track)
                query = query.AsNoTracking();

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> predicate, bool track = false)
        {
            var query = Query(entities, true);
            if (track)
                query = query.AsNoTracking();

            return await query.Where(predicate).ToListAsync();
        }

        public async Task<int> UpdateAsync(T entity)
        {
            entities.Update(entity);
            return await SaveChangesAsync();
        }

        private async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        private IQueryable<T> Query(DbSet<T> entity, bool eager = false)
        {
            var query = entity.AsQueryable();
            if (eager)
            {
                foreach (var property in _context.Model.FindEntityType(typeof(T)).GetNavigations())
                    query = query.Include(property.Name);
            }
            return query;
        }
    }
}
