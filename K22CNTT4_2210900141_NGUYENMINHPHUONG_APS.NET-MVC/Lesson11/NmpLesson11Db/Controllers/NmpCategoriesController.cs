using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NmpLesson11Db.Models;

namespace NmpLesson11Db.Controllers
{
    public class NmpCategoriesController : Controller
    {
        private Nmpk22cntt4Lesson11Entities db = new Nmpk22cntt4Lesson11Entities();

        // GET: NmpCategories
        public ActionResult NmpIndex()
        {
            return View(db.NmpCategory.ToList());
        }

        // GET: NmpCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmpCategory nmpCategory = db.NmpCategory.Find(id);
            if (nmpCategory == null)
            {
                return HttpNotFound();
            }
            return View(nmpCategory);
        }

        // GET: NmpCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NmpCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NmpID,NmpCateName,NmpStatus")] NmpCategory nmpCategory)
        {
            if (ModelState.IsValid)
            {
                db.NmpCategory.Add(nmpCategory);
                db.SaveChanges();
                return RedirectToAction("NmpIndex");
            }

            return View(nmpCategory);
        }

        // GET: NmpCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmpCategory nmpCategory = db.NmpCategory.Find(id);
            if (nmpCategory == null)
            {
                return HttpNotFound();
            }
            return View(nmpCategory);
        }

        // POST: NmpCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NmpID,NmpCateName,NmpStatus")] NmpCategory nmpCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nmpCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NmpIndex");
            }
            return View(nmpCategory);
        }

        // GET: NmpCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmpCategory nmpCategory = db.NmpCategory.Find(id);
            if (nmpCategory == null)
            {
                return HttpNotFound();
            }
            return View(nmpCategory);
        }

        // POST: NmpCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NmpCategory nmpCategory = db.NmpCategory.Find(id);
            db.NmpCategory.Remove(nmpCategory);
            db.SaveChanges();
            return RedirectToAction("NmpIndex");
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
