using Microsoft.AspNetCore.Mvc;
using restaurantweb.Models;
using System.Diagnostics;

namespace restaurantweb.Controllers
{
    public class ShopGridController : Controller
    {
        private readonly ILogger<ShopGridController> _logger;

        public ShopGridController(ILogger<ShopGridController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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