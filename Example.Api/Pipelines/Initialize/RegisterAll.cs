// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RegisterHttpRoutes.cs" company="Sitecore A/S">
//  Copyright (C) 2015 by Sitecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;
using System.Web.Routing;
using Sitecore.Pipelines;

namespace Example.Api.Pipelines.Initialize
{
  [ExcludeFromCodeCoverage]
  public class RegisterAll
  {
    public virtual void Process(PipelineArgs args)
    {
      WebApiConfig.RegisterRoutes(RouteTable.Routes);
    }
  }
}
