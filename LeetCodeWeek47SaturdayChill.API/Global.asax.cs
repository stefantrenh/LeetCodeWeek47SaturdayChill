using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LeetCodeWeek47SaturdayChill.Application.Interfaces;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using LeetCodeWeek47SaturdayChill.Application.MergeWordService;
using Unity.AspNet.Mvc;
using LeetCodeWeek47SaturdayChill.Application.Handlers;
using Unity.Lifetime;

namespace LeetCodeWeek47SaturdayChill.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //DI
            var container = new UnityContainer();
            container.RegisterType<IMergeWordsService, MergeWordsService>();
            container.RegisterType<MergeWordsHandler>(new HierarchicalLifetimeManager()); //AddScope
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


        }
    }
}
