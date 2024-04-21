using AutoMapper;
using ProductApi.Entity.DTO.ProductDTO;
using ProductApi.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Business.Mapper.ProductMapper
{
    public class ProductResponseDTOMapper:Profile
    {
        public ProductResponseDTOMapper()
        {
            CreateMap<Product, ProductResponseDTO>().ForMember(dest=>dest.CategoryName, opt =>
            {
                opt.MapFrom(src=>src.Category.Name);
            }).ReverseMap();
            CreateMap<ProductResponseDTO, Product>();
        }
    }
}
