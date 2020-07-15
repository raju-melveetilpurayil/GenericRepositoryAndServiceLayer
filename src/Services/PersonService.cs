using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        public async Task<Person> AddAsync(Person entity)
        {
            return await personRepository.AddAsync(entity);
        }

        public async Task DeleteAsync(Person entity)
        {
             await personRepository.DeleteAsync(entity);
        }

        public async Task EditAsync(Person entity)
        {
            await personRepository.EditAsync(entity);
        }

        public async Task<IQueryable<Person>> FindByAsync(Expression<Func<Person, bool>> predicate)
        {
            return await personRepository.FindByAsync(predicate);
        }

        public async Task<IQueryable<Person>> GetAllAsync()
        {
            return await personRepository.GetAllAsync();
        }

        public async Task<Person> GetSingleAsync(int personId)
        {
            return await personRepository.GetSingleAsync(personId);
        }
    }
}
