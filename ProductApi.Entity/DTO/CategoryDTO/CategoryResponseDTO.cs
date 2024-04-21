using ProductApi.Entity.DTO.BaseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Entity.DTO.CategoryDTO
{
    public class CategoryResponseDTO:BaseResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
