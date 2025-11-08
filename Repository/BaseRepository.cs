using System.Data.Common;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TekShop.Data;
using TekShop.Interface;

namespace TekShop.Repository
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<T?> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        virtual public async Task Add(T entity)
        {
            _dbSet.Add(entity);
            await SaveChanges();
        }

        virtual public async Task Delete(T entity)
        {
            _dbSet.Remove(entity);
            await SaveChanges();
        }

        virtual public async Task Delete(int id)
        {
            var entity = await GetById(id);
            if (entity != null)
                await Delete(entity);
        }

        virtual async public Task<IEnumerable<T?>> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.ToList();
        }

        virtual public List<T>? GetAll()
        {
            return [.. _dbSet];
        }

        public async Task Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await SaveChanges();
        }
    }
}