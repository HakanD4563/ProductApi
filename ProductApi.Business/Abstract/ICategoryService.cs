using ProductApi.Entity.DTO.CategoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Business.Abstract
{
    public interface ICategoryService:IGenericService<CategoryResponseDTO,CategoryRequestDTO>
    {
    }
}
