using System.Text;

namespace TekShop.Models.Entities
{
    public enum Status
    {
        Aberto,
        Pago,
        Cancelado

    }

    public class Order
    {
        public int ID { get; set; }
        public required Client ClientOrder { get; set; }
        public DateTime Date { get; set; }
        public Status StatusOrder { get; set; }
        public required List<ItemOrder> ItemOrders { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Cliente: {ClientOrder.Name}");
            sb.AppendLine($"Data: {Date}");
            sb.AppendLine($"Status: {StatusOrder}");
            sb.AppendLine("Itens do Pedido:");
            foreach (var item in ItemOrders)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}