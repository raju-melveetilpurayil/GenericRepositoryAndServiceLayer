using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IPersonRepository:IGenericRepository<Person>
    {
        Task<Person> GetSingleAsync(int personId);
    }
}
