using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Infrastructure.RepositeryShared
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Get(int id);
        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate, string[] includes = null);
        // This method was not in the videos, but I thought it would be useful to add.
        Task<TEntity> SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> Add(TEntity entity);
        Task<TEntity> Edit(TEntity entity);
        Task<int> AddRange(IEnumerable<TEntity> entities);
        Task<int> Remove(TEntity entity);
        Task<int> RemoveRange(IEnumerable<TEntity> entities);
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate, int? take, int? skip, string[] includes = null, Expression<Func<TEntity, object>> orderBy = null, string orderByDirection = OrderBy.Ascending);
    }
}
