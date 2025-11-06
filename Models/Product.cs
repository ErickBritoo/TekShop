
namespace TekShop.Models.Entities
{
    class Product
    {
        public int ID { get; set; }
        public required float Price { get; set; }
        public required string Name { get; set; }
        public required Category Category { get; set; }
        public int QuantityInStock { get; set; }
        public bool IsActive { get; set; }
    }
}