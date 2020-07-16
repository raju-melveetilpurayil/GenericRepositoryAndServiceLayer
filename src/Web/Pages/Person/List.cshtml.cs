using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;
using Models;

namespace Web.Pages.Person
{
    public class ListModel : PageModel
    {
        private readonly IPersonService personService;
        public IEnumerable<Models.Person> People { get; set; }

        public ListModel(IPersonService personService)
        {
            this.personService = personService;
        }
        public async Task OnGet()
        {
            People = await personService.GetAllAsync();
        }
    }
}