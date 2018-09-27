// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RegisterHttpRoutes.cs" company="Sitecore A/S">
//  Copyright (C) 2015 by Sitecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Sitecore.Pipelines;

namespace Example.Mvc.Pipelines.Initialize
{
  [ExcludeFromCodeCoverage]
  public class RegisterAll
  {
    public virtual void Process(PipelineArgs args)
    {
      AreaRegistration.RegisterAllAreas();
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);
    }
  }
}
