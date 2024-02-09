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
    public class UsersService : IUsersService
    {
        private readonly IRepository<User> _usersRepository;
        private readonly IMapper _mapper;

        public UsersService(IRepository<User> newsRepository, IMapper mapper)
        {
            _usersRepository = newsRepository;
            _mapper = mapper;
        }
        public async Task Delete(int id)
        {
            await _usersRepository.Delete(id);
            await _usersRepository.Save();
        }

        public async Task<UsersDto> Get(int id)
        {
            return _mapper.Map<UsersDto>(await _usersRepository.GetByID(id));
        }

        public async Task Insert(UsersDto model)
        {
            await _usersRepository.Insert(_mapper.Map<User>(model));
            await _usersRepository.Save();
        }

        public async Task<List<UsersDto>> GetAll()
        {
            return _mapper.Map<List<UsersDto>>(await _usersRepository.GetAll());
        }

        public async Task Update(UsersUpdateDto user)
        {
            await _usersRepository.Update(_mapper.Map<User>(user));
            await _usersRepository.Save();
        }
    }
}
