using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Subdivision_Monitoring_System.Models;

namespace Subdivision_Monitoring_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Landing()
        {
            ViewData["HideLayout"] = true;
            return View();
        }
        public IActionResult DashboardLayout()
        {
            return View();
        }
        public IActionResult UserProfile()
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
