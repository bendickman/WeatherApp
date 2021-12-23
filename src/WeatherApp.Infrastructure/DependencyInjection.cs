using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using WeatherApp.Infrastructure.Common.Adapters;
using WeatherApp.Infrastructure.Common.Interfaces;
using WeatherApp.Infrastructure.Common.Services;

namespace WeatherApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            
            //services
            services.AddScoped<ILocationService, MetaWeatherLocationService>();
            services.AddScoped<IWeatherService, MetaWeatherForecastService>();

            //adapters
            services.AddScoped<MetaWeatherLocationAdapter>();
            services.AddScoped<MetaWeatherForecastAdapter>();

            return services;
        }
    }
}
