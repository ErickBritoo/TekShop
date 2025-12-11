using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TekShop.Interface;

namespace TekShop.Data
{
    public class EfDbContextAdapter : IDbContext
    {
        private readonly AppDbContext _context;

        public EfDbContextAdapter(AppDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Set<T>() where T : class => _context.Set<T>();

        public Task<int> SaveChangesAsync() => _context.SaveChangesAsync();

        public EntityEntry Entry(object entity) => _context.Entry(entity);
    }

}