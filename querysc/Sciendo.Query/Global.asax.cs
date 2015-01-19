using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.Ajax.Utilities;
using Sciendo.IOC;

namespace Sciendo.Query
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            IocConfig.RegisterComponents(ContainerConfig.Container);
            

        }
    }

    public class ContainerConfig
    {

        public static Container Container
        {
            get
            {
                if(!HttpContext.Current.Application.AllKeys.Contains("ioc"))
                    HttpContext.Current.Application.Add("ioc",Container.GetInstance());
                return HttpContext.Current.Application["ioc"] as Container;
            }
        }
    }
}