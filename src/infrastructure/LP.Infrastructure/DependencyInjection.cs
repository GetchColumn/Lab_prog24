using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LP.Application.Common.Interfaces.Repositories;
using LP.Application.Common.Interfaces.Services;

namespace LP.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure
            (this IServiceCollection services)
        {
            services.AddScoped<IEducatorRepository, EducatorRepository>();
            services.AddScoped<IEducatorService, EducatorRepository>();

            return services;
        }
    }
}
