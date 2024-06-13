using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDTD_Lesson07_1.Models;

namespace TDTD_Lesson07_1.Controllers
{
    public class TDTDStudentsController : Controller
    {
        //mock data
        public static List<TDTDStudent> listStudent = new List<TDTDStudent>() {
            new TDTDStudent (){ TdtdId = 1 , TdtdFullname = "Doanh" , TdtdEmail = "doanhdoe@gmail.com" , TdtdPassword = "123456" , TdtdPhone = "0123456789" , TdtdYearOfBirth = 2004},
            new TDTDStudent (){ TdtdId = 1 , TdtdFullname = "Doanh" , TdtdEmail = "doanhdoe@gmail.com" , TdtdPassword = "123456" , TdtdPhone = "0123456789" , TdtdYearOfBirth = 2004},
            new TDTDStudent (){ TdtdId = 1 , TdtdFullname = "Doanh" , TdtdEmail = "doanhdoe@gmail.com" , TdtdPassword = "123456" , TdtdPhone = "0123456789" , TdtdYearOfBirth = 2004},
        };
        // GET: TDTDStudents
        public ActionResult TdtdListShow()
        {
            return View(listStudent);
        }
    }
}