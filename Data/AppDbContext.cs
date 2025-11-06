using Microsoft.EntityFrameworkCore;
using TekShop.Models.Entities;
using Pomelo.EntityFrameworkCore.MySql;

namespace TekShop.Data
{
    class AppDbContext(string connectionString) : DbContext
    {
        private string _connectionString = connectionString;
        DbSet<Category> Categories { get; set; }
        DbSet<Client> Clients { get; set; }
        DbSet<ItemOrder> ItemOrders { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
        }
    }
}