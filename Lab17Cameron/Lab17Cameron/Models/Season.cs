using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab17Cameron.Models
{
    public class Season
    {
        [Key]
        public int SeasonID { get; set; }
        public int DestinationID { get; set; }
        public int Winter { get; set; }
        public int Spring { get; set; }
        public int Summer { get; set; } 
        public int Fall { get; set; }
    }
}
