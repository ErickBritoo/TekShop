using TekShop.Models.Entities;
using TekShop.Data;

namespace TekShop.Repository
{
    public class OrderRepository(AppDbContext context) : RepositoryBase<Order>(context)
    {
    }
}