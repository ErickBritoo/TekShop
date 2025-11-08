using TekShop.Models.Entities;
using TekShop.Data;

namespace TekShop.Repository
{
    public class ProductRepository(AppDbContext context) : BaseRepository<Product>(context)
    {
    }
}