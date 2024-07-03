using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NmpLesson08Db.Models;

namespace NmpLesson08Db.Controllers
{
    public class NmpKhoasController : Controller
    {
        private nmp_qlsinhvienEntities db = new nmp_qlsinhvienEntities();

        // GET: NmpKhoas
        public ActionResult NmpIndex()
        {
            return View(db.Khoa.ToList());
        }

        // GET: NmpKhoas/Details/5
        public ActionResult NmpDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Khoa khoa = db.Khoa.Find(id);
            if (khoa == null)
            {
                return HttpNotFound();
            }
            return View(khoa);
        }

        // GET: NmpKhoas/Create
        public ActionResult NmpCreate()
        {
            return View();
        }

        // POST: NmpKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmpCreate([Bind(Include = "MaKH,TenKH")] Khoa khoa)
        {
            if (ModelState.IsValid)
            {
                db.Khoa.Add(khoa);
                db.SaveChanges();
                return RedirectToAction("NmpIndex");
            }

            return View(khoa);
        }

        // GET: NmpKhoas/Edit/5
        public ActionResult NmpEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Khoa khoa = db.Khoa.Find(id);
            if (khoa == null)
            {
                return HttpNotFound();
            }
            return View(khoa);
        }

        // POST: NmpKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmpEdit([Bind(Include = "MaKH,TenKH")] Khoa khoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(khoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NmpIndex");
            }
            return View(khoa);
        }

        // GET: NmpKhoas/Delete/5
        public ActionResult NmpDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Khoa khoa = db.Khoa.Find(id);
            if (khoa == null)
            {
                return HttpNotFound();
            }
            return View(khoa);
        }

        // POST: NmpKhoas/Delete/5
        [HttpPost, ActionName("NmpDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Khoa khoa = db.Khoa.Find(id);
            db.Khoa.Remove(khoa);
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
