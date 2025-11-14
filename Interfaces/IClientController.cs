using TekShop.Models.Entities;

namespace TekShop.Interface
{
    interface IController<T> where T : class
    {
        public Task Add(T entity);
        public Task<T?> GetById(int id);
        public List<T>? GetAll();
        public Task Update(T entity);
        public Task Delete(T entity);
        public Task Delete(int id);
    }
}