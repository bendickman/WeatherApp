# WeatherApp

## Development Environment

The project was built using Visual Studio 2019 targeting .NET 5

## Architecture Overview

### Api

This layer is a Web API targeting .NET Core 5 that provides all the endpoints of the application (details to follow)

### Domain

This layer contains all domain specific entities used throughout the application. Any calls to 3rd party applications are adapted to domain entities to ensure any future maintenance and improvements are quick, simple and require fewer code changes.

### Infrastructure

This layer contains classes for accessing 3rd party applications and all of the 'feature slices' following the MediatR approach. This approach works very well with Web API endpoints and the logic that each need to expose.

The data for this application is obtained via the [MetaWeather API](https://www.metaweather.com/api/)

### UnitTests

This layer contains all of the units tests for the application, which are designed to be run both during development and any deployments (CD/CI)

### API Endpoints

