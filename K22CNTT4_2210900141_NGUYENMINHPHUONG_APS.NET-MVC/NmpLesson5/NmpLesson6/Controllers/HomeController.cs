using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

<<<<<<<< HEAD:K22CNTT4_2210900141_NGUYENMINHPHUONG_APS.NET-MVC/NmpLesson6/NmpLesson6/Controllers/HomeController.cs
namespace NmpLesson6.Controllers
========
namespace NmpLession03Demo.Controllers
>>>>>>>> cffbb939d781e940262939abd63d5b80d1ee328e:K22CNTT4_2210900141_NGUYENMINHPHUONG_APS.NET-MVC/Lession02/NmpLession03Demo/NmpLession03Demo/Controllers/NMPHomeController.cs
{
    public class NMPHomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}