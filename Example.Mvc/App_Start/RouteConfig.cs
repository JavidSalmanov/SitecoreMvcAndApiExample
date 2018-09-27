using System.Web.Mvc;
using System.Web.Routing;

namespace Example.Mvc
{
  public class RouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

      routes.MapRoute(
        "Default",
        "mvc/{controller}/{action}/{id}",
        new {controller = "Home", action = "Index", id = UrlParameter.Optional}
      );
    }
  }
}