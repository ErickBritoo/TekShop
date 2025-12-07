using Microsoft.EntityFrameworkCore;
using TekShop.Models.Entities;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.Extensions.Options;
using TekShopj.Data.ModelsConfigs;
using TekShop.Data.ModelsConfigs;

namespace TekShop.Data
{

    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ItemOrder> ItemOrders { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration<Client>(new ClientConfigs());
            modelBuilder.ApplyConfiguration<ItemOrder>(new ItemOrderConfigs());
        }

    }
}