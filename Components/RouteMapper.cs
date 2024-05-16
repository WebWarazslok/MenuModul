using DotNetNuke.Web.Api;
using System.Diagnostics;

namespace Company.Modules.MenuModul
{
    public class RouteMapper : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute(
                moduleFolderName: "MVC/MenuModul",
                routeName: "default",
                url: "{controller}/{action}",
                namespaces: new[] { "Company.Modules.MenuModul.Controllers.Api" }
            );
        }
    }
}