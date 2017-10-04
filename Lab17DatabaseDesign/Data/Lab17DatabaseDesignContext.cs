using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab17DatabaseDesign.Models;

namespace Lab17DatabaseDesign.Models
{
    public class Lab17DatabaseDesignContext : DbContext
    {
        public Lab17DatabaseDesignContext (DbContextOptions<Lab17DatabaseDesignContext> options)
            : base(options)
        {
        }

        public DbSet<Lab17DatabaseDesign.Models.Destination> Destination { get; set; }

        public DbSet<Lab17DatabaseDesign.Models.EquipmentSet> EquipmentSet { get; set; }

        public DbSet<Lab17DatabaseDesign.Models.TravelItem> TravelItem { get; set; }
    }
}
