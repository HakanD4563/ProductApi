using Microsoft.EntityFrameworkCore.ChangeTracking;
using ProductApi.DataAccess.Abstract;
using ProductApi.DataAccess.Context;
using ProductApi.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.DataAccess.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;
        public ProductRepository(ProductContext context)
        {
            _context = context;
        }

        public Task<EntityEntry<Product>> AddAsync(Product Entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Product Entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllAsync(Expression<Func<Product, bool>> Filter = null, params string[] IncludeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetAsync(Expression<Func<Product, bool>> Filter, params string[] IncludeProperties)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product Entity)
        {
            throw new NotImplementedException();
        }
    }
}
