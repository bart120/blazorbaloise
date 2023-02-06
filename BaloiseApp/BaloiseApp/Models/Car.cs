namespace BaloiseApp.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string? Model { get; set; }
        public int BrandID { get; set; }
        public decimal? Price { get; set; }
        public DateTime DateOfCirculation { get; set; }
    }
}
