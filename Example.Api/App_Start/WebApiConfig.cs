using System.Web.Http;
using System.Web.Routing;

namespace Example.Api
{
  public static class WebApiConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {

      routes.MapHttpRoute(
        "DefaultApi",
        "api/{controller}/{id}",
        new {id = RouteParameter.Optional}
      );
    }
  }
}
