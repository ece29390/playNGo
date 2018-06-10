using Ninject;
using Ninject.Web.Common.WebHost;
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
    public class MvcApplication : NinjectHttpApplication//System.Web.HttpApplication
    {
        protected MvcApplication()
        {
        }

        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void RegisterServices(IKernel kernel)
        {
            kernel.Bind<DataContext>().ToSelf().InRequestScope();
            kernel.Bind<IPlayerRepository>().To<PlayerRepository>().InRequestScope();
            kernel.Bind<IPlayerBusiness>().To<PlayerBusiness>().InRequestScope();
        }
        //protected void Application_Start()
        //{
        //    AreaRegistration.RegisterAllAreas();
        //    FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        //    RouteConfig.RegisterRoutes(RouteTable.Routes);
        //    BundleConfig.RegisterBundles(BundleTable.Bundles);
        //}

        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            RegisterServices(kernel);
            return kernel;
        }
    }
}
