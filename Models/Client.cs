namespace TekShop.Models.Entities
{
    public class Client
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public string? Email { get; set; }
        public DateTime RegistrationDate { get; private set; }
        public bool IsActive { get; set; } = false;
        public required string Cpf { get; set; }
    }
}