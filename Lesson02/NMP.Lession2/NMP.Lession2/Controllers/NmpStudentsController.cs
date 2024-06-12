using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NMP.Lession2.Controllers
{
    /// <summary>
    ///  Author:Nguyễn Minh Phương
    ///  Class: K22CNTT4
    /// </summary>
    public class NmpStudentsController : Controller
    {
        // GET: NmpStudents
        public ActionResult Index()
        {
            //Truyền dữ liệu từ controller -> View
            ViewBag.fullname = "Nguyễn Minh Phương";
            ViewData["Birthday"] = "11/03/2004";
            TempData["Phone"] = "0348124474";
            return View();
        }
        public ActionResult Details()
        {
            string nmpStr = "";
            nmpStr += "<h3>Họ và Tên:  Nguyễn Minh Phương</h3>";
            nmpStr += "<p>Mã số: 2210900141<p>";
            nmpStr += "<p> Địa chỉ mail: nminhphuong685@gmail.com";

            ViewBag.Details = nmpStr;

            return View("ChiTiet");
        }
        public ActionResult NgonNguRazor()
        {
            string[] names = { "Nguyễn Minh Phương", "Nguyễn Văn A", "Nguyễn Văn B", "Nguyễn Văn C" };
            ViewBag.names = names;
            return View();
        }

        //HtmlHelper
        //get:nmpStudents/addnewstdents
        public ActionResult AddNewStudents()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudents(FormCollection form)
        {
            // Lay du lieu tren form
            string fullName = form["fullName"];
            string MaSV = form["MaSV"];
            string TaiKhoan = form["TaiKhoan"];
            string PassWord = form["PassWord"];

            string nmpStr = "<h3>" + fullName + "</h3>";
            nmpStr += "<p>" + MaSV;
            nmpStr += "<p>" + TaiKhoan;
            nmpStr += "<p>" + PassWord;


            ViewBag.info = nmpStr;
            return View("Ketqua");
        }
    }
}