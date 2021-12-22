using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherApp.Domain.Entities;

namespace WeatherApp.Infrastructure.Common.Interfaces
{
    public interface ILocationService
    {
        Task<IEnumerable<Location>> GetLocations(string searchText);
    }
}
