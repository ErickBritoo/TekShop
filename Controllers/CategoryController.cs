using TekShop.Interface;
using TekShop.Models.Entities;

namespace TekShop.Controllers
{
    public class CategoryController : ControllerBase<Category>
    {
        public CategoryController(IRepository<Category> repository) : base(repository)
        {
        }
    }
}