
using ReferenceGenerator.Models;

namespace ReferenceGenerator.Utils
{
    internal static class BreadCrumbsFactory
    {
        internal static string GetIndexBreadcrumbs()
        {
            return "<li class=\"breadcrumb-item active\" aria-current=\"page\">Reference Guide</li>";
        }

        internal static string GetTypeBreadcrumbs(TypeModel type)
        {
            var bc = "<li class=\"breadcrumb-item active\"><a href=\"/reference/Index.html\">Reference Guide</a></li>" +
                $"<li class=\"breadcrumb-item\" aria-current=\"page\">{type.ShortName}</li>";
            return bc;
        }
    }
}
