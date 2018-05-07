using RestApiWrapper.Endpoints;
using System.Threading.Tasks;
using Xunit;

namespace RestApiWrapper.Tests
{
    /// <summary>
    /// MetaWeather tests
    /// </summary>
    public class MetaWeatherApiTests
    {
        [Fact]
        public async Task QueryByLocationTest()
        {
            //Act
            var responseMessage = await RestApiWrapper.Get<IMetaWeatherApi>(s => s.QueryByLocation("862592"));

            //Assert
            Assert.True(responseMessage.IsSuccessStatusCode);
        }

        [Fact]
        public async Task QueryByInvalidLocationTest()
        {
            //Act
            var responseMessage = await RestApiWrapper.Get<IMetaWeatherApi>(s => s.QueryByLocation("invalid"));

            //Assert
            Assert.False(responseMessage.IsSuccessStatusCode);
        }
    }
}
