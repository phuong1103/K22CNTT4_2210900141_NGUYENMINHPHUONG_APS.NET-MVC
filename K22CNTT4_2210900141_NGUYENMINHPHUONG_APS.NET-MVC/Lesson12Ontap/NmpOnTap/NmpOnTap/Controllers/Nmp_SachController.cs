using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NmpOnTap.Models;

namespace NmpOnTap.Controllers
{
    public class Nmp_SachController : Controller
    {
        private NguyenMinhPhuongOnTapEntities db = new NguyenMinhPhuongOnTapEntities();

        // GET: Nmp_Sach
        public ActionResult NmpIndex()
        {
            var nmp_Sach = db.Nmp_Sach.Include(n => n.NmpTacGia);
            return View(nmp_Sach.ToList());
        }

        // GET: Nmp_Sach/Details/5
        public ActionResult NmpDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nmp_Sach nmp_Sach = db.Nmp_Sach.Find(id);
            if (nmp_Sach == null)
            {
                return HttpNotFound();
            }
            return View(nmp_Sach);
        }

        // GET: Nmp_Sach/Create
        public ActionResult NmpCreate()
        {
            ViewBag.Nmp_MaTG = new SelectList(db.NmpTacGia, "Nmp_MaTG", "Nmp_TenTG");
            return View();
        }

        // POST: Nmp_Sach/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmpCreate([Bind(Include = "Nmp_MaSach,Nmp_TenSach,Nmp_SoTrang,Nmp_NamXB,Nmp_MaTG,Nmp_TrangThai")] Nmp_Sach nmp_Sach)
        {
            if (ModelState.IsValid)
            {
                db.Nmp_Sach.Add(nmp_Sach);
                db.SaveChanges();
                return RedirectToAction("NmpIndex");
            }

            ViewBag.Nmp_MaTG = new SelectList(db.NmpTacGia, "Nmp_MaTG", "Nmp_TenTG", nmp_Sach.Nmp_MaTG);
            return View(nmp_Sach);
        }

        // GET: Nmp_Sach/Edit/5
        public ActionResult NmpEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nmp_Sach nmp_Sach = db.Nmp_Sach.Find(id);
            if (nmp_Sach == null)
            {
                return HttpNotFound();
            }
            ViewBag.Nmp_MaTG = new SelectList(db.NmpTacGia, "Nmp_MaTG", "Nmp_TenTG", nmp_Sach.Nmp_MaTG);
            return View(nmp_Sach);
        }

        // POST: Nmp_Sach/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmpEdit([Bind(Include = "Nmp_MaSach,Nmp_TenSach,Nmp_SoTrang,Nmp_NamXB,Nmp_MaTG,Nmp_TrangThai")] Nmp_Sach nmp_Sach)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nmp_Sach).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NmpIndex");
            }
            ViewBag.Nmp_MaTG = new SelectList(db.NmpTacGia, "Nmp_MaTG", "Nmp_TenTG", nmp_Sach.Nmp_MaTG);
            return View(nmp_Sach);
        }

        // GET: Nmp_Sach/Delete/5
        public ActionResult NmpDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nmp_Sach nmp_Sach = db.Nmp_Sach.Find(id);
            if (nmp_Sach == null)
            {
                return HttpNotFound();
            }
            return View(nmp_Sach);
        }

        // POST: Nmp_Sach/Delete/5
        [HttpPost, ActionName("NmpDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Nmp_Sach nmp_Sach = db.Nmp_Sach.Find(id);
            db.Nmp_Sach.Remove(nmp_Sach);
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
