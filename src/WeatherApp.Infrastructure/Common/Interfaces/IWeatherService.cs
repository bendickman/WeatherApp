using System.Threading.Tasks;
using WeatherApp.Domain.Entities;

namespace WeatherApp.Infrastructure.Common.Interfaces
{
    public interface IWeatherService
    {
        public Task<WeatherForecast> GetWeatherForecastAsync(int id);
    }
}
