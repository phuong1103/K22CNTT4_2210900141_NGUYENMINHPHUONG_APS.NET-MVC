using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NMP_Lession03.Controllers
{
    public class NMPStudentsController : Controller
    {
        // GET: NMPStudents
        public ActionResult NmpIndex()
        {
            // dữ liệu từ ViewData
            ViewData["msg"] = "ViewData - Nguyễn Minh Phương";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/yyy tt");

            return View();
        }
        public ActionResult NmpStudentList()
        {
            // sử dụng ViewBag
            //Lưu trữ giá trị đơn
            ViewBag.titleName = "Danh sách học viên - Nguyễn Minh Phương";

            //Giá trị lầ một tập hợp
            string[] names = { "Phương", "Hường", "Tuấn" };
            ViewBag.list = names;
            //Giá trị là một đối tượng
            var obj = new
            {
                ID=100,
                Name= "Minh Phương",
                Age= 20
            };
            ViewBag.student = obj;
            return View();
        }
        public ActionResult NmpAddStudents()
        {
            return View();
        }
    }
}