using PlayNGo.Common.Interfaces.Business;
using PlayNGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlayNGo.AngularWeb.Controllers
{
    public class HomeController : Controller
    {
       
        // GET: Players
        public ActionResult Index()
        {
            return View();
        }

    }
}