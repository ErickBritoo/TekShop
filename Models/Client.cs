using System.ComponentModel.DataAnnotations.Schema;

namespace TekShop.Models.Entities
{
    public class Client
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public string? Email { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = false;
        [Column(TypeName = "varchar(14)")]
        public required string Cpf { get; set; }


        public override string ToString()
        {
            return $"Nome: {Name}\n Email: {Email}\n CPF: {Cpf}\n Data de Registro: {RegistrationDate}\n Ativo: {(IsActive ? "Sim" : "Não")}";
        }
    }
}