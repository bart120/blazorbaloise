using System.ComponentModel.DataAnnotations;

namespace ServicesLibrary.Models
{
    public class Car
    {
        public int ID { get; set; }
        [Required]
        public string? Model { get; set; }
        [Required]
        public int BrandID { get; set; }
        [Required]
        public decimal? Price { get; set; }
        [Required]
        public DateTime DateOfCirculation { get; set; }
    }
}
