using Microsoft.AspNetCore.Html;
using ReferenceGenerator.Models;
using ReferenceGenerator.Settings;
using ReferenceGenerator.Utils;
using System.Text;

namespace ReferenceGenerator.Generators
{
    public class HtmlGenerator
    {
        public async Task Generate(ReferenceModel reference, string path)
        {
            var htmlPath = PathCombiner.Combine(path, "/reference/");
            var dirInfo = new DirectoryInfo(htmlPath);
            
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            var currDir = Directory.GetCurrentDirectory();
            var templatePath = PathCombiner.Combine(currDir, "\\Templates\\Index.html");
            var templateStr = await File.ReadAllTextAsync(templatePath);

            // index
            var indexFileStr = templateStr.Replace(TemplateSettings.TitleTemplate, reference.Name);

            var sb = new StringBuilder();
            sb.AppendLine($"<h1>{reference.Name}</h1>");
            foreach (var item in reference.Types)
            {
                sb.AppendLine($"<div><a href = {item.Name}.html>{item.Name}</a></div>");
            }

            indexFileStr = indexFileStr.Replace(TemplateSettings.ContentTemplate, sb.ToString());
            var dd = PathCombiner.Combine(dirInfo.FullName, "Index.html");
            await File.WriteAllTextAsync(dd, indexFileStr);

            
        }
    }
}
