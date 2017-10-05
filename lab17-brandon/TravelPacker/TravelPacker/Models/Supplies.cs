using System.ComponentModel.DataAnnotations;

namespace TravelPacker.Models
{
    public class Supplies
    {
        [Key]
        public int ID { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }
    }
}
