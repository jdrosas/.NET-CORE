using Microsoft.AspNetCore.Mvc;
using prj04_01.Models;
using System.Diagnostics;

namespace prj04_01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            //ShoppingCart cart = new ShoppingCart { Products = Product.GetProduct() };
            //decimal cartTotal = cart.TotalPrices();

            //return View("Index", new String[] { $"Total: {cartTotal:C2}" });

            //ShoppingCart cart = new ShoppingCart { Products = Product.GetProduct() };
            //Func<Product?, bool> nameFilter = delegate (Product? prod)
            //{
            //    return prod?.Name?[0] == 'S';
            //};

            //decimal priceFilterTotal = cart.FilterByPrice(20).TotalPrices();
            //decimal nameFilterTotal = cart.FilterByName(nameFilter).TotalPrices();

            //return View("Index", new string[] { $"Price Total: {priceFilterTotal:C2}", $"Name Total: {nameFilterTotal:C2}" });

            //var products = new[]
            //{
            //    new {Name = "Kayak", Price = 275M},
            //    new {Name = "Lifejacket", Price = 48.95M},
            //    new {Name = "Soccer ball", Price = 19.50M},
            //    new {Name = "Corner flag", Price = 34.95M}
            //};

            //return View(products.Select(p => p.Name));

            //long? lenght = await MyAsyncMethods.GetPageLength();
            //return View(new string[] { $"Length: {lenght}"});

            Task<long?> tlength = MyAsyncMethods.GetPageLength();
            int i = 1;
            tlength.Wait();

            return View(new string[] { $"Length: {tlength.Result}" });
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