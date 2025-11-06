
namespace TekShop.Models.Entities
{
    enum Status
    {
        Aberto,
        Pago,
        Cancelado

    }

    class Order
    {
        public int ID;
        public Client ClientOrder { get; set; }
        public DateTime Date { get; set; }
        public Status StatusOrder { get; set; }
        public List<ItemOrder> ItemOrders { get; set; }
    }
}