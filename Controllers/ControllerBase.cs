using System.Linq.Expressions;
using System.Threading.Tasks;
using TekShop.Interface;
using TekShop.Models.Entities;

namespace TekShop.Controllers
{
    public abstract class ControllerBase<T> : IController<T> where T : class
    {
        private readonly IRepository<T> _repository;

        public ControllerBase(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task Add(T entity)
        {
            await _repository.Add(entity);
        }

        public async Task Delete(T entity)
        {
            await _repository.Delete(entity);
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }

        public async Task<List<T>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<T?> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task Update(T entity)
        {
            await _repository.Update(entity);
        }

    }
}