using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Design;
using TekShop.Data;
using TekShop.Interface;
using TekShop.Models.Entities;

namespace TekShop.Repository
{
    class ClientRepository(AppDbContext appDbContext) : BaseRepository<Client>(appDbContext)
    {
    }
}