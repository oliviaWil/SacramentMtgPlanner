﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly SacramentMtgPlanner.Data.SacramentMtgPlannerContext _context;

        public DetailsModel(SacramentMtgPlanner.Data.SacramentMtgPlannerContext context)
        {
            _context = context;
        }

        public Meeting Meeting { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meeting.FirstOrDefaultAsync(m => m.Id == id);
            if (meeting == null)
            {
                return NotFound();
            }
            else
            {
                Meeting = meeting;
            }
            return Page();
        }
    }
}
