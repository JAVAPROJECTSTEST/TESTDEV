using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPISample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string Welome = "Hi Data";

            return View();
        }
    }
}
