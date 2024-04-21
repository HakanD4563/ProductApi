using ProductApi.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.DataAccess.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
    }
}
