using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> genericRepository;

        public GenericService(IGenericRepository<T> genericRepository)
        {
            this.genericRepository = genericRepository;
        }
        public async Task<T> AddAsync(T entity) => await genericRepository.AddAsync(entity);

        public async Task DeleteAsync(T entity) => await genericRepository.DeleteAsync(entity);

        public Task EditAsync(T entity) => genericRepository.EditAsync(entity);

        public async Task<IQueryable<T>> FindByAsync(Expression<Func<T, bool>> predicate) => await genericRepository.FindByAsync(predicate);

        public async Task<IQueryable<T>> GetAllAsync() => await genericRepository.GetAllAsync();
    }
}
