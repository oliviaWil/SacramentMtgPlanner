using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SacramentMtgPlanner.Data;
using SacramentMtgPlanner.Models;

namespace SacramentMtgPlanner.Pages.Meetings
{
    public class CreateModel : PageModel
    {
        private readonly SacramentMtgPlanner.Data.SacramentMtgPlannerContext _context;

        public CreateModel(SacramentMtgPlanner.Data.SacramentMtgPlannerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Meeting Meeting { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Meeting.Add(Meeting);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
