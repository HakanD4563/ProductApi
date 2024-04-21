using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.DataAccess.Abstract
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }   
        ICategoryRepository CategoryRepository { get; }
        IUserRepository UserRepository { get; } 
        Task<int> SaveChangeAsync();
    }
}
