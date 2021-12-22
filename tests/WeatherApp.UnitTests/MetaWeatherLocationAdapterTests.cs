using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using WeatherApp.Infrastructure.Common.Adapters;
using WeatherApp.Infrastructure.Common.Entities;

namespace WeatherApp.UnitTests
{
    public class MetaWeatherLocationAdapterTests
    {
        private MetaWeatherLocationAdapter _sut;

        [SetUp]
        public void Init()
        {
            _sut = new MetaWeatherLocationAdapter();
        }

        [Test]
        public void Convert_Returns_Empty_Collection_When_MetaWeather_Response_Is_Empty()
        {
            //Arrange
            var metaWeatherResponse = new List<MetaWeatherLocation>();

            //Act
            var locations = _sut.Convert(metaWeatherResponse);

            //Assert
            Assert.IsFalse(locations.Any(), "Location collection is not empty");
        }

        [Test]
        public void Convert_Returns_Empty_Collection_When_MetaWeather_Response_Is_Null()
        {
            //Act
            var locations = _sut.Convert(null);

            //Assert
            Assert.IsFalse(locations.Any(), "Location collection is not empty");
        }
    }
}
