using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDTD_Lab04_1.Models;

namespace TDTD_Lab04_1.Controllers
{
    public class TDTDCustomerController : Controller
    {
        // GET: TDTDCustomer
        public ActionResult TDTDCustomerDetail()
        {
            //tạo một đối tượng Customer ( nhớ using Lab04.Models vào nhé)
            TDTDCustomer cus = new TDTDCustomer()
            {
                CustomerId = "KH001",
                FullName = "Trịnh Văn Chung",
                Address = "Hà Nội",
                Email = "devmaster.founder@gmail.com",
                Phone = "0978.611.889",
                Balance = 15200000
            };
            //cách 1 gán dữ liệu vào ViewBag để chuyển tới View
            //ViewBag.customer = cus;
            //return View();
            //có thể truyền dữ liệu qua đối tượng model để chuyển tới View
            return View(cus);
        }
        public ActionResult TDTDCustomerList()
        {
            //tạo một danh sách khách hàng
            List<TDTDCustomer> listcustomer = new List<TDTDCustomer>(){
                new TDTDCustomer(){ CustomerId = "KH001",
                    FullName = "Trịnh Văn Chung",
                    Address = "Hà Nội",Email = "devmaster.founder@gmail.com",
                    Phone = "0978.611.889",Balance = 15200000},
                new TDTDCustomer(){ CustomerId = "KH002",
                    FullName = "Đỗ Thị Cúc",
                    Address = "Hà Nội",Email = "cucdt@gmail.com",
                    Phone = "0986.767.444",Balance = 2200000},
                new TDTDCustomer(){ CustomerId = "KH003",
                    FullName = "Nguyễn Tuấn Thắng",
                    Address = "Nam Định",Email = "thangnt@gmail.com",
                    Phone = "0924.656.542",Balance = 1200000},
                new TDTDCustomer(){ CustomerId = "KH004",
                    FullName = "Lê Ngọc Hải",
                    Address = "Hà Nội",Email = "hailn@gmail.com",
                    Phone = "0996.555.267",Balance = 6200000 }
                };
            //gán dữ liệu vào ViewBag để chuyển qua View
            ViewBag.listcustomer = listcustomer;
            return View();
        }
    }
}