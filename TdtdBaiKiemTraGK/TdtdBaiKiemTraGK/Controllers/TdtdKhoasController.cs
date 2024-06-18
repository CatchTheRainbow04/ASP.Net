using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TdtdBaiKiemTraGK.Models;

namespace TdtdBaiKiemTraGK.Controllers
{
    public class TdtdKhoasController : Controller
    {
        private TDTDK22CNT2LESSON09DBEntities db = new TDTDK22CNT2LESSON09DBEntities();

        // GET: TdtdKhoas
        public ActionResult TdtdIndex()
        {
            return View(db.tdtdKhoa.ToList());
        }

        // GET: TdtdKhoas/Details/5
        public ActionResult TdtdDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tdtdKhoa tdtdKhoa = db.tdtdKhoa.Find(id);
            if (tdtdKhoa == null)
            {
                return HttpNotFound();
            }
            return View(tdtdKhoa);
        }

        // GET: TdtdKhoas/Create
        public ActionResult TdtdCreate()
        {
            return View();
        }

        // POST: TdtdKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TdtdCreate([Bind(Include = "TdtdMaKH,TdtdTenKH,TdtdTrangThai")] tdtdKhoa tdtdKhoa)
        {
            if (ModelState.IsValid)
            {
                db.tdtdKhoa.Add(tdtdKhoa);
                db.SaveChanges();
                return RedirectToAction("TdtdIndex");
            }

            return View(tdtdKhoa);
        }

        // GET: TdtdKhoas/Edit/5
        public ActionResult TdtdEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tdtdKhoa tdtdKhoa = db.tdtdKhoa.Find(id.Trim());
            if (tdtdKhoa == null)
            {
                return HttpNotFound();
            }
            return View(tdtdKhoa);
        }

        // POST: TdtdKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TdtdEdit([Bind(Include = "TdtdMaKH,TdtdTenKH,TdtdTrangThai")] tdtdKhoa tdtdKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tdtdKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TdtdIndex");
            }
            return View(tdtdKhoa);
        }

        // GET: TdtdKhoas/Delete/5
        public ActionResult TdtdDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tdtdKhoa tdtdKhoa = db.tdtdKhoa.Find(id);
            if (tdtdKhoa == null)
            {
                return HttpNotFound();
            }
            return View(tdtdKhoa);
        }

        // POST: TdtdKhoas/Delete/5
        [HttpPost, ActionName("TdtdDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            tdtdKhoa tdtdKhoa = db.tdtdKhoa.Find(id);
            db.tdtdKhoa.Remove(tdtdKhoa);
            db.SaveChanges();
            return RedirectToAction("TdtdIndex");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
