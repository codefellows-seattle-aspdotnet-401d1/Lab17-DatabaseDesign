using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab17George.Models
{
    public class Lab17GeorgeContext : DbContext
    {
        public Lab17GeorgeContext (DbContextOptions<Lab17GeorgeContext> options)
            : base(options)
        {
        }

        public DbSet<Lab17George.Models.Destination> Destination { get; set; }
    }
}
