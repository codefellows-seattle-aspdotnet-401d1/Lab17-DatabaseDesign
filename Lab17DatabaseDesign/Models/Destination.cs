using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab17DatabaseDesign.Models
{
    public class Destination
    {
        public int ID { get; set; }
        public string LocationName { get; set; }
        public string Description { get; set; }
        public string Distance { get; set; }
        public string EquipmentSetID { get; set; }
        public string PosterPath { get; set; }
    }
}
