using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WeatherApp.Infrastructure.Common.Interfaces;
using WeatherApp.Domain.Entities;

namespace WeatherApp.Application.Locations.Queries
{
    public class GetLocationsQuery : IRequest<IEnumerable<Location>>
    {
        public GetLocationsQuery(string searchText)
        {
            SearchText = searchText;
        }
        public string SearchText { get; set; }
    }

    public class GetLocationsQueryHandler : IRequestHandler<GetLocationsQuery, IEnumerable<Location>>
    {
        private readonly ILocationService _locationService;

        public GetLocationsQueryHandler(ILocationService locationService)
        {
            _locationService = locationService;
        }

        public Task<IEnumerable<Location>> Handle(GetLocationsQuery request, CancellationToken cancellationToken)
        {
            var vm = _locationService.GetLocations(request.SearchText);            

            return Task.FromResult(vm);
        }
    }
}
