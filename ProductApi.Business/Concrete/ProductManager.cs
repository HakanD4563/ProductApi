using AutoMapper;
using ProductApi.Business.Abstract;
using ProductApi.DataAccess.Abstract;
using ProductApi.Entity.DTO.ProductDTO;
using ProductApi.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public async Task<ProductResponseDTO> AddAsync(ProductRequestDTO requestEntity)
        {
            var product = _mapper.Map<Product>(requestEntity);
            var addedProduct = await _uow.ProductRepository.AddAsync(product);
            await _uow.SaveChangeAsync();
            ProductResponseDTO productResponseDTO = _mapper.Map<ProductResponseDTO>(addedProduct.Entity);
            return productResponseDTO;
        }

        public async Task DeleteAsync(ProductRequestDTO requestEntity)
        {
            var product = _mapper.Map<Product>(requestEntity);
            await _uow.ProductRepository.DeleteAsync(product);
            await _uow.SaveChangeAsync();
        }

        public async Task<IEnumerable<ProductResponseDTO>> GetAllAsync(ProductRequestDTO requestEntity)
        {
            var product = _mapper.Map<Product>(requestEntity);
            var dbProducts = await _uow.ProductRepository.GetAllAsync(x=>true,"Category");

            List<ProductResponseDTO> productResponseDTOs = new();

            foreach (var dbProduct in dbProducts)
            {
                productResponseDTOs.Add(_mapper.Map<ProductResponseDTO>(dbProduct));
            }
            return productResponseDTOs;
        }

        public async Task<ProductResponseDTO> GetAsync(ProductRequestDTO requestEntity)
        {
            var product = _mapper.Map<Product>(requestEntity);
            var dbProduct =await _uow.ProductRepository.GetAsync(x=>x.Id==product.Id,"Category");

            ProductResponseDTO productResponseDTO = _mapper.Map<ProductResponseDTO>(dbProduct);

            return productResponseDTO;
        }

        public async Task UpdateAsync(ProductRequestDTO requestEntity)
        {
            var product = _mapper.Map<Product>(requestEntity);
            await _uow.ProductRepository.UpdateAsync(product);
            await _uow.SaveChangeAsync();
        }
    }
}
