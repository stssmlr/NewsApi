using AutoMapper;
using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using NewsApi.Core.Interface;
using NewsApi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Service
{
    public class RolesService : IRolesService
    {
        private readonly IRepository<Role> _roleRepository;
        private readonly IMapper _mapper;

        public RolesService(IRepository<Role> roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }
        public async Task Delete(int id)
        {

            await _roleRepository.Delete(id);
            await _roleRepository.Save();
        }

        public async Task<RolesDto> Get(int id)
        {
            return _mapper.Map<RolesDto>(await _roleRepository.GetByID(id));
        }

        public async Task Insert(RolesDto model)
        {
            await _roleRepository.Insert(_mapper.Map<Role>(model));
            await _roleRepository.Save();
        }

        public async Task<List<RolesDto>> GetAll()
        {

            return _mapper.Map<List<RolesDto>>(await _roleRepository.GetAll());
        }

        public async Task Update(RolesUpdateDto role)
        {
            await _roleRepository.Update(_mapper.Map<Role>(role));
            await _roleRepository.Save();
        }
    }
}
