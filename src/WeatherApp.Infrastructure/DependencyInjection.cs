using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using WeatherApp.Infrastructure.Common.Interfaces;
using WeatherApp.Infrastructure.Services;

namespace WeatherApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped<ILocationService, MockLocationService>();

            return services;
        }
    }
}
