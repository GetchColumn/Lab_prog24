using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LP.Infrastructure;
using LP.Presentation.HostedServices;

namespace LP.Presentation
{
    public static class DependencyInjection
    {
        public static async Task StartApplication(string[]? args)
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

            builder.Services.AddInfrastructure();
            builder.Services.AddHostedServiceWorker();
            IHost host = builder.Build();

            await host.RunAsync();
        }
        public static IServiceCollection AddHostedServiceWorker(this IServiceCollection services)
        {
            services.AddHostedService<HostedServiceWorker>();
            return services;
        }
    }
}
