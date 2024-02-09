using AutoMapper;
using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.AutoMapper
{
    public class AutoMapperRolesProfile : Profile
    {
        public AutoMapperRolesProfile()
        {
            CreateMap<RolesDto, Role>().ReverseMap();
        }
    }
}
