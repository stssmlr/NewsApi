using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Interface
{
    public interface IRolesService
    {
        Task Insert(RolesDto model);
        Task<List<RolesDto>> GetAll();
        Task<RolesDto> Get(int id);
        Task Update(RolesUpdateDto role);
        Task Delete(int id);
    }
}
