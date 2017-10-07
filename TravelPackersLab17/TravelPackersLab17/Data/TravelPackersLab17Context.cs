using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TravelPackersLab17.Models
{
    public class TravelPackersLab17Context : DbContext
    {
        public TravelPackersLab17Context (DbContextOptions<TravelPackersLab17Context> options)
            : base(options)
        {
        }

        public DbSet<TravelPackersLab17.Models.Destination> Destination { get; set; }
        public DbSet<TravelPackersLab17.Models.Supplies> Supplies { get; set; }
        public DbSet<TravelPackersLab17.Models.Weather> Weather { get; set; }


    }
}
