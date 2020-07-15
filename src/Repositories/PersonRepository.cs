using EFDatabaseContext;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public PersonRepository(ApplicationDbContext applicationDbContext):base(applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<Person> GetSingleAsync(int personId)
        {
            return await applicationDbContext.People.FirstOrDefaultAsync(x => x.PersonId == personId);
        }
    }
}
