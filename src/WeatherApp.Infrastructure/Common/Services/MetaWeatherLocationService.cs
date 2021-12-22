using Microsoft.Extensions.Options;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherApp.Domain.Entities;
using WeatherApp.Infrastructure.Common.Adapters;
using WeatherApp.Infrastructure.Common.Interfaces;
using WeatherApp.Infrastructure.Entities;

namespace WeatherApp.Infrastructure.Common.Services
{
    public class MetaWeatherLocationService : ILocationService
    {
        private readonly MetaWeatherLocationAdapter _adapter;
        private readonly IOptions<MetaWeatherApi> _options;

        public MetaWeatherLocationService(IOptions<MetaWeatherApi> options, MetaWeatherLocationAdapter adapter)
        {
            _adapter = adapter;
            _options = options;
        }

        public async Task<IEnumerable<Location>> GetLocations(string searchText)
        {
            var metaWeatherClient = RestService.For<IMetaWeatherApi>(_options.Value.BaseUrl);

            var results = await metaWeatherClient.GetLocations(searchText).ConfigureAwait(false);

            return _adapter.Convert(results);
        }      
    }
}
