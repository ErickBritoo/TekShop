using TekShop.Interface;
using TekShop.Models.Entities;

namespace TekShop.Controllers
{
    public class ProductController : ControllerBase<Product>
    {
        public ProductController(IRepository<Product> repository) : base(repository)
        {
        }
    }
}