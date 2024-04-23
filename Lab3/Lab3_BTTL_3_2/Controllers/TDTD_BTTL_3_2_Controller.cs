using Lab3_BTTL_3_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.Mvc;

namespace Lab3_BTTL_3_2.Controllers
{
    public class TDTD_BTTL_3_2_Controller : Controller
    {
        // GET: TDTD_BTTL_3_2_
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FormRegister()
        {
            ViewBag.listType = new List<TDTD_BTTL_Type>(){
                new TDTD_BTTL_Type(){ID = "0", Name = "--Chọn loại hình doanh nghiệp--" },
                new TDTD_BTTL_Type(){ID = "Đơn vị sử nghiệp nhà nước", Name = "Đơn vị sử nghiệp nhà nước"},
                new TDTD_BTTL_Type(){ID = "Doanh nghiệp cá nhân", Name = "Doanh nghiệp cá nhân" },
                new TDTD_BTTL_Type(){ID = "Doanh nghiệp hợp danh", Name = "Doanh nghiệp hợp danh"},
                new TDTD_BTTL_Type(){ID = "Công ty cổ phần", Name = "Công ty cổ phần"},
                new TDTD_BTTL_Type(){ID = "Công ty hợp danh có trách nhiệm hữu hạn", Name = "Công ty hợp danh có trách nhiệm hữu hạn"}
            };
            return View();
        }
        public ActionResult Register()
        {
            TempData["DVT"] = Request["txtDVT"];
            TempData["LHDN"] = Request["LHDN"];
            TempData["SL"] = Request["txtSL"];
            TempData["Address"] = Request["txtAddress"];
            TempData["LH"] = Request["txtLH"];
            TempData["SDT"] = Request["txtSDT"];
            TempData["FAX"] = Request["txtFAX"];
            TempData["Email"] = Request["txtEmail"];
            TempData["Website"] = Request["txtWebsite"];
            TempData["UserName"] = Request["txtUserName"];
            TempData["Password"] = Request["txtPassword"];
            TempData["RPassword"] = Request["txtRPassword"];
            TempData["Receive"] = Request["btnReceive"];
            return View();
        }
    }
}