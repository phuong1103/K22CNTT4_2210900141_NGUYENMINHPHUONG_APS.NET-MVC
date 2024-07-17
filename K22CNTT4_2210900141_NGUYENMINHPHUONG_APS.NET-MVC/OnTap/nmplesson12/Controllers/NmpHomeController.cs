using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nmplesson12.Controllers
{
    public class NmpHomeController : Controller
    {
        public ActionResult NmpIndex()
        {
            return View();
        }

        public ActionResult NmpAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult NmpContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}