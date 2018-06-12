using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using PlayNGo.Data;
using PlayNGo.Common.Interfaces.Repository;
using PlayNGo.Repository;
using PlayNGo.Common.Interfaces.Business;
using PlayNGo.Business;

using Ninject;
using Ninject.Web.Common;

namespace PlayNGo.AngularWeb
{
    public class Global : HttpApplication
    {
       
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}