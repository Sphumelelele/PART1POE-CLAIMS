using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PART1POE_CLAIMS.Models;

namespace PART1POE_CLAIMS.Controllers
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
        public IActionResult Claims()
        {
            return View();
        }
        public IActionResult Cordinator()
        {
            return View();
        }
        public IActionResult AcademyManager()
        {
            return View();
        }
        public IActionResult Status()
        {
            return View();
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
