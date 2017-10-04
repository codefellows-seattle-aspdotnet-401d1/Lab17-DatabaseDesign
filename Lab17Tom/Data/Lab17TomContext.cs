using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab17Tom.Models;

namespace Lab17Tom.Models
{
    public class Lab17TomContext : DbContext
    {
        public Lab17TomContext (DbContextOptions<Lab17TomContext> options)
            : base(options)
        {
        }

        public DbSet<Lab17Tom.Models.Destinations> Destinations { get; set; }

        public DbSet<Lab17Tom.Models.Supplies> Supplies { get; set; }

        public DbSet<Lab17Tom.Models.Weather> Weather { get; set; }
    }
}
