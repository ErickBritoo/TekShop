using Microsoft.EntityFrameworkCore;
using TekShop.Models.Entities;
using Pomelo.EntityFrameworkCore.MySql;

namespace TekShop.Data
{
    public class AppDbContext(string connectionString) : DbContext
    {
        private string _connectionString = connectionString;
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ItemOrder> ItemOrders { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
        }
    }
}