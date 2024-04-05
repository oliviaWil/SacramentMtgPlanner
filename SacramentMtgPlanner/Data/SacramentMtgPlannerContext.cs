using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SacramentMtgPlanner.Models;

namespace SacramentMtgPlanner.Data
{
    public class SacramentMtgPlannerContext : DbContext
    {
        public SacramentMtgPlannerContext (DbContextOptions<SacramentMtgPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<SacramentMtgPlanner.Models.Meeting> Meeting { get; set; } = default!;
    }
}
