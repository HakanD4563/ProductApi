using ProductApi.Entity.DTO.UserDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Business.Abstract
{
    public interface IUserService:IGenericService<UserResponseDTO,UserRequestDTO>
    {
    }
}
