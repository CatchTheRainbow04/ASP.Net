using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDTD_Lesson05_Video.Models;

namespace TDTD_Lesson05_Video.Controllers
{
    public class TDTDListCustomerScaffdingController : Controller
    {
        //mockdata
        private static List<TDTDCustomer> listCustomer = new List<TDTDCustomer>()
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
        // GET: TDTDListCustomerScaffding
        public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult TDTDCreate()
        {
            var model = new TDTDCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult TDTDCreate(TDTDCustomer model)
        {
            //them moi thong tin khach hang
            listCustomer.Add(model);
            //return View(model)
            //chuyen ve trang khach hang
            return RedirectToAction("Index");
        }
        public ActionResult TDTDEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x => x.CustomerID == id);
            return View(customer);
        }
        [HttpPost]
        public ActionResult TDTDEdit(TDTDCustomer customer)
        {
            //tim phan can sua
            var so = listCustomer.FirstOrDefault(x => x.CustomerID == customer.CustomerID);
            //sua lai thong tin
            so.CustomerID = customer.CustomerID;
            so.FirstName = customer.FirstName;
            so.LastName = customer.LastName;
            so.Address = customer.Address;
            so.YearOfBirth = customer.YearOfBirth;
            //chuyen toi danh sach 
            return RedirectToAction("Index");
        }
        public ActionResult TDTDDetail(int id)
        {
            var cus = listCustomer.FirstOrDefault(x => x.CustomerID == id);
            return View(cus);
        }
        public ActionResult TDTDDelete(int id)
        {
            var delcustomer = listCustomer.FirstOrDefault(x => x.CustomerID ==id);
            listCustomer.Remove(delcustomer);
            return RedirectToAction("Index");
        }
    }
}