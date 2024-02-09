using AutoMapper;
using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.AutoMapper
{
    public class AutoMapperUsersProfile : Profile
    {
        public AutoMapperUsersProfile()
        {
            CreateMap<UsersDto, User>().ReverseMap();
        }
    }
}
