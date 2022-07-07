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

            if (referenceDirInfo.Exists)
            {
                referenceDirInfo.Delete(true);
            }
            referenceDirInfo.Create();


            var currDir = Directory.GetCurrentDirectory();
            var templatePath = PathCombiner.Combine(currDir, "\\Templates\\Index.html");
            string templateStr = await File.ReadAllTextAsync(templatePath);

            // index
            var indexFileStr = templateStr.Replace(TemplateSettings.TitleTemplate, reference.Name);
            indexFileStr = indexFileStr.Replace(TemplateSettings.HeaderTemplate, reference.Name);
            indexFileStr = indexFileStr.Replace(TemplateSettings.NameSpaceTemplate, string.Empty);
            indexFileStr = indexFileStr.Replace(TemplateSettings.BreadcrumbsTemplate, "<span class=\"breadcrumbs\">Home</span>");

            var navSb = new StringBuilder();

            var groupedList = reference.Types.GroupBy(x => x.NameSpace).OrderBy(x => x.Key).ToList();
            foreach (var group in groupedList)
            {
                var idx = group.Key.LastIndexOf('.');
                navSb.AppendLine($"<h3>{group.Key[(idx + 1)..]}</h3>");
                navSb.AppendLine($"<ul class=\"navli\">");
                foreach (var item in group)
                {
                    navSb.AppendLine($"<li><a href = {item.Name}.html>{item.ShortName}</a></li>");
                }
                navSb.AppendLine($"</ul>");
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
            var title = $"{refName}: {typeModel.ShortName}";

            var fileStr = templateStr.Replace(TemplateSettings.TitleTemplate, title);
            fileStr = fileStr.Replace(TemplateSettings.NavTemplate, nav);
            fileStr = fileStr.Replace(TemplateSettings.HeaderTemplate, $"{typeModel.ShortName}");
            fileStr = fileStr.Replace(TemplateSettings.NameSpaceTemplate, $"<span class=\"breadcrumbs\">NameSpace: <strong>{typeModel.NameSpace}</strong></span");
            fileStr = fileStr.Replace(TemplateSettings.BreadcrumbsTemplate, $"<a href=\"/reference/Index.html\"><span class=\"breadcrumbs\">Home</span></a> - {typeModel.ShortName}");

            var contentSB = new StringBuilder();

            CreatePropertiesTable(typeModel.Constructors, contentSB);
            CreatePropertiesTable(typeModel.Methods, contentSB);
            CreatePropertiesTable(typeModel.Properties, contentSB);
            CreatePropertiesTable(typeModel.Fields, contentSB);

            fileStr = fileStr.Replace(TemplateSettings.ContentTemplate, contentSB.ToString());

            var fileHtml = PathCombiner.Combine(path, $"{typeModel.Name}.html");
            await File.WriteAllTextAsync(fileHtml, fileStr);
        }

        private void CreatePropertiesTable(List<BaseModel> list, StringBuilder contentSB)
        {
            if (!list.Any())
                return;
            var type = list.First().Type;

            switch (type)
            {
                case "Constructor":
                    contentSB.AppendLine($"<h2>Constructors</h2>");
                    break;
                case "Method":
                    contentSB.AppendLine($"<h2>Methods</h2>");
                    break;
                case "Property":
                    contentSB.AppendLine($"<h2>Properties</h2>");
                    break;
                case "Field":
                    contentSB.AppendLine($"<h2>Fields</h2>");
                    break;
                default:
                    break;
            }

            contentSB.AppendLine($"<table>");

            foreach (var item in list)
            {
                contentSB.AppendLine($"<tr>");
                contentSB.AppendLine($"<td>");
                contentSB.AppendLine($"<strong>{item.ShortName}</strong>");

                contentSB.AppendLine($"</td>");
                contentSB.AppendLine($"<td>");
                contentSB.AppendLine($"<div>{item.Summary}</div>");

                if (type == "Method" || type == "Constructor")
                {
                    var paramsList = (item as MethodModel)?.Params ?? new List<BaseModel>();
                    if (paramsList.Any())
                    {
                        var pSb = new StringBuilder();
                        CreatePropertiesTable(paramsList, pSb);
                        contentSB.AppendLine($"<h3>Parameters</h3>");
                        contentSB.AppendLine($"<div>{pSb.ToString()}</div>");
                    }
                }

                contentSB.AppendLine($"</td>");

                contentSB.AppendLine($"</tr>");
            }
            contentSB.AppendLine($"</table>");

        }

    }
}
