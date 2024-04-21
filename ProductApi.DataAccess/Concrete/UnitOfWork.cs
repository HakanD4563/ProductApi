using Microsoft.EntityFrameworkCore;
using ProductApi.DataAccess.Abstract;
using ProductApi.DataAccess.Context;
using ProductApi.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProductContext _context;
        public UnitOfWork(ProductContext context)
        {
            _context = context;
            UserRepository = new UserRepository (_context);
            ProductRepository = new ProductRepository (_context);
            CategoryRepository = new CategoryRepository (_context);
        }
        public IProductRepository ProductRepository { get; }

        public ICategoryRepository CategoryRepository {  get; }

        public IUserRepository UserRepository { get; }

        public Task<int> SaveChangeAsync()
        {
            foreach (var item in _context.ChangeTracker.Entries<BaseEntity>())
            {
                if (item.State == EntityState.Added)
                {
                    item.Entity.AddedTime = DateTime.Now;
                    item.Entity.UpdatedTime = DateTime.Now;
                }
                if (item.State == EntityState.Modified)
                {
                    item.Entity.UpdatedTime = DateTime.Now;
                }

            }
            return _context.SaveChangesAsync();
        }
    }
}
