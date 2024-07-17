using NmpOnTap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NmpOnTap.Controllers
{
    public class NmpHomeController : Controller
    {
        public ActionResult NmpIndex()
        {
            //Kiểm tra dữ liệu trong session
            if (Session["NmpAccount"] !=null)
            {
                var nmp_Account = Session["NmpAccount"] as Nmp_Account; 
                ViewBag.FullName = nmp_Account.Nmp_FullName;
               
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
            ViewBag.Message = "Thông tin hỗ trợ";
            ViewBag.Masv = "2210900141";

            return View();
        }
    }
}