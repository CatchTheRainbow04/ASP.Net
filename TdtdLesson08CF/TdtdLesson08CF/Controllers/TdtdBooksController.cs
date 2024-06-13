using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TdtdLesson08CF.Models;

namespace TdtdLesson08CF.Controllers
{
    public class TdtdBooksController : Controller
    {
        private TdtdBookStore db = new TdtdBookStore();

        // GET: TdtdBooks
        public ActionResult Index()
        {
            var tdtdBooks = db.TdtdBooks.Include(t => t.TdtdCategory);
            return View(tdtdBooks.ToList());
        }

        // GET: TdtdBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TdtdBook tdtdBook = db.TdtdBooks.Find(id);
            if (tdtdBook == null)
            {
                return HttpNotFound();
            }
            return View(tdtdBook);
        }

        // GET: TdtdBooks/Create
        public ActionResult Create()
        {
            ViewBag.TdtdCategoryId = new SelectList(db.TdtdCategories, "TdtdCategoryId", "TdtdCategoryName");
            return View();
        }

        // POST: TdtdBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TdtdBookId,TdtdBookTitle,TdtdAuthor,TdtdYear,TdtdPulisher,TdtdPicture,TdtdCategoryId")] TdtdBook tdtdBook)
        {
            if (ModelState.IsValid)
            {
                db.TdtdBooks.Add(tdtdBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TdtdCategoryId = new SelectList(db.TdtdCategories, "TdtdCategoryId", "TdtdCategoryName", tdtdBook.TdtdCategoryId);
            return View(tdtdBook);
        }

        // GET: TdtdBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TdtdBook tdtdBook = db.TdtdBooks.Find(id);
            if (tdtdBook == null)
            {
                return HttpNotFound();
            }
            ViewBag.TdtdCategoryId = new SelectList(db.TdtdCategories, "TdtdCategoryId", "TdtdCategoryName", tdtdBook.TdtdCategoryId);
            return View(tdtdBook);
        }

        // POST: TdtdBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TdtdBookId,TdtdBookTitle,TdtdAuthor,TdtdYear,TdtdPulisher,TdtdPicture,TdtdCategoryId")] TdtdBook tdtdBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tdtdBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TdtdCategoryId = new SelectList(db.TdtdCategories, "TdtdCategoryId", "TdtdCategoryName", tdtdBook.TdtdCategoryId);
            return View(tdtdBook);
        }

        // GET: TdtdBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TdtdBook tdtdBook = db.TdtdBooks.Find(id);
            if (tdtdBook == null)
            {
                return HttpNotFound();
            }
            return View(tdtdBook);
        }

        // POST: TdtdBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TdtdBook tdtdBook = db.TdtdBooks.Find(id);
            db.TdtdBooks.Remove(tdtdBook);
            db.SaveChanges();
            return RedirectToAction("Index");
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
