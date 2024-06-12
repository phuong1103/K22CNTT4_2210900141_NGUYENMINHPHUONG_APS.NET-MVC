using NMP_Lab04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NMP_Lab04.Controllers
{
    public class NMPCustomerController : Controller
    {
        // GET: NMPCustomer
        public ActionResult NMPCustomerDetail()
        {
            // Create a Customer object
            NMPCustomer cus = new NMPCustomer()
            {
                CustomerId = "KH001",
                FullName = "Nguyễn Minh Phương",
                Address ="Hà Nội",
                Email = "nminhphuong685@gmail.com",
                Phone = "0348124474",
                Balance = 15200000
            };


           // ViewBag.Customer = customer;


            //ViewBag.Customer = customer;

           
            return View(cus);
        }
        public ActionResult NMPCustomerList() {
            //tạo một danh sách khách hàng
            List<NMPCustomer> listcustomer = new List<NMPCustomer>() {
            new NMPCustomer(){ CustomerId = "KH001",
                      FullName = "Nguyễn Minh Phương",
                      Address = "Phú Thọ",Email = "nminhphuong685@gmail.com",
                      Phone = "034 812 4474 ",Balance = 15200000},
            new NMPCustomer(){ CustomerId = "KH001",
                      FullName = "Nguyễn Văn A",
                      Address = "Hà Nội",Email = "nminha685@gmail.com",
                      Phone = "034 812 4474 ",Balance = 15200000},
            new NMPCustomer(){ CustomerId = "KH001",
                      FullName = "Nguyễn Tiến Minh",
                      Address = "Hà Nội",Email = "nminhb685@gmail.com",
                      Phone = "034 812 4474 ",Balance = 15200000},
            new NMPCustomer(){ CustomerId = "KH001",
                      FullName = "Nguyễn Hà Ngọc",
                      Address = "Hà Nội",Email = "nmphuong685@gmail.com",
                      Phone = "034 812 4474 ",Balance = 15200000}

            };
            ViewBag.listcustomer = listcustomer;
            return View();
        }
    }
}