using System;
using Xunit;
using SimpleAPI.Controllers;
namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();



        [Fact]
        public void TestGet()
        {
          var result =  controller.Get();
            Assert.Equal("This is from get", result.Value);

        }
        [Fact]
        public void TestGetById()
        {
            var result = controller.Get(1);
            Assert.Equal("This is from get by id", result.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
