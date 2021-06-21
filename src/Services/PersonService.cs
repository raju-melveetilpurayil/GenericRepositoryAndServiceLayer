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
    public class PersonService :GenericService<Person>, IPersonService
    {
        private readonly IPersonRepository personRepository;

        public PersonService(IPersonRepository personRepository):base(personRepository)
        {
            this.personRepository = personRepository;
        }
        public async Task<Person> GetSingleAsync(int personId)
        {
            return await personRepository.GetSingleAsync(personId);
        }
    }
}
