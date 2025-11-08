using TekShop.Models.Entities;
using TekShop.Data;

namespace TekShop.Repository
{
    public class OrderRepository(AppDbContext context) : BaseRepository<Order>(context)
    {
    }
}