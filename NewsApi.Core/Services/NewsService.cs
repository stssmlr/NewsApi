﻿using AutoMapper;
using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using NewsApi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Services
{
    public class NewsService : INewsService
    {
        private readonly IRepository<News> _newsRepository;
        private readonly IMapper _mapper;
        public NewsService(IRepository<News> newsRepository, IMapper mapper)
        {
            _newsRepository = newsRepository;
            _mapper = mapper;
        }

        public async Task<News> Delete(News news)
        {
            News newsDelete = (News)await _newsRepository.GetByID(news.Id);
            await _newsRepository.Delete(news);
            return newsDelete;
        }

        public async Task<News> DeleteById(int id)
        {
            News newsDelete = (News)await _newsRepository.GetByID(id);
            
            await _newsRepository.Delete(id);
            return newsDelete;
        }

        public async Task<NewsDto> Get(int id)
        {
            return _mapper.Map<NewsDto>(await _newsRepository.GetByID(id));
        }

        public async Task<List<NewsDto>> GetAll()
        {
            return _mapper.Map<List<NewsDto>>(await _newsRepository.GetAll());
        }

        public async Task Insert(NewsDto model)
        {
            await _newsRepository.Insert(_mapper.Map<News>(model));
            await _newsRepository.Save();
        }

        public async Task Update(NewsUpdateDto news)
        {
            await _newsRepository.Update(_mapper.Map<News>(news));
            await _newsRepository.Save();
        }
    }
}