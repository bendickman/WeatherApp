# WeatherApp

## Development Environment

The project was built using Visual Studio 2019 targeting .NET 5

## Architecture Overview

The architecture approach for this application has taken inspiration from Jason Taylor's [Clean Architecture](https://github.com/jasontaylordev/CleanArchitecture)

### Api

This layer is a Web API targeting .NET Core 5 that provides all the endpoints of the application (details to follow)

### Domain

This layer contains all domain specific entities used throughout the application. Any calls to 3rd party applications are adapted to domain entities to ensure any future maintenance and improvements are quick, simple and require fewer code changes.

### Infrastructure

This layer contains classes for accessing 3rd party applications and all of the 'feature slices' following the MediatR approach. This approach works very well with Web API endpoints and the logic that each need to expose.

The data for this application is obtained via the [MetaWeather API](https://www.metaweather.com/api/)

### UnitTests

This layer contains all of the units tests for the application, which are designed to be run both during development and any deployments (CD/CI)


## API Endpoints

- Get a list of locations based on search text i.e. London

*Http GET* `/api/location?searchText=London`

- Get a 6 day weather forecast for a given location id i.e. 44418 (London)

*HTTP GET* `/api/weatherForecast?id=44418`

The easiest way to test the API is via the Swagger definition located at `/swagger/index.html`

## Technologies

* [.NET 5](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-5.0)
* [MediatR](https://github.com/jbogard/MediatR)
* [Refit](https://github.com/reactiveui/refit)
* [Swagger](https://swagger.io/)
* [Bogus](https://github.com/bchavez/Bogus)
* [NUnit](https://nunit.org/) & [Moq](https://github.com/moq)


