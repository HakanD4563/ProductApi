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
    public class ProductRequestDTOMapper:Profile
    {
        public ProductRequestDTOMapper()
        {
            CreateMap<Product, ProductRequestDTO>();
            CreateMap<ProductRequestDTO, Product>();
        }
    }
}
