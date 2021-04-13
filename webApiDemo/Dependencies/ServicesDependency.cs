using Microsoft.Extensions.DependencyInjection;
using webApiDemo.Domain.Interfaces;
using webApiDemo.Services;

namespace webApiDemo.Dependencies
{
    public static class ServicesDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddTransient<IServiceClub, ServiceClub>();
        }
    }
}
