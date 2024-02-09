using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Interface
{
    public interface IUsersService
    {
        Task Insert(UsersDto model);
        Task<List<UsersDto>> GetAll();
        Task<UsersDto> Get(int id);
        Task Update(UsersUpdateDto user);
        Task Delete(int id);
    }
}

