using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReferenceGenerator;
using ReferenceGenerator.Models;
using ReferenceGenerator.Utils;

namespace Blazor3D.Web.Controllers
{
    public class ReferenceController : Controller
    {
        private readonly IWebHostEnvironment _hostEnvironment;
        public ReferenceController(IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }
        
        // POST: ReferenceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Generate(IFormCollection collection)
        {
            try
            {
                var parser = new Parser();
                parser.ReadAndParse();

                var generator = new HtmlGenerator();
                var refPath = PathCombiner.Combine(_hostEnvironment.WebRootPath, "/reference/");
                var templatePath = PathCombiner.Combine(Directory.GetCurrentDirectory(), "\\Templates\\Index.html");
                await generator.Generate(parser.Reference, refPath, templatePath);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
    }
}
