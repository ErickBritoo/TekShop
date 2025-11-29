using TekShop.Models.Entities;
using TekShop.Interface;

namespace TekShop.Controllers
{
    public class ClientController : ControllerBase<Client>
    {
        public ClientController(IRepository<Client> repository) : base(repository)
        {
        }
    }
}