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
    public class NmpSinhViensController : Controller
    {
        private NmpK22CNTT4_Lesson07DbEntities db = new NmpK22CNTT4_Lesson07DbEntities();

        // GET: NmpSinhViens
        public ActionResult NmpIndex()
        {
            var nmpSinhViens = db.NmpSinhViens.Include(n => n.NmpKhoa);
            return View(nmpSinhViens.ToList());
        }

        // GET: NmpSinhViens/Details/5
        public ActionResult NmpDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmpSinhVien nmpSinhVien = db.NmpSinhViens.Find(id);
            if (nmpSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(nmpSinhVien);
        }

        // GET: NmpSinhViens/Create
        public ActionResult NmpCreate()
        {
            ViewBag.NmpMaKhoa = new SelectList(db.NmpKhoas, "NmpMaKhoa", "NmpTenKhoa");
            return View();
        }

        // POST: NmpSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmpCreate([Bind(Include = "NmpMaSV,NmpHoSV,NmpTenSV,NmpPhai,NmpEmail,NmpPhone,NmpMaKhoa")] NmpSinhVien nmpSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.NmpSinhViens.Add(nmpSinhVien);
                db.SaveChanges();
                return RedirectToAction("NmpIndex");
            }

            ViewBag.NmpMaKhoa = new SelectList(db.NmpKhoas, "NmpMaKhoa", "NmpTenKhoa", nmpSinhVien.NmpMaKhoa);
            return View(nmpSinhVien);
        }

        // GET: NmpSinhViens/Edit/5
        public ActionResult NmpEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmpSinhVien nmpSinhVien = db.NmpSinhViens.Find(id);
            if (nmpSinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.NmpMaKhoa = new SelectList(db.NmpKhoas, "NmpMaKhoa", "NmpTenKhoa", nmpSinhVien.NmpMaKhoa);
            return View(nmpSinhVien);
        }

        // POST: NmpSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmpEdit([Bind(Include = "NmpMaSV,NmpHoSV,NmpTenSV,NmpPhai,NmpEmail,NmpPhone,NmpMaKhoa")] NmpSinhVien nmpSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nmpSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NmpIndex");
            }
            ViewBag.NmpMaKhoa = new SelectList(db.NmpKhoas, "NmpMaKhoa", "NmpTenKhoa", nmpSinhVien.NmpMaKhoa);
            return View(nmpSinhVien);
        }

        // GET: NmpSinhViens/Delete/5
        public ActionResult NmpDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmpSinhVien nmpSinhVien = db.NmpSinhViens.Find(id);
            if (nmpSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(nmpSinhVien);
        }

        // POST: NmpSinhViens/Delete/5
        [HttpPost, ActionName("NmpDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NmpSinhVien nmpSinhVien = db.NmpSinhViens.Find(id);
            db.NmpSinhViens.Remove(nmpSinhVien);
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
