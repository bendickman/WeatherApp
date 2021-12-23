using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WeatherApp.Domain.Entities;
using WeatherApp.Infrastructure.Weather.Queries;

namespace WeatherApp.Api.Controllers
{
    public class WeatherForecastController : ApiControllerBase
    {
        [HttpGet]
        public async Task<WeatherForecast> Get(int id)
        {
            return await Mediator.Send(new GetWeatherForecastQuery(id)).ConfigureAwait(false);
        }
    }
}
