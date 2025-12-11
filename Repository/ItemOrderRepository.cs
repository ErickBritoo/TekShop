using TekShop.Models.Entities;
using TekShop.Data;
using TekShop.Interface;

namespace TekShop.Repository
{
    public class ItemOrderRepository(IDbContext context) : BaseRepository<ItemOrder>(context)
    {

    }
}