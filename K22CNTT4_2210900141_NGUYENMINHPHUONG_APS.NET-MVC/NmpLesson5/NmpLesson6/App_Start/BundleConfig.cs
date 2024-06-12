using System.Web;
using System.Web.Optimization;

<<<<<<<< HEAD:K22CNTT4_2210900141_NGUYENMINHPHUONG_APS.NET-MVC/NmpLesson6/NmpLesson6/App_Start/BundleConfig.cs
namespace NmpLesson6
========
namespace NmpLession03Demo
>>>>>>>> cffbb939d781e940262939abd63d5b80d1ee328e:K22CNTT4_2210900141_NGUYENMINHPHUONG_APS.NET-MVC/Lession02/NmpLession03Demo/NmpLession03Demo/App_Start/BundleConfig.cs
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
