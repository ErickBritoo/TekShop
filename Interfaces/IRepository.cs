using System.Linq.Expressions;

namespace TekShop.Interface
{
    public interface IRepository<T> where T : class
    {
        public Task<T?> GetById(int id);
        public Task<List<T>>? GetAll();
        public Task<IEnumerable<T?>> Find(Expression<Func<T, bool>> predicate);

        public Task Add(T entity);
        public Task Update(T entity);
        public Task Delete(T entity);
        public Task Delete(int id);

        public Task SaveChanges();
    }
}