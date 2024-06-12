using NMP_Lession04Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NMP_Lession04Demo.Controllers
{
    public class NmpCustomerScaffdingController : Controller
    {

        // mockdata
        private List<NMPCustomer> listCustomer = new List<NMPCustomer>()
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
        // GET: NmpCustomerScaffding
        // listcustomer

      public ActionResult NmpIndex()
        {
            return View(listCustomer);
        }
        public ActionResult NmpCreate() {
            var model = new NMPCustomer();
            return View();
                }
    }
}