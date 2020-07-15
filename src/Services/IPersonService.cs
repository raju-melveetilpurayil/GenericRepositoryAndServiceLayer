using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
   public interface IPersonService:IGenericService<Person>
    {
        Task<Person> GetSingleAsync(int personId);
    }
}
