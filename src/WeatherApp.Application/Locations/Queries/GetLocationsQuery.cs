using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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
        public Task<IEnumerable<Location>> Handle(GetLocationsQuery request, CancellationToken cancellationToken)
        {

            IEnumerable<Location> vm = new List<Location>()
            {
                new Location { Id = 1, Name = "London"},
                new Location { Id = 2, Name = "Liverpool"},
                new Location { Id = 3, Name = "Poole"},
                new Location { Id = 4, Name = "Warrington"},
                new Location { Id = 5, Name = "Dublin"},
            };

            return Task.FromResult(vm);
        }
    }
}
