using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace lab17DatabaseDesign.Models
{
    public class lab17DatabaseDesignContext : DbContext
    {
        public lab17DatabaseDesignContext(DbContextOptions<lab17DatabaseDesignContext> options)
            : base(options)
        {
        }

        public DbSet<lab17DatabaseDesign.Models.Destinations> Destinations { get; set; }
        public DbSet<lab17DatabaseDesign.Models.Recomendeds> Recomendeds { get; set; }
        public DbSet<lab17DatabaseDesign.Models.Requireds> Required { get; set; }

        public DbSet<lab17DatabaseDesign.Models.DestinationSupplies> DestinationSupplies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DestinationSupplies>().ToTable("DestinationSupplies");
            modelBuilder.Entity<DestinationSupplies>().HasKey(c => new { c.DestinationID, c.RecomendedsID });
        }
    };

    
}
