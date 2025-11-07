using Microsoft.EntityFrameworkCore;
using TekShop.Data;
using TekShop.Models.Entities;
namespace TekShop
{
    class Program
    {
        static async Task Main()
        {
            var factory = new AppDbContextFactory();
            AppDbContext appDbContext = factory.CreateDbContext([]);

        }
    }
}