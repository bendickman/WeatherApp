using System.Collections.Generic;
using System.Linq;
using WeatherApp.Domain.Entities;
using WeatherApp.Infrastructure.Common.Entities;
using WeatherApp.Infrastructure.Common.Interfaces;

namespace WeatherApp.Infrastructure.Common.Adapters
{
    public class MetaWeatherLocationAdapter : ILocationAdapter<MetaWeatherLocation>
    {
        public IEnumerable<Location> Convert(IEnumerable<MetaWeatherLocation> metaWeatherLocations)
        {
            if (metaWeatherLocations == null || !metaWeatherLocations.Any()) return GetEmptyResult();

            var locations = new List<Location>();

            foreach (var item in metaWeatherLocations)
            {
                var latLngList = item.LattLong?.Split(",");
                double lat = 0, lng = 0;

                if (latLngList != null && latLngList.Length == 2)
                {
                    if (double.TryParse(latLngList[0], out lat))
                    {

                    }

                    if (double.TryParse(latLngList[1], out lng))
                    {

                    }
                }
                var location = new Location
                {
                    Id = item.Woeid,
                    Name = item.Title,
                    Latitude = lat,
                    Longitude = lng
                };

                locations.Add(location);
            }

            return locations;
        }

        private IEnumerable<Location> GetEmptyResult()
        {
            return new List<Location>().AsReadOnly();
        }
    }
}
