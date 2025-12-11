using TekShop.Models.Entities;
using TekShop.Data;
using TekShop.Interface;

namespace TekShop.Repository
{
    public class OrderRepository(IDbContext context) : BaseRepository<Order>(context)
    {
    }
}