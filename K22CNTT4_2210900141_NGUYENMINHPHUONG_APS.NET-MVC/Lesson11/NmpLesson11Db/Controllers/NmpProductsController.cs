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
    public class NmpProductsController : Controller
    {
        private Nmpk22cntt4Lesson11Entities db = new Nmpk22cntt4Lesson11Entities();

        // GET: NmpProducts
        public ActionResult NmpIndex()
        {
            var nmpProduct = db.NmpProduct.Include(n => n.NmpCategory);
            return View(nmpProduct.ToList());
        }

        // GET: NmpProducts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmpProduct nmpProduct = db.NmpProduct.Find(id);
            if (nmpProduct == null)
            {
                return HttpNotFound();
            }
            return View(nmpProduct);
        }

        // GET: NmpProducts/Create
        public ActionResult Create()
        {
            ViewBag.NmpCateId = new SelectList(db.NmpCategory, "NmpID", "NmpCateName");
            return View();
        }

        // POST: NmpProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NmpId2210900141,NmpProName,NmpQty,NmpPrice,NmpCateId,NmpActive")] NmpProduct nmpProduct)
        {
            if (ModelState.IsValid)
            {
                db.NmpProduct.Add(nmpProduct);
                db.SaveChanges();
                return RedirectToAction("NmpIndex");
            }

            ViewBag.NmpCateId = new SelectList(db.NmpCategory, "NmpID", "NmpCateName", nmpProduct.NmpCateId);
            return View(nmpProduct);
        }

        // GET: NmpProducts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmpProduct nmpProduct = db.NmpProduct.Find(id);
            if (nmpProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.NmpCateId = new SelectList(db.NmpCategory, "NmpID", "NmpCateName", nmpProduct.NmpCateId);
            return View(nmpProduct);
        }

        // POST: NmpProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NmpId2210900141,NmpProName,NmpQty,NmpPrice,NmpCateId,NmpActive")] NmpProduct nmpProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nmpProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NmpIndex");
            }
            ViewBag.NmpCateId = new SelectList(db.NmpCategory, "NmpID", "NmpCateName", nmpProduct.NmpCateId);
            return View(nmpProduct);
        }

        // GET: NmpProducts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmpProduct nmpProduct = db.NmpProduct.Find(id);
            if (nmpProduct == null)
            {
                return HttpNotFound();
            }
            return View(nmpProduct);
        }

        // POST: NmpProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NmpProduct nmpProduct = db.NmpProduct.Find(id);
            db.NmpProduct.Remove(nmpProduct);
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
