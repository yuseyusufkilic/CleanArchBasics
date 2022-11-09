using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.CommandHandlers;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.Infrastructure.Bus;
using CleanArch.Infrastructure.Data.Context;
using CleanArch.Infrastructure.Data.Repositories;
using MediatR;
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
            services.AddScoped<UniversityDBContext>();

            //Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain handlers
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteCourseCommand, bool>, CourseCommandHandler>();

            
        }
    }
}
