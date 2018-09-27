using System.Web.Http;

namespace Example.Api
{
  public static class WebApiConfig
  {

    public static void Register(HttpConfiguration config)
    {
      //config.MapHttpAttributeRoutes();
      RegisterRoutes(config.Routes);
    }

    private static void RegisterRoutes(HttpRouteCollection routes)
    {
      routes.MapHttpRoute(
        "DefaultApi",
        "api/{controller}/{id}",
        new {id = RouteParameter.Optional, action = "Get" }
      );
    }
  }
}
