using BackEnd.Data;
using BackEnd.Model;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Repository
{
    public interface IRepository<T> where T : BaseModel
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity, int id);
        Task DeleteAsync(int id);
    }

    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        protected readonly DBContext _context;
        protected DbSet<T> _dbSet;
        public Repository(DBContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            if (id > 0)
            {
                var deleted = await _dbSet.FindAsync(id);
                if (deleted != null)
                {
                    deleted.isDeleted = true;
                    _dbSet.Update(deleted);
                    await _context.SaveChangesAsync();
                }
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.Where(r => r.isDeleted != true).ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(r => r.Id == id && r.isDeleted != true);
        }

        public async Task UpdateAsync(T entity, int id)
        {
            if (id > 0)
            {
                var existingEntity = await _dbSet.FindAsync(id);
                if (existingEntity != null)
                {
                    _context.Entry(existingEntity).CurrentValues.SetValues(entity);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
}
