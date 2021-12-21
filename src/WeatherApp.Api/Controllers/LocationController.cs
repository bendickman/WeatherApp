using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherApp.Application.Locations.Queries;

namespace WeatherApp.Api.Controllers
{
    public class LocationController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<Location>> Get(string searchText)
        {
            return await Mediator.Send(new GetLocationsQuery(searchText));
        }
    }
}
