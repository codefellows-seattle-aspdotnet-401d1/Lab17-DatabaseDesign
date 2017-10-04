using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab17DatabaseDesign.Models
{
    public class lab17DatabaseDesignContext : DbContext
    {
        public lab17DatabaseDesignContext (DbContextOptions<lab17DatabaseDesignContext> options)
            : base(options)
        {
        }

        public DbSet<lab17DatabaseDesign.Models.Destinations> Destinations { get; set; }
        public DbSet<lab17DatabaseDesign.Models.Recomended> Recomended { get; set; }
        public DbSet<lab17DatabaseDesign.Models.Required> Required { get; set; }

    }
}
