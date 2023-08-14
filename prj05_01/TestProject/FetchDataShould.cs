using Microsoft.AspNetCore.Mvc;
using prj05_01.Controllers;
using prj05_01.Data;
using prj05_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions.AspNetCore.Mvc;

namespace TestProject
{
    public class FetchDataShould
    {
        private WeatherForecast[] GetTestWeatherForecast()
        {
            WeatherForecast[] data = new WeatherForecast[3];
            data[0] = new WeatherForecast() { Date = DateTime.Now, TemperatureC = 15, Summary = "Sunny" };
            data[1] = new WeatherForecast() { Date = DateTime.Now.AddDays(1), TemperatureC = 18, Summary = "Cloudy" };
            data[2] = new WeatherForecast() { Date = DateTime.Now.AddDays(2), TemperatureC = 20, Summary = "Hot" };

            return data;
        }

        [Fact]
        public void UseWeatherServicesStub()
        {
            // Arrange
            var stub = new WeatherForecastServiceStub()
            {
                FakeForecast = GetTestWeatherForecast()
            };
            var controller = new HomeController(stub);

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            viewResult.Should().BeViewResult(); // FluentAssertions
            var model = Assert.IsAssignableFrom<WeatherForecast[]>(viewResult.ViewData.Model);
            Assert.Equal(3, model.Count());
        }
    }
}
