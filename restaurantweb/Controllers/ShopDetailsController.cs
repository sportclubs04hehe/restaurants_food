using Microsoft.AspNetCore.Mvc;
using restaurantweb.Models;
using System.Diagnostics;

namespace restaurantweb.Controllers
{
    public class ShopDetailsController : Controller
    {
        private readonly ILogger<ShopDetailsController> _logger;

        public ShopDetailsController(ILogger<ShopDetailsController> logger)
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