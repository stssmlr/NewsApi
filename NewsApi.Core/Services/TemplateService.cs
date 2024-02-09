using Ardalis.Specification;
using AutoMapper;
using NewsApi.Core.Entities;
using NewsApi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Services
{
    public class TemplateService<T> : ITemplateService<T> where T : class, IEntity
    {
        protected readonly IRepository<T> _repository;
        protected readonly IMapper _mapper;

        public TemplateService(IRepository<T> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
            await _repository.Save();
        }

        public async Task<T> Get(int id)
        {
            return _mapper.Map<T>(await _repository.GetByID(id));
        }

        public async Task Insert(T model)
        {
            await _repository.Insert(_mapper.Map<T>(model));
            await _repository.Save();
        }

        public async Task<List<T>> GetAll()
        {
            return _mapper.Map<List<T>>(await _repository.GetAll());
        }

        public async Task Update(T model)
        {
            await _repository.Update(_mapper.Map<T>(model));
            await _repository.Save();
        }


    }
}
