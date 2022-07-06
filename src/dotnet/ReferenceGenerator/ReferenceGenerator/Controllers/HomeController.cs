using Microsoft.AspNetCore.Mvc;
using ReferenceGenerator.Generators;
using ReferenceGenerator.Models;
using ReferenceGenerator.Parsers;
using System.Diagnostics;

namespace ReferenceGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _hostEnvironment;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment hostEnvironment)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Reference()
        {
            return Redirect("/reference/Index.html");
        }

        [HttpPost]
        public async Task<IActionResult> Generate()
        {
            var parser = new Parser();
            parser.ReadAndParse();
            var generator = new HtmlGenerator();
            await generator.Generate(parser.Reference, _hostEnvironment.WebRootPath);
            //todo: generate here
            return Redirect("/reference/Index.html");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}