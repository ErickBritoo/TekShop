using TekShop.Interface;

namespace TekShop.Views
{
    public abstract class BaseView<T> : IView<T> where T : class
    {
        public void Show(T element)
        {
            System.Console.WriteLine(element.ToString());
        }

        public void ShowAll(List<T> elements)
        {
            foreach (var e in elements)
            {
                System.Console.WriteLine(elements.ToString());
            }
        }
    }
}