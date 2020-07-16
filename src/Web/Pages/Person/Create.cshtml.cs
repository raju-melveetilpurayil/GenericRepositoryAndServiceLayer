using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EFDatabaseContext;
using Models;
using Services;

namespace Web.Pages.Person
{
    public class CreateModel : PageModel
    {
        private readonly IPersonService personService;

        public CreateModel(IPersonService personService)
        {
            this.personService = personService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.Person Person { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await personService.AddAsync(Person);
            return RedirectToPage("./List");
        }
    }
}
