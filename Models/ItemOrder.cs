using TekShop.Models.Entities;

namespace TekShop.Models.Entities
{
    public class ItemOrder
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public float SubTotal { get; private set; }

        public required Order Order { get; set; }
        public required Product Product { get; set; }

        public int OrderID { get; set; }
        public int ProductID { get; set; }

    }
}