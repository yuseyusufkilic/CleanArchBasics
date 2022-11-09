using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infrastructure.IOC
{
    //bootstrapper, dependency loader falan diyen de varmış.
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services) // extensions.DI, nugetten geliyo parametre.
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
