namespace CLDVPOE_part2.Models
{
    public class Artisan
    {
        public int ArtisanID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}