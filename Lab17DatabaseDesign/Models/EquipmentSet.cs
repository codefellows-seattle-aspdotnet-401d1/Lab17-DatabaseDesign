using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab17DatabaseDesign.Models
{
    public class EquipmentSet
    {
        public int ID { get; set; }
        public string SetName { get; set; }
        public ICollection<TravelItem> Items { get; set; }
    }
}
