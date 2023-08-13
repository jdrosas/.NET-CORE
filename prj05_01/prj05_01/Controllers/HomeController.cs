using Microsoft.AspNetCore.Mvc;
using prj05_01.Data;
using prj05_01.Models;
using System.Diagnostics;

namespace prj05_01.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherForecastService _weatherForecastService;

        public HomeController(IWeatherForecastService forecastService)
        {
            _weatherForecastService = forecastService; 
        }

        public IActionResult Index()
        {
            var forecasts = _weatherForecastService.GetForecast(DateTime.Now);

            return View(forecasts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}