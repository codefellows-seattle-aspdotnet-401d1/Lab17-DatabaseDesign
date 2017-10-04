using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab17Tom.Models
{
    public class Destinations
    {
        [Key]
        public int DestinationID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int WeatherID { get; set; }
    }
}
