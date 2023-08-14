using prj05_01.Data;
using prj05_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class WeatherForecastServiceStub : IWeatherForecastService
    {
        public WeatherForecast[] FakeForecast { get; set; } = default!;
        public WeatherForecast[] GetForecast(DateTime startDate)
        {
            return FakeForecast;
        }
    }
}
