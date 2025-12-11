using TekShop.Data;
using TekShop.Interface;
using TekShop.Models.Entities;
namespace TekShop.Repository
{
    public class CategoryRepository(IDbContext context) : BaseRepository<Category>(context)
    {

    }
}