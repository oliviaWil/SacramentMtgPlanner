using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentMtgPlanner.Data;
using SacramentMtgPlanner.Models;

namespace SacramentMtgPlanner.Pages.Meetings
{
    public class SpeakersModel : PageModel
    {
        private readonly SacramentMtgPlanner.Data.SacramentMtgPlannerContext _context;

        public SpeakersModel(SacramentMtgPlanner.Data.SacramentMtgPlannerContext context)
        {
            _context = context;
        }

        public IList<Meeting> Meeting { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Meeting = await _context.Meeting.ToListAsync();
        }
    }
}
