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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ProductContext _context;

        public CategoryRepository(ProductContext context)
        {
            _context = context;
        }

        public Task<EntityEntry<Category>> AddAsync(Category Entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Category Entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetAllAsync(Expression<Func<Category, bool>> Filter = null, params string[] IncludeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetAsync(Expression<Func<Category, bool>> Filter, params string[] IncludeProperties)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Category Entity)
        {
            throw new NotImplementedException();
        }
    }
}
