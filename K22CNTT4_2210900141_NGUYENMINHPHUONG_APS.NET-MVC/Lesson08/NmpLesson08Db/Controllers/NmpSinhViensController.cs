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
    public class NmpSinhViensController : Controller
    {
        private nmp_qlsinhvienEntities db = new nmp_qlsinhvienEntities();

        // GET: NmpSinhViens
        public ActionResult NmpIndex()
        {
            var sinhVien = db.SinhVien.Include(s => s.Khoa);
            return View(sinhVien.ToList());
        }

        // GET: NmpSinhViens/Details/5
        public ActionResult NmpDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien sinhVien = db.SinhVien.Find(id);
            if (sinhVien == null)
            {
                return HttpNotFound();
            }
            return View(sinhVien);
        }

        // GET: NmpSinhViens/Create
        public ActionResult NmpCreate()
        {
            ViewBag.MaKH = new SelectList(db.Khoa, "MaKH", "TenKH");
            return View();
        }

        // POST: NmpSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmpCreate([Bind(Include = "MaSV,HoSV,TenSV,Phai,NgaySinh,NoiSinh,MaKH,HocBong,DiemTrungBinh")] SinhVien sinhVien)
        {
            if (ModelState.IsValid)
            {
                db.SinhVien.Add(sinhVien);
                db.SaveChanges();
                return RedirectToAction("NmpIndex");
            }

            ViewBag.MaKH = new SelectList(db.Khoa, "MaKH", "TenKH", sinhVien.MaKH);
            return View(sinhVien);
        }

        // GET: NmpSinhViens/Edit/5
        public ActionResult NmpEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien sinhVien = db.SinhVien.Find(id);
            if (sinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKH = new SelectList(db.Khoa, "MaKH", "TenKH", sinhVien.MaKH);
            return View(sinhVien);
        }

        // POST: NmpSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmpEdit([Bind(Include = "MaSV,HoSV,TenSV,Phai,NgaySinh,NoiSinh,MaKH,HocBong,DiemTrungBinh")] SinhVien sinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NmpIndex");
            }
            ViewBag.MaKH = new SelectList(db.Khoa, "MaKH", "TenKH", sinhVien.MaKH);
            return View(sinhVien);
        }

        // GET: NmpSinhViens/Delete/5
        public ActionResult NmpDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien sinhVien = db.SinhVien.Find(id);
            if (sinhVien == null)
            {
                return HttpNotFound();
            }
            return View(sinhVien);
        }

        // POST: NmpSinhViens/Delete/5
        [HttpPost, ActionName("NmpDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SinhVien sinhVien = db.SinhVien.Find(id);
            db.SinhVien.Remove(sinhVien);
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
