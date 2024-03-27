using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LP.Application.Common.Interfaces.Repositories;
using LP.Application.Common.Interfaces.Services;
using LP.Infrastructure.Persistence.Repositories;
using LP.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LP.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure
            (this IServiceCollection services)
        {
            services.AddScoped<IEducatorRepository, EducatorRepository>();
            services.AddScoped<IEducatorService, EducatorService>();

            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IStudentService, StudentService>();

            services.AddScoped<IHeadOfDRepository, HeadOfDRepository>();
            services.AddScoped<IHeadOfDService, HeadOfDService>();

            return services;
        }
    }
}
