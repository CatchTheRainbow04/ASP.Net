using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3_1.Controllers
{
    public class TDTDStudentController : Controller
    {
        //Bài tập video
        public ActionResult Index()
        {
            ViewData["msg"] = "Thông báo bây giờ là ";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss tt dd/MM/yyyy");
            return View();
        }
        public ActionResult StudentList()
        {
            string[] names = { "Tạ Đình Thành Doanh", "Hehe" };
            ViewBag.msg = "Danh sánh học sinh :";
            ViewBag.names = names;
            return View();
        }
        public ActionResult TestTempData()
        {
            ViewBag.dl = "Data in ViewBag";
            ViewData["dl"] = "Data in ViewData";
            TempData["dl"] = "Data in TempData";
            return Redirect("StudentAbout");
        }
        public ActionResult StudentAbout()
        {
            return View();
        }
        public ActionResult Insert()
        {
            return View("AddStudent");
        }
    }
}