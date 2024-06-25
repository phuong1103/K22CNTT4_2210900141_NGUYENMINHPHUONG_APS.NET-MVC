using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NmpLesson07Db.Models;

namespace NmpLesson07Db.Controllers
{
    public class NmpKhoasController : Controller
    {
        private NmpK22CNTT4_Lesson07DbEntities db = new NmpK22CNTT4_Lesson07DbEntities();

        // GET: NmpKhoas
        public ActionResult NmpIndex()
        {
            return View(db.NmpKhoas.ToList());
        }

        // GET: NmpKhoas/Details/5
        public ActionResult NmpDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmpKhoa nmpKhoa = db.NmpKhoas.Find(id);
            if (nmpKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nmpKhoa);
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
        public ActionResult NmpCreate([Bind(Include = "NmpMaKhoa,NmpTenKhoa,NmpTrangThai")] NmpKhoa nmpKhoa)
        {
            if (ModelState.IsValid)
            {
                db.NmpKhoas.Add(nmpKhoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nmpKhoa);
        }

        // GET: NmpKhoas/Edit/5
        public ActionResult NmpEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmpKhoa nmpKhoa = db.NmpKhoas.Find(id);
            if (nmpKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nmpKhoa);
        }

        // POST: NmpKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmpEdit([Bind(Include = "NmpMaKhoa,NmpTenKhoa,NmpTrangThai")] NmpKhoa nmpKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nmpKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nmpKhoa);
        }

        // GET: NmpKhoas/Delete/5
        public ActionResult NmpDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmpKhoa nmpKhoa = db.NmpKhoas.Find(id);
            if (nmpKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nmpKhoa);
        }

        // POST: NmpKhoas/Delete/5
        [HttpPost, ActionName("NmpDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NmpKhoa nmpKhoa = db.NmpKhoas.Find(id);
            db.NmpKhoas.Remove(nmpKhoa);
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
