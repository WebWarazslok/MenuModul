using DotNetNuke.Web.Mvc.Routing;
using System.Diagnostics;

namespace Company.Modules.MenuModul.Components
{
    public class ModuleInitializer : IMvcRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapRoute(
                moduleFolderName: "MenuModule",
                routeName: "DefaultRoute",
                url: "{controller}/{action}",
                defaults: new { controller = "Api", action = "GetData" },
                namespaces: new[] { "Company.Modules.MenuModul.Controllers" }
            );
        }
    }
}