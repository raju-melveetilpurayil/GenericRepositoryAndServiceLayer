using EFDatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public GenericRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _applicationDbContext.AddAsync(entity);
            await _applicationDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task DeleteAsync(T entity)
        {
            _applicationDbContext.Remove(entity);
            await _applicationDbContext.SaveChangesAsync();
        }

       


        public async Task EditAsync(T entity)
        {
            _applicationDbContext.Entry(entity).State = EntityState.Modified;
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task<IQueryable<T>> FindByAsync(Expression<Func<T, bool>> predicate)
        {
            return (IQueryable<T>)await _applicationDbContext.Set<T>().Where(predicate).ToListAsync();
        }


        public async Task<IQueryable<T>> GetAllAsync()
        {
            return await Task.Run(() => _applicationDbContext.Set<T>());
        }

    }
}
