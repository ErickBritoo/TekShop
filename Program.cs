using Microsoft.EntityFrameworkCore.Design;
using TekShop.Data;

namespace TekShop
{
    class Program
    {
        static void Main()
        {
            AppDbContext appContext = new AppDbContext("Server=127.0.0.1;Port=3306;User=root;Password=Erickdan456");
        }
    }
}