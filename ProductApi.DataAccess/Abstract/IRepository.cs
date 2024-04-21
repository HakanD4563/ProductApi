using Microsoft.EntityFrameworkCore.ChangeTracking;
using ProductApi.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.DataAccess.Abstract
{
    public interface IRepository<T> where T :BaseEntity
    {
        public Task<EntityEntry<T>> AddAsync(T Entity);
        public Task DeleteAsync(T Entity);
        public Task UpdateAsync(T Entity);
        public Task<IEnumerable<T>> GetAllAsync(Expression<Func<T,bool>> Filter =null,params string[] IncludeProperties);
        public Task<T> GetAsync(Expression<Func<T, bool>> Filter, params string[] IncludeProperties);
    }
}
