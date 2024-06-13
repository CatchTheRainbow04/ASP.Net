using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TdtdLesson08CF.Models;

namespace TdtdLesson08CF.Controllers
{
    public class TdtdCategoryController : Controller
    {
        private static TdtdBookStore _TdtdBookStore;
        public TdtdCategoryController()
        {
            _TdtdBookStore = new TdtdBookStore();
        }
        // GET: TdtdCategory
        public ActionResult TdtdIndex()
        {
            var tdtdCategory = _TdtdBookStore.TdtdCategories.ToList();
            return View(tdtdCategory);
        }
        public ActionResult TdtdCreate()
        {
            var tdtdcategory = new TdtdCategory();
            return View();
        }
        [HttpPost]
        public ActionResult TdtdCreate(TdtdCategory c)
        {
            _TdtdBookStore.TdtdCategories.Add(c);
            _TdtdBookStore.SaveChanges();
            return RedirectToAction("TdtdIndex");
        }
    }
}