using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab4._1.Controllers
{
    public class TDTDStudentsController : Controller
    {
        // GET: TDTDStudents
        //Author : Tạ Đình Thành Doanh
        //Class : CNTT2

        public ActionResult Index()
        {
            //Truyền dữ liệu từ controller lên view
            ViewBag.name = "Tạ Đình Thành Doanh";
            ViewData["Birthday"] = "21/04/2004";
            TempData["Phone"] = "0967055032";
            return View();
        }
        public ActionResult Details()
        {
            string TDTDString = "";
            TDTDString += "<h3>Name : Doanh </h3>";
            TDTDString += "<p>MS : 2210900096</p>";
            TDTDString += "<p>Email : doanhdoe@gmail.com";

            ViewBag.Details = TDTDString;
            return View("chiTiet");
        }

        public ActionResult NgonNguRazor()
        {
            return View();
        }

        //HTML Helper
        public ActionResult AddNewStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form)
        {
            //lay du lieu tren form
            string fullname = form["fullname"];
            string msv = form["maSV"];
            string tk = form["userName"];
            string pass = form["passWord"];

            string tdtdString = "<h3>" + fullname + "<h3/>";
            tdtdString += "<p>" + msv;
            tdtdString += "<p>" + tk;
            tdtdString += "<p>" + pass;
            ViewBag.info = tdtdString;
            return View("Ketqua");
        }
    }
}