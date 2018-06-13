using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlayNGo.Controllers
{
    public class SignalRController : Controller
    {
        // GET: SignalR
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Chat()
        {
            return View();
        }
    }
}