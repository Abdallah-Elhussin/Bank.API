using Bank.Infrastructure.RepositeryShared;
using Bank.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Bank.Infrastructure.RepositeryShared
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            int res = await _context.SaveChangesAsync();
            if (res > 0)
            {
                return entity;
            }
            else
            {
                return null;
            }
        }

        public async Task<int> AddRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
            int res = await _context.SaveChangesAsync();
            if (res > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public async Task<TEntity> Edit(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            int res = await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate, string[] includes = null)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>().Where(predicate);

            if (includes != null)
                foreach (var include in includes)
                    query = query.Include(include);

            return await query.AsNoTracking().AsSingleQuery().ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate, int? take, int? skip, string[] includes = null, Expression<Func<TEntity, object>> orderBy = null, string orderByDirection = OrderBy.Ascending)
        {

            IQueryable<TEntity> query = _context.Set<TEntity>().Where(predicate);

            if (take.HasValue)
                query = query.Take(take.Value);

            if (skip.HasValue)
                query = query.Skip(skip.Value);

            if (orderBy != null)
            {
                if (orderByDirection == OrderBy.Ascending)
                    query = query.OrderBy(orderBy);
                else
                    query = query.OrderByDescending(orderBy);
            }

            if (includes != null)
                foreach (var include in includes)
                    query = query.Include(include);

            return await query.AsNoTracking().AsSingleQuery().ToListAsync();
        }

        public async Task<TEntity> Get(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().AsSingleQuery().AsNoTracking().ToListAsync();
        }

        public async Task<int> Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            int res = await _context.SaveChangesAsync();
            if (res > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public async Task<int> RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
            int res = await _context.SaveChangesAsync();
            if (res > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public async Task<TEntity> SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().Where(predicate).AsTracking().SingleOrDefaultAsync();
        }
    }
}