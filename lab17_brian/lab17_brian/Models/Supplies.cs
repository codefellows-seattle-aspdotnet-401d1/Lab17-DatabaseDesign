using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab17_brian.Models
{
    public class Supplies
    {
        [Key]
        public int SuppliesID { get; set; }
        [Key]
        public int PackingListID { get; set; }
        public string Name { get; set; }
    }
}
