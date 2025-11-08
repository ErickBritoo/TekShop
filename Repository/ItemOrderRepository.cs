using TekShop.Models.Entities;
using TekShop.Data;

namespace TekShop.Repository
{
    public class ItemOrderRepository(AppDbContext context) : RepositoryBase<ItemOrder>(context)
    {

    }
}