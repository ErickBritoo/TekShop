using TekShop.Models.Entities;
using TekShop.Data;

namespace TekShop.Repository
{
    public class ItemOrderRepository(AppDbContext context) : BaseRepository<ItemOrder>(context)
    {

    }
}