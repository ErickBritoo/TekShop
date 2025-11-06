using TekShop.Models.Entities;

namespace TekShop.Models.Entities
{
    class ItemOrder
    {
        public int ID;
        public int Quantity { get; set; }
        public float SubTotal { get; private set; }
        public Product ProductID { get; set; }
    }
}