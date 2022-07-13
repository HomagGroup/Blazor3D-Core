using ReferenceGenerator.Extensions;
using ReferenceGenerator.Models;
using ReferenceGenerator.Settings;
using ReferenceGenerator.Utils;
using System.Text;

namespace ReferenceGenerator
{
    public class HtmlGenerator
    {
        public async Task Generate(ReferenceModel reference, string refpath, string templatePath)
        {
            var referenceDirInfo = new DirectoryInfo(refpath);

            if (referenceDirInfo.Exists)
            {
                referenceDirInfo.Delete(true);
            }
            referenceDirInfo.Create();

            string templateStr = await File.ReadAllTextAsync(templatePath);

            var nav = ProcessNavigationMenu(reference.Types);

            //index.html
            var indexFileStr = ProcessIndexFile(reference, templateStr, nav);

            var referenceIndex = PathCombiner.Combine(referenceDirInfo.FullName, "Index.html");

            await File.WriteAllTextAsync(referenceIndex, indexFileStr);

            foreach (TypeModel item in reference.Types)
            {
                await CreateHtmlFromType(item, templateStr, referenceDirInfo.FullName, nav, reference.Name);
            }
        }

        private string ProcessIndexFile(ReferenceModel reference, string templateStr, string nav)
        {
            var indexFileStr = templateStr.Replace(TemplateSettings.TitleTemplate, reference.Name);
            indexFileStr = indexFileStr.Replace(TemplateSettings.HeaderTemplate, string.Empty);
            indexFileStr = indexFileStr.Replace(TemplateSettings.NameSpaceTemplate, string.Empty);
            indexFileStr = indexFileStr.Replace(TemplateSettings.ContentTemplate, "Index content goes here");
            indexFileStr = indexFileStr.Replace(TemplateSettings.BreadcrumbsTemplate, BreadCrumbsFactory.GetIndexBreadcrumbs());
            indexFileStr = indexFileStr.Replace(TemplateSettings.NavTemplate, nav);
            return indexFileStr;
        }

        private string ProcessNavigationMenu(List<TypeModel> types)
        {
            var navSb = new StringBuilder();
            var groupedList = types.GroupBy(x => x.NameSpace).OrderBy(x => x.Key).ToList();
            foreach (var group in groupedList)
            {
                
                var idx = group.Key.LastIndexOf('.');
                navSb.AppendLine($"<h4 class=\"fontlight\">{group.Key[(idx + 1)..]}</h3>");
                navSb.AppendLine($"<ul class=\"nav flex-column referenceNav\">");
                foreach (var item in group)
                {
                    navSb.AppendLine($"<li class=\"nav-item\"><a class=\"nav-link refNavLink\" href = {item.Name}.html>{item.ShortName}</a></li>");
                }
                navSb.AppendLine($"</ul>");
            }
            return navSb.ToString();
        }

        private async Task CreateHtmlFromType(TypeModel typeModel, string templateStr, string path, string nav, string refName)
        {
            var title = $"{refName}: {typeModel.ShortName}";
            var header = string.IsNullOrEmpty(typeModel.Inherit) ? typeModel.ShortName : $"{typeModel.ShortName} : {typeModel.Inherit}";

            var fileStr = templateStr.Replace(TemplateSettings.TitleTemplate, title);
            fileStr = fileStr.Replace(TemplateSettings.NavTemplate, nav);
            fileStr = fileStr.Replace(TemplateSettings.HeaderTemplate, header);
            fileStr = fileStr.Replace(TemplateSettings.NameSpaceTemplate, $"NameSpace: <strong>{typeModel.NameSpace}</strong>");
            fileStr = fileStr.Replace(TemplateSettings.BreadcrumbsTemplate, BreadCrumbsFactory.GetTypeBreadcrumbs(typeModel));

            var contentSB = new StringBuilder();
            contentSB.AppendLine($"{typeModel.Summary.ParseSummary()}");
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
                    contentSB.AppendLine($"<h3 class=\"fontlight\">Constructors</h3>");
                    break;
                case "Method":
                    contentSB.AppendLine($"<h3 class=\"fontlight\">Methods</h3>");
                    break;
                case "Property":
                    contentSB.AppendLine($"<h3 class=\"fontlight\">Properties</h3>");
                    break;
                case "Field":
                    contentSB.AppendLine($"<h3 class=\"fontlight\">Fields</h3>");
                    break;
                default:
                    break;
            }

            contentSB.AppendLine($"<table class=\"table table-bordered\">");

            foreach (var item in list)
            {
                contentSB.AppendLine($"<tr>");
                // name column
                contentSB.AppendLine($"<td>");
                contentSB.AppendLine($"<strong>{item.ShortName}</strong>");
                contentSB.AppendLine($"</td>");
                // third column
                contentSB.AppendLine($"<td>");
                contentSB.AppendLine($"<div>{item.Summary}</div>");

                if (type == "Method" || type == "Constructor")
                {
                    var returnValue = (item as MethodModel)?.ReturnValue ?? string.Empty;
                    if (!string.IsNullOrEmpty(returnValue))
                    {
                        contentSB.AppendLine($"<div><p><strong>Returns:</strong> {returnValue}</p></div>");
                    }
                    var paramsList = (item as MethodModel)?.Params ?? new List<BaseModel>();
                    if (paramsList.Any())
                    {
                        var pSb = new StringBuilder();
                        CreatePropertiesTable(paramsList, pSb);
                        contentSB.AppendLine($"<h5 class=\"fontlight\">Parameters</h5>");
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
