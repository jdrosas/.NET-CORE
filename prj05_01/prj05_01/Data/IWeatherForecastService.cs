using prj05_01.Models;

namespace prj05_01.Data
{
    public interface IWeatherForecastService
    {
        WeatherForecast[] GetForecast(DateTime startDate);
    }
}
