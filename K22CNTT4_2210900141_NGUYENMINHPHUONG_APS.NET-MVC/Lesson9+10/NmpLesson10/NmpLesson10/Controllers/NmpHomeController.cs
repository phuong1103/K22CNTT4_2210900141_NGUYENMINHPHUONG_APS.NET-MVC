using NmpLesson10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NmpLesson10.Controllers
{
    public class NmpHomeController : Controller
    {
        public ActionResult NmpIndex()
           
        {
            //Kiểm tra dữ liệu trong session
            if (Session["NmpAccounts"]!=null)
            {
                var nmpAccount = Session["NmpAcounts"] as NmpAccount;
                ViewBag.FullName = nmpAccount.NmpFullName;
            }    
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