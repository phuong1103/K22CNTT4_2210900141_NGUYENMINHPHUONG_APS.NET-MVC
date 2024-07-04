using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NmpLesson11Db.Controllers
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
            ViewBag.msv = "2210900141";
            ViewBag.fullname = "Nguyễn Minh Phương";


            return View();
        }
    }
}