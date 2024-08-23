using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ObiletProject.Api;
using ObiletProject.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiletProject.Extension.DependecyExtension
{
    public static class BaseDependecyInjection
    {
        public static IServiceCollection RegisterBaseDependencyInjection(this IServiceCollection services)
        {
             
            services.AddScoped<IObiletApi, ObiletApi>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            return services;
        }
    }
}
