using System;
using System.Collections.Generic;

namespace WeatherApp.Domain.Entities
{
    public class WeatherForecast
    {
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public IEnumerable<WeatherItem> WeatherItems { get; set; }
    }
}
