using ProductApi.Entity.DTO.BaseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Business.Abstract
{
    public interface IGenericService<TResponse,TRequest> where TResponse:BaseResponseDTO where TRequest:BaseRequestDTO 
    {

        public Task<TResponse> AddAsync(TRequest requestEntity);
        public Task UpdateAsync(TRequest requestEntity);
        public Task DeleteAsync(TRequest requestEntity);
        public Task<IEnumerable<TResponse>> GetAllAsync(TRequest requestEntity);
        public Task<TResponse> GetAsync(TRequest requestEntity);

    }
}
