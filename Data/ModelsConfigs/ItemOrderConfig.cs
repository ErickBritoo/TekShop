using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TekShop.Models.Entities;

namespace TekShop.Data.ModelsConfigs
{
    class ItemOrderConfigs : IEntityTypeConfiguration<ItemOrder>
    {
        public void Configure(EntityTypeBuilder<ItemOrder> builder)
        {
            builder.HasOne(it => it.Order).WithMany(o => o.ItemOrders).HasForeignKey(io => io.OrderID);
            builder.HasOne(io => io.Product).WithMany(p => p.OrderItems).HasForeignKey(io => io.ProductID);
        }
    }
}