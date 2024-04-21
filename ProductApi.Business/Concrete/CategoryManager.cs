using ProductApi.Business.Abstract;
using ProductApi.DataAccess.Abstract;
using ProductApi.Entity.DTO.CategoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitOfWork _uow;

        public CategoryManager(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public Task<CategoryResponseDTO> AddAsync(CategoryRequestDTO requestEntity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(CategoryRequestDTO requestEntity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryResponseDTO>> GetAllAsync(CategoryRequestDTO requestEntity)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryResponseDTO> GetAsync(CategoryRequestDTO requestEntity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CategoryRequestDTO requestEntity)
        {
            throw new NotImplementedException();
        }
    }
}
