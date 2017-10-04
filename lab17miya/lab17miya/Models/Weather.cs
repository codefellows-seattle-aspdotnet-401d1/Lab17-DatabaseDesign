using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab17miya.Models
{
    public class Weather
    {
        [Key]
        public int WeatherID
        {
            get; set;
        }
        public string WeatherType
        {
            get; set;
        }

    }
}
