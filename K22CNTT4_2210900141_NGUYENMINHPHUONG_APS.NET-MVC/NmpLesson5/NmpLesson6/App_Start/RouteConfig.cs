using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

<<<<<<<< HEAD:K22CNTT4_2210900141_NGUYENMINHPHUONG_APS.NET-MVC/NmpLesson6/NmpLesson6/App_Start/RouteConfig.cs
namespace NmpLesson6
========
namespace NmpLession03Demo
>>>>>>>> cffbb939d781e940262939abd63d5b80d1ee328e:K22CNTT4_2210900141_NGUYENMINHPHUONG_APS.NET-MVC/Lession02/NmpLession03Demo/NmpLession03Demo/App_Start/RouteConfig.cs
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "NMPHome", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
