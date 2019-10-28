using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BizQuickTime.Web.Pages.Shared
{
        public static class ManageNavPages
        {
            public static string Index => "Index";

            public static string Customers => "Customers";

            public static string Companies => "Companies";

            public static string Projects => "Projects";

            public static string Subprojects => "SubProjects";
            public static string Activities => "Activities";

        public static string IndexNavClass(ViewContext viewContext) => PageNavClass(viewContext, Index);

            public static string CustomersNavClass(ViewContext viewContext) => PageNavClass(viewContext, Customers);

            public static string CompaniesNavClass(ViewContext viewContext) => PageNavClass(viewContext, Companies);

            public static string ProjectsNavClass(ViewContext viewContext) => PageNavClass(viewContext, Projects);

            public static string SubprojectsNavClass(ViewContext viewContext) => PageNavClass(viewContext, Subprojects);

            public static string ActivitiesNavClass(ViewContext viewContext) => PageNavClass(viewContext, Activities);

        private static string PageNavClass(ViewContext viewContext, string page)
            {
                var activePage = viewContext.ViewData["ActivePage"] as string
                    ?? System.IO.Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);
                return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
            }
        }
    }
