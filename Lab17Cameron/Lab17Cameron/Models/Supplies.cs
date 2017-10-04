using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab17Cameron.Models
{
    public class Supplies
    {
        [Key]
        public int SuppliesID { get; set; }
        public int SeasonID { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public bool Required { get; set; }
    }
}
