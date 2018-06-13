using Ninject;
using PlayNGo.Business;
using PlayNGo.Common.Interfaces.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ninject.Web.Common;
using PlayNGo.Common.Interfaces.Repository;
using PlayNGo.Repository;
using PlayNGo.Data;

namespace PlayNGo
{
    public class MvcApplication : System.Web.HttpApplication
    {





        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }


    }
}
