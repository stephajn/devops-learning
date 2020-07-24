using System.Linq;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class WeatherForecastControllerTests
    {
        WeatherForecastController controller = new WeatherForecastController(null);

        [Fact]
        public void GetReturnsForecasts()
        {
            var result = controller.Get();

            Assert.True(result != null, "The controller should have returned something.");
            Assert.True(result.Any(), "The controller should have some items in the response.");
        }
    }
}
