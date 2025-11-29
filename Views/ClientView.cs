using TekShop.Interface;
using TekShop.Models.Entities;

namespace TekShop.Views
{
    public class ClientView : IView<Client>
    {
        public void Show(Client client)
        {
            System.Console.WriteLine(client.ToString());
        }

        public void ShowAll(List<Client> clients)
        {
            foreach (var c in clients)
            {
                System.Console.WriteLine(c.ToString());
            }
        }
    }
}