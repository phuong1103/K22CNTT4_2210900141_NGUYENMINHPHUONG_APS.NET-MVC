using NMP_Lession04Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NMP_Lession04Demo.Controllers
{
    public class NMPCustomerController : Controller
    {
        // GET: NMPCustomer
        public ActionResult Index()
        {
            return View();
        }
        // Action: NMPCustomerDetail
        public ActionResult NMPCustomerDetail()
        {
            // Tạo đối tượng dữ liệu
            var customer = new NMPCustomer()
            {
                CustomerId = 1,
                FirstName = "Nguyễn Minh ",
                LastName = "Phương",
                Address = "K22CNTT4",
                YearOfBirth = "2004"
            };
            ViewBag.customer = customer;
            return View();
        }

        // GET : NMPListCustomer
        public ActionResult NMPListCustomer()
        {
            var list = new List<NMPCustomer>()
            {
                new NMPCustomer()
                {
                CustomerId = 1,
                FirstName = "Nguyễn Minh ",
                LastName = "Phương",
                Address = "K22CNTT4",
                YearOfBirth = "2004"
                },

                new NMPCustomer()
                {
                CustomerId = 2,
                FirstName = "Đàm Thuý ",
                LastName = "Hường",
                Address = "K22CNTT4",
                YearOfBirth = "2004"
                },

                new NMPCustomer()
                {
                CustomerId = 3,
                FirstName = "Vũ Văn ",
                LastName = "Tuấn",
                Address = "K22CNTT4",
                YearOfBirth = "2004"
                },


                new NMPCustomer()
                {
                CustomerId = 4,
                FirstName = "Nguyễn Thuỳ ",
                LastName = "Dương",
                Address = "K22CNTT4",
                YearOfBirth = "2004"
                },

                new NMPCustomer()
                {
                CustomerId = 5,
                FirstName = "Nguyễn Minh ",
                LastName = "Phương",
                Address = "K22CNTT4",
                YearOfBirth = "2004"
                },
            };
            ViewBag.list = list;// Đưa dữ liệu ra bằng hàm viewbag

            return View();
        }
    }
}