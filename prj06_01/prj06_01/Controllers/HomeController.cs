using Microsoft.AspNetCore.Mvc;
using prj06_01.Models;
using System.Diagnostics;

namespace prj06_01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}