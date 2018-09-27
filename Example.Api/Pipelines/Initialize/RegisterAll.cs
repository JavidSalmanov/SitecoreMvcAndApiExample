using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using System.Web.Routing;
using Sitecore.Pipelines;

namespace Example.Api.Pipelines.Initialize
{
  [ExcludeFromCodeCoverage]
  public class RegisterAll
  {
    public virtual void Process(PipelineArgs args)
    {
      GlobalConfiguration.Configure(WebApiConfig.Register);
    }
  }
}
