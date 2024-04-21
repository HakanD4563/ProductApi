using ProductApi.Entity.DTO.ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Business.Abstract
{
    public interface IProductService:IGenericService<ProductResponseDTO,ProductRequestDTO>
    {
    }
}
