using System.Web.Http;
using System.Web.Mvc;

namespace Example.Mvc
{
  public class RouteConfig
  {
    public static void RegisterRoutes(HttpRouteCollection routes)
    {
      routes.MapHttpRoute(
        "DefaultMvc",
        "mvc/{controller}/{action}/{id}",
        new {controller = "Home", action = "Index", id = UrlParameter.Optional}
      );
    }
  }
}