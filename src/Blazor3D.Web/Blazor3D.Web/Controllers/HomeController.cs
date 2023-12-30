using Blazor3D.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Blazor3D.Web.Controllers
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
            ViewData["Title"] = "Blazor3D";
            return View();
        }

        public IActionResult Tutorials()
        {
            ViewData["Title"] = "Blazor3D Tutorials";
            return View();
        }

        public IActionResult GettingStarted()
        {
            ViewData["Title"] = "Blazor3D Getting Started tutorial";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Title"] = "Privacy";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}