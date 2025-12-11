using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TekShop.Models.Entities;

namespace TekShopj.Data.ModelsConfigs
{
    internal class ClientConfigs : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasIndex(c => c.Cpf).IsUnique();
            builder.HasIndex(c => c.Email).IsUnique();
        }
    }
}