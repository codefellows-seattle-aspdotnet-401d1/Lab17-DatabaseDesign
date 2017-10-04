using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab17Tom.Models
{
    public class Supplies
    {
        [Key]
        public int SupplyID { get; set; }
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public decimal Volume { get; set; }
        public int Qty { get; set; }
        public int WeatherID { get; set; }
        public bool IsRequired { get; set; }
        [ForeignKey("DestinationForeignKey")]
        public int DestinationID { get; set; }
    }
}
