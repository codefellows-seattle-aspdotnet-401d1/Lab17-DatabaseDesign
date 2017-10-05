using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab17_brian.Data
{
    public class TravelDBContext : DbContext
    {
        public TravelDBContext(DbContextOptions<TravelDBContext> options)
            : base(options)
        {
        }

        public DbSet<lab17_brian.Models.Destination> Destination { get; set; }
        public DbSet<lab17_brian.Models.PackingList> PackingList { get; set; }
        public DbSet<lab17_brian.Models.Supplies> Supplies { get; set; }
    }
}
