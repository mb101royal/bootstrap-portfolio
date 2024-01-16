using bootstrap_portfolio.Business.Helpers;
using bootstrap_portfolio.Business.Repository.Interfaces;
using bootstrap_portfolio.Contexts;
using Microsoft.EntityFrameworkCore;

namespace bootstrap_portfolio.Business.Repository.Implements
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        readonly BootstrapDbContext _context = null;
        protected DbSet<T> Table = null;

        public GenericRepository()
        {
            this._context = new BootstrapDbContext();

            Table = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync(bool isTracking = false)
        {
            return await Table.ToListAsync();
        }
       

        public async Task<T> GetById(int id, bool isTracking = false)
            // TODO: custom exceptions and AsNoTracking() side.
            => CommonHelpers.CheckId(id)
            ? (isTracking ? await Table.AsNoTracking().FirstOrDefaultAsync() ?? throw new Exception("Not found")
            : await Table.FindAsync(id) ?? throw new Exception("Not found"))
            : throw new Exception("Not found");

        public async Task AddToDbAsync(T vm)
        {
            await Table.AddAsync(vm);
        }

        public void Edit(int id, T vm)
        {
            if (CommonHelpers.CheckId(id))
            {
                Table.Attach(vm);

                _context.Entry(vm).State = EntityState.Modified;
            }
            else throw new Exception();
        }

        public async Task DeleteAsync(int id)
        {
            // TODO: custom exceptions.
            T existing = CommonHelpers.CheckId(id)
                ? await Table.FindAsync(id) ?? throw new Exception("Not found")
                : throw new Exception("Not found");

            Table.Remove(existing);
        }

        public Task SoftDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteRevert(int id)
        {
            throw new NotImplementedException();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
