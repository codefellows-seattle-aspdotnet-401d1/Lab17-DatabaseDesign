using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab17DatabaseDesign.Models
{
    public class Destinations
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Currncy { get; set; }
        public ICollection<Required> Required { get; set; }
        public ICollection<Recomended> Recomended { get; set; }
        
    }
}
