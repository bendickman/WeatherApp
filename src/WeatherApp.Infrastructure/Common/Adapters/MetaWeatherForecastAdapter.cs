using System;
using System.Collections.Generic;
using System.Linq;
using WeatherApp.Domain.Entities;
using WeatherApp.Infrastructure.Common.Entities;

namespace WeatherApp.Infrastructure.Common.Adapters
{
    public class MetaWeatherForecastAdapter
    {
        public WeatherForecast Convert(MetaWeather metaWeather)
        {
            if (metaWeather is null || !metaWeather.ConsolidatedWeather.Any()) return GetEmptyObject();

            var result = new WeatherForecast { Name = metaWeather.Title, Created = metaWeather.Time };
            var weatherItems = new List<WeatherItem>();

            foreach (var metaWeatherItem in metaWeather.ConsolidatedWeather)
            {
                var weatherItem = new WeatherItem
                {
                    Temp = metaWeatherItem.TheTemp,
                    MinTemp = metaWeatherItem.MinTemp,
                    MaxTemp = metaWeatherItem.MaxTemp,
                    AirPressure = metaWeatherItem.AirPressure,
                    Humidity = metaWeatherItem.Humidity,
                    Visibility = metaWeatherItem.Visibility,
                    Predictability = metaWeatherItem.Predictability,
                    WindDirection = metaWeatherItem.WindDirection,
                    WindSpeed = metaWeatherItem.WindSpeed,
                    Date = DateTime.Parse(metaWeatherItem.ApplicableDate)
                    
                };

                weatherItems.Add(weatherItem);
            }

            result.WeatherItems = weatherItems;

            return result;

        }

        private WeatherForecast GetEmptyObject()
        {
            return new WeatherForecast
            {
                WeatherItems = new List<WeatherItem>().AsReadOnly()
            };
        }
    }
}
