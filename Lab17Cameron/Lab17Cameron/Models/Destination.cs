using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab17Cameron.Models
{
    public class Destination
    {
        [Key]
        public int DestinationID { get; set; }
        public int SeasonID { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
    }
}
