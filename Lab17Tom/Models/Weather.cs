using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab17Tom.Models
{
    public class Weather
    {
        [Key]
        public int WeatherID { get; set; }
        public string Climate { get; set; }
    }
}
