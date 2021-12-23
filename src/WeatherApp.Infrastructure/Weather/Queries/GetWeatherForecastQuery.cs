using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WeatherApp.Domain.Entities;
using WeatherApp.Infrastructure.Common.Interfaces;

namespace WeatherApp.Infrastructure.Weather.Queries
{
    public class GetWeatherForecastQuery : IRequest<WeatherForecast>
    {
        public int Id { get; }

        public GetWeatherForecastQuery(int id)
        {
            Id = id;
        }
    }

    public class GetWeatherForecastQueryHandler : IRequestHandler<GetWeatherForecastQuery, WeatherForecast>
    {
        private readonly IWeatherService _weatherService;

        public GetWeatherForecastQueryHandler(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public async Task<WeatherForecast> Handle(GetWeatherForecastQuery request, CancellationToken cancellationToken)
        {
            return await _weatherService.GetWeatherForecastAsync(request.Id).ConfigureAwait(false);
        }
    }
}
