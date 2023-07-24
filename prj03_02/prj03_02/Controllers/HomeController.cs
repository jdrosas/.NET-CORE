using Microsoft.AspNetCore.Mvc;
using prj03_02.Models;
using System.Diagnostics;

namespace prj03_02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            // TODO: store response from guest
            return View();
        }
    }
}