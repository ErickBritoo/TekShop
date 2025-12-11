using TekShop.Models.Entities;
using TekShop.Data;
using TekShop.Interface;

namespace TekShop.Repository
{
    public class ProductRepository(IDbContext context) : BaseRepository<Product>(context)
    {
    }
}