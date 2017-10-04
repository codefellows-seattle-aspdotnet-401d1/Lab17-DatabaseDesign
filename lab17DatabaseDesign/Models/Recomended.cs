using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab17DatabaseDesign.Models
{
    public enum Size
    {
        Pocket, Small, Large
    }

    public enum Weight
    {
        Light, Medium, Heavy
    }

    public class Recomended
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public Size Size { get; set; }
        public Weight Weight { get; set; }

    }
}
