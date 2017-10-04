using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab17miya.Models
{
    public class lab17miyaContext : DbContext
    {
        public lab17miyaContext (DbContextOptions<lab17miyaContext> options)
            : base(options)
        {
        }

        public DbSet<lab17miya.Models.Destination> Destination { get; set; }
    }
}
