using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ProductApi.DataAccess.Abstract;
using ProductApi.DataAccess.Context;
using ProductApi.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly ProductContext _context;
        private readonly DbSet<User> _dbSet;


        public UserRepository(ProductContext context)
        {
            _context = context;
            _dbSet = context.Set<User>();
        }

        public async Task<EntityEntry<User>> AddAsync(User Entity)
        {
            return await _dbSet.AddAsync(Entity);
        }

        public async Task DeleteAsync(User Entity)
        {
            await Task.Run(() => _dbSet.Remove(Entity));
        }

        public async Task<IEnumerable<User>> GetAllAsync(Expression<Func<User, bool>> Filter = null, params string[] IncludeProperties)
        {
            IQueryable<User> query;
            query = _dbSet;

            if (Filter != null)
            {
                query = query.Where(Filter);
            }
            if (IncludeProperties.Length>0)
            {
                foreach (var includeProperty in IncludeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }
            return await Task.Run(()=> query);

        }

        public Task<User> GetAsync(Expression<Func<User, bool>> Filter, params string[] IncludeProperties)
        {
            IQueryable<User> query;
            query = _dbSet;

            if (IncludeProperties.Length>0)
            {
                foreach(var includeProperty in IncludeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }
            return query.SingleOrDefaultAsync(Filter);
        }

        public async Task UpdateAsync(User Entity)
        {
            await Task.Run(()=>_dbSet.Update(Entity));
        }
    }
}
