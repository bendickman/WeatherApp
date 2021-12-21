using System.Collections.Generic;
using WeatherApp.Infrastructure.Common.Interfaces;
using WeatherApp.Domain.Entities;
using Bogus;

namespace WeatherApp.Infrastructure.Services
{
    public class MockLocationService : ILocationService
    {
        public IEnumerable<Location> GetLocations(string searchText)
        {
            return GenerateLocations(50);
        }

        private IEnumerable<Location> GenerateLocations(int count)
        {
            var mockData = new Faker<Location>()
                .RuleFor(l => l.Id, f => f.Random.Int(0, 1000))
                .RuleFor(l => l.Name, f => f.Random.Word())
                .RuleFor(l => l.Latitude, f => f.Address.Latitude())
                .RuleFor(l => l.Longitude, f => f.Address.Longitude());

            return mockData.Generate(count);

        }
    }
}
