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
    public class IndexModel : PageModel
    {
        private readonly SacramentMtgPlanner.Data.SacramentMtgPlannerContext _context;

        public IndexModel(SacramentMtgPlanner.Data.SacramentMtgPlannerContext context)
        {
            _context = context;
        }

        public string SpeakerSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public IList<Meeting> Meeting { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            // using System;
            SpeakerSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<Meeting> studentsIQ = from s in _context.Meeting
                                             select s;

            switch (sortOrder)
            {
                case "name_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.Speakers);
                    break;
                case "Date":
                    studentsIQ = studentsIQ.OrderBy(s => s.DateOfMeeting);
                    break;
                case "date_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.DateOfMeeting);
                    break;
                default:
                    studentsIQ = studentsIQ.OrderBy(s => s.Speakers);
                    break;
            }

            Meeting = await studentsIQ.AsNoTracking().ToListAsync();
        }

        //public IList<Meeting> Meeting { get;set; } = default!;

        //public async Task OnGetAsync()
        //{
        //    Meeting = await _context.Meeting.ToListAsync();
        //}
    }
}
