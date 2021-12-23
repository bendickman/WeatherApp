using System;

namespace WeatherApp.Domain.Entities
{
    public class WeatherItem
    {
        
        public DateTime Date { get; set; }
        
        public double MinTemp { get; set; }
        
        public double MaxTemp { get; set; }
        
        public double Temp { get; set; }
        
        public double WindSpeed { get; set; }

        public double WindDirection { get; set; }
        
        public double AirPressure { get; set; }
        
        public int Humidity { get; set; }
        
        public double Visibility { get; set; }
        
        public int Predictability { get; set; }
    }
}
