using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherApp.Infrastructure.Common.Entities;

namespace WeatherApp.Infrastructure.Common.Interfaces
{
    public interface IMetaWeatherApi
    {
        [Get("/location/search/?query={searchText}")]
        Task<IEnumerable<MetaWeatherLocation>> GetLocations(string searchText);
    }
}
