using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TravelPacker.Models
{
    public class Destination
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string LocationName { get; set; }
        public string Country { get; set; }
        public string Climate { get; set; }
        public ICollection<int> SuppliesIDs { get; set; }

        public Destination(string locName, string country, string climate, ICollection<int> supplies)
        {
            ICollection<int> SuppliesIDs = new List<int>();
            LocationName = locName;
            Country = country;
            Climate = climate;
            SuppliesIDs = supplies;
        }
    }
}
