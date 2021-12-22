using System.Text.Json.Serialization;

namespace WeatherApp.Infrastructure.Common.Entities
{
    public class MetaWeatherLocation
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("location_type")]
        public string LocationType { get; set; }

        [JsonPropertyName("woeid")]
        public int Woeid { get; set; }

        [JsonPropertyName("latt_long")]
        public string LattLong { get; set; }
    }
}
