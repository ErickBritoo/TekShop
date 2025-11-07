using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TekShop.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            var connectionString = "Server=127.0.0.1;Port=3306;Database=TekShop;User=root;Password=Erickdan456";

            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(connectionString));

            return new AppDbContext(optionsBuilder.Options);
        }

    }
}