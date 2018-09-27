// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RegisterHttpRoutes.cs" company="Sitecore A/S">
//  Copyright (C) 2015 by Sitecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using Sitecore.Pipelines;

namespace Example.Mvc.Pipelines.Initialize
{
  [ExcludeFromCodeCoverage]
  public class RegisterAll
  {
    public virtual void Process(PipelineArgs args)
    {
      //GlobalConfiguration.Configure(config => FilterConfig.RegisterGlobalFilters(config.Filters));
      //AreaRegistration.RegisterAllAreas();
      GlobalConfiguration.Configure(config => RouteConfig.RegisterRoutes(config.Routes));
      BundleConfig.RegisterBundles(BundleTable.Bundles);
    }
  }
}
