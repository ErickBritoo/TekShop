namespace TekShop.Interface
{
    public interface IView<T> where T : class
    {
        void Show(T element);
        void ShowAll(List<T> elements);
    }
}