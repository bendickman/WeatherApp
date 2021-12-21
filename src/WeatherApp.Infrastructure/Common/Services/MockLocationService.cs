using System.Collections.Generic;
using WeatherApp.Infrastructure.Common.Interfaces;
using WeatherApp.Domain.Entities;

namespace WeatherApp.Infrastructure.Services
{
    public class MockLocationService : ILocationService
    {
        public IEnumerable<Location> GetLocations(string searchText)
        {
            IEnumerable<Location> vm = new List<Location>()
            {
                new Location { Id = 1, Name = "London"},
                new Location { Id = 2, Name = "Liverpool"},
                new Location { Id = 3, Name = "Poole"},
                new Location { Id = 4, Name = "Warrington"},
                new Location { Id = 5, Name = "Dublin"},
            };

            return vm;
        }
    }
}
