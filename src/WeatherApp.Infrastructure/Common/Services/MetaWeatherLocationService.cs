using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherApp.Domain.Entities;
using WeatherApp.Infrastructure.Common.Adapters;
using WeatherApp.Infrastructure.Common.Interfaces;

namespace WeatherApp.Infrastructure.Common.Services
{
    public class MetaWeatherLocationService : ILocationService
    {
        private readonly MetaWeatherLocationAdapter _adapter;
        private readonly IMetaWeatherApi _weatherApiClient;

        public MetaWeatherLocationService(MetaWeatherLocationAdapter adapter, IMetaWeatherApi weatherApiClient)
        {
            _adapter = adapter;
            _weatherApiClient = weatherApiClient;
        }

        public async Task<IEnumerable<Location>> GetLocationsAsync(string searchText)
        {
            var results = await _weatherApiClient.GetLocations(searchText).ConfigureAwait(false);

            return _adapter.Convert(results);
        }      
    }
}
