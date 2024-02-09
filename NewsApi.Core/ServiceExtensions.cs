using Microsoft.Extensions.DependencyInjection;
using NewsApi.Core.AutoMapper;
using NewsApi.Core.Entities;
using NewsApi.Core.Interface;
using NewsApi.Core.Interfaces;
using NewsApi.Core.Service;
using NewsApi.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core
{
    public static class ServiceExtensions
    {
        public static void AddCoreServices(this IServiceCollection services)
        {
            services.AddScoped<INewsService, NewsService>();
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IRolesService, RolesService>();
            services.AddScoped(typeof(ITemplateService<News>), typeof(TemplateService<News>));
        }
        public static void AddMapping(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperNewsProfile));
            services.AddAutoMapper(typeof(AutoMapperRolesProfile));
            services.AddAutoMapper(typeof(AutoMapperUsersProfile));
        }
    }
}