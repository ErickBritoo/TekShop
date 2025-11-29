
namespace TekShop.Models.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public required float Price { get; set; }
        public required string Name { get; set; }
        public required Category Category { get; set; }
        public int QuantityInStock { get; set; }
        public bool IsActive { get; set; }
        public List<ItemOrder> OrderItems { get; set; } = new();

        public override string ToString()
        {
            return $"Nome: {Name}\n Preço: {Price:C}\n Categoria: {Category.Name}\n Quantidade em Estoque: {QuantityInStock}\n Ativo: {(IsActive ? "Sim" : "Não")}";
        }
    }
}