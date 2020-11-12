using System.Web.Mvc;
using System.Web.Routing;

namespace WebApiService
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.MapRoute("Loginn", "Login/Index", new { controller = "Login", action = "Index" });
            //routes.MapRoute("Searchh", "Home/Search", new { controller = "Home", action = "Search" });
            routes.MapRoute(
              "Default",
              "{controller}/{action}/{id}",
              new { controller = "Home", action = "Index", id = UrlParameter.Optional }
          );
           // routes.AppendTrailingSlash = true;
        }
    }
}
