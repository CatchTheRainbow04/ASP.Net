using Lab3_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3_4.Controllers
{
    public class TDTD_HTMLHelperController : Controller
    {
        // GET: TDTD_Helper_Methods
        //Bài 3.3
        public ActionResult FormRegister()
        {
            // tạo list cho droplist
            ViewBag.listCountry = new List<TDTDCountry>() {
                new TDTDCountry(){ID="0",Name="-- Chọn Quốc Gia --"},
                new TDTDCountry(){ID="VN",Name="Việt Nam"},
                new TDTDCountry(){ID="AT",Name="AUSTRALIA"},
                new TDTDCountry(){ID="UK",Name="Anh"},
                new TDTDCountry(){ID="FR",Name="Pháp"},
                new TDTDCountry(){ID="US",Name="Mỹ"},
                new TDTDCountry(){ID="KP",Name="Hàn Quốc"},
                new TDTDCountry(){ID="HU",Name="Hồng Kong"},
                new TDTDCountry(){ID="CN",Name="Trung Quốc"},
                };
            return View();
        }

        public ActionResult Register()
        {
            // Lấy giá trị từ các trường được đẩy lên server khi submit
            string fvr = "";

            TempData["UName"] = Request["txtUName"];
            TempData["Pass"] = Request["txtPass"];
            TempData["FName"] = Request["txtFName"];
            TempData["Gender"] = Request["Gender"].ToString();
            TempData["Address"] = Request["txtAddress"];
            TempData["Email"] = Request["txtEmail"];
            TempData["Country"] = Request["Country"];

            if (Request["Reading"].ToString().Contains("true"))
                fvr += "Reading ,";
            if (Request["Shopping"].ToString().Contains("true"))
                fvr += "Shopping ,";
            if (Request["Sport"].ToString().Contains("true"))
                fvr += "Sport ,";

            TempData["Favourist"] = fvr;

            return View();
        }

    }
}