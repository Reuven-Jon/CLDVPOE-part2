namespace CLDVPOE_part2.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryID { get; set; }
        public int ArtisanID { get; set; }

        public Category Category { get; set; }
        public Artisan Artisan { get; set; }
    }
}
