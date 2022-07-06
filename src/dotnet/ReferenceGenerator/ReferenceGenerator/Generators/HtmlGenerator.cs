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


            var referencePath = PathCombiner.Combine(path, "/reference/");
            var referenceDirInfo = new DirectoryInfo(referencePath);

            if (!referenceDirInfo.Exists)
            {
                referenceDirInfo.Create();
            }

            var currDir = Directory.GetCurrentDirectory();
            var templatePath = PathCombiner.Combine(currDir, "\\Templates\\Index.html");
            string templateStr = await File.ReadAllTextAsync(templatePath);

            // index
            var indexFileStr = templateStr.Replace(TemplateSettings.TitleTemplate, reference.Name);
            indexFileStr = indexFileStr.Replace(TemplateSettings.HeaderTemplate, reference.Name);
            indexFileStr = indexFileStr.Replace(TemplateSettings.NameSpaceTemplate, string.Empty);

            var navSb = new StringBuilder();

            foreach (TypeModel item in reference.Types)
            {
                navSb.AppendLine($"<div><a href = {item.Name}.html>{item.Name}</a></div>");
            }

            var nav = navSb.ToString();
            var contentSb = new StringBuilder();


            indexFileStr = indexFileStr.Replace(TemplateSettings.NavTemplate, nav);
            indexFileStr = indexFileStr.Replace(TemplateSettings.ContentTemplate, contentSb.ToString());
            var referenceIndex = PathCombiner.Combine(referenceDirInfo.FullName, "Index.html");
            await File.WriteAllTextAsync(referenceIndex, indexFileStr);

            //copy css
            var templatePathCss = PathCombiner.Combine(currDir, "\\Templates\\reference.css");
            var referenceCss = PathCombiner.Combine(referenceDirInfo.FullName, "reference.css");
            File.Copy(templatePathCss, referenceCss, true);

            foreach (TypeModel item in reference.Types)
            {
                await CreateHtmlFromType(item, templateStr, referenceDirInfo.FullName, nav, reference.Name);
            }

        }

        private async Task CreateHtmlFromType(TypeModel typeModel, string templateStr, string path, string nav, string refName)
        {
            var title = $"{typeModel.Name} - {refName}";

            var fileStr = templateStr.Replace(TemplateSettings.TitleTemplate, title);
            fileStr = fileStr.Replace(TemplateSettings.NavTemplate, nav);
            fileStr = fileStr.Replace(TemplateSettings.HeaderTemplate, $"{typeModel.ShortName}");
            fileStr = fileStr.Replace(TemplateSettings.NameSpaceTemplate, $"NameSpace: <strong>{typeModel.NameSpace}</strong>");

            var contentSB = new StringBuilder();

            if (typeModel.Constructors.Any())
            {
                contentSB.AppendLine($"<h3>Constructors</h3>");
                foreach (var constructor in typeModel.Constructors)
                {
                    contentSB.AppendLine($"<strong>{constructor.Name}:</strong> {constructor.Summary} </br>");
                }
            }

            if (typeModel.Properties.Any())
            {
                contentSB.AppendLine($"<h3>Properties</h3>");
                foreach (var prop in typeModel.Properties)
                {
                    contentSB.AppendLine($"<strong>{prop.ShortName}:</strong> {prop.Summary} </br>");
                }
            }

            if (typeModel.Methods.Any())
            {
                contentSB.AppendLine($"<h3>Methods</h3>");
                foreach (var method in typeModel.Methods)
                {
                    contentSB.AppendLine($"<strong>{method.Name}:</strong> {method.Summary} </br>");
                }
            }

            if (typeModel.Fields.Any())
            {
                contentSB.AppendLine($"<h3>Fields</h3>");
                foreach (var field in typeModel.Fields)
                {
                    contentSB.AppendLine($"<strong>{field.ShortName}:</strong> {field.Summary} </br>");
                }
            }

            fileStr = fileStr.Replace(TemplateSettings.ContentTemplate, contentSB.ToString());



            var fileHtml = PathCombiner.Combine(path, $"{typeModel.Name}.html");
            await File.WriteAllTextAsync(fileHtml, fileStr);
        }
    }
}
