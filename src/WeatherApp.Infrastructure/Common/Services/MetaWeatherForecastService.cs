using System.Threading.Tasks;
using WeatherApp.Domain.Entities;
using WeatherApp.Infrastructure.Common.Adapters;
using WeatherApp.Infrastructure.Common.Interfaces;

namespace WeatherApp.Infrastructure.Common.Services
{
    public class MetaWeatherForecastService : IWeatherService
    {
        private readonly IMetaWeatherApi _metaWeatherApi;
        private MetaWeatherForecastAdapter _metaWeatherForecastAdapter;

        public MetaWeatherForecastService(IMetaWeatherApi metaWeatherApi)
        {
            _metaWeatherForecastAdapter = new MetaWeatherForecastAdapter();
            _metaWeatherApi = metaWeatherApi;
        }
        public async Task<WeatherForecast> GetWeatherForecastAsync(int id)
        {
            var result = await _metaWeatherApi.GetWeatherForecast(id).ConfigureAwait(false);

            return _metaWeatherForecastAdapter.Convert(result);
        }
    }
}
