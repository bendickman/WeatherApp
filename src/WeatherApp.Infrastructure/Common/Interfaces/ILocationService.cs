using System.Collections.Generic;
using WeatherApp.Domain.Entities;

namespace WeatherApp.Infrastructure.Common.Interfaces
{
    public interface ILocationService
    {
        IEnumerable<Location> GetLocations(string searchText);
    }
}
