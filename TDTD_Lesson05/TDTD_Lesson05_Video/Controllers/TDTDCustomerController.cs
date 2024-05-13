using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDTD_Lesson05_Video.Models;

namespace TDTD_Lesson05_Video.Controllers
{
    public class TDTDCustomerController : Controller
    {
        // GET: TDTDCustomer
        public ActionResult Index()
        {
            return View();
        }
        // Action : TDTDCustomerDetail
        public ActionResult TDTDCustomerDetail()
        {
            // tao doi tuong du lieu
            var cus = new TDTDCustomer()
            {
                CustomerID = 1,
                FirstName = "Joestar",
                LastName = "Johnny",
                Address = "America",
                YearOfBirth = 1872,
            };
            ViewBag.cus = cus;
            return View();
        }
        //GET: TDTDListCustomer
        public ActionResult TDTDListCustomer()
        {
            var list = new List<TDTDCustomer>()
            {
                new TDTDCustomer()
                {
                    CustomerID = 1,
                    FirstName = "Joestar",
                    LastName = "Johnny",
                    Address = "America",
                    YearOfBirth = 1872,
                },
                new TDTDCustomer()
                {
                    CustomerID = 2,
                    FirstName = "Zeppeli",
                    LastName = "Gyro",
                    Address = "Neapolitan",
                    YearOfBirth = 1866,
                },
                new TDTDCustomer()
                {
                    CustomerID = 3,
                    FirstName = "Brando",
                    LastName = "Diego",
                    Address = "United Kingdom",
                    YearOfBirth = 1870,
                },
                new TDTDCustomer()
                {
                    CustomerID = 4,
                    FirstName = "Funny",
                    LastName = "Valentine",
                    Address = "America",
                    YearOfBirth = 1847,
                }
            };
            ViewBag.list = list; //dua du lieu ra view bang doi tuong viewbag
            return View(list);
        }
    }
}