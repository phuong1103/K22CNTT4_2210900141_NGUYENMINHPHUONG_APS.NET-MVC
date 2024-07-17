using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using nmplesson12.Models;

namespace nmplesson12.Controllers
{
    public class NMP_SACHController : Controller
    {
        private NguyenMinhPhuong_2210900141Entities2 db = new NguyenMinhPhuong_2210900141Entities2();

        // GET: NMP_SACH
        public ActionResult NmpIndex()
        {
            var nMP_SACH = db.NMP_SACH.Include(n => n.NMP_TACGIA);
            return View(nMP_SACH.ToList());
        }

        // GET: NMP_SACH/Details/5
        public ActionResult NmpDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NMP_SACH nMP_SACH = db.NMP_SACH.Find(id);
            if (nMP_SACH == null)
            {
                return HttpNotFound();
            }
            return View(nMP_SACH);
        }

        // GET: NMP_SACH/Create
        public ActionResult NmpCreate()
        {
            ViewBag.Nmp_MaTG = new SelectList(db.NMP_TACGIA, "Nmp_MaTG", "NmpTenTacGia");
            return View();
        }

        // POST: NMP_SACH/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmpCreate([Bind(Include = "Nmp_MaSach,Nmp_TenSach,Nmp_SoTrang,Nmp_NamXB,Nmp_MaTG,Nmp_TrangThai")] NMP_SACH nMP_SACH)
        {
            if (ModelState.IsValid)
            {
                db.NMP_SACH.Add(nMP_SACH);
                db.SaveChanges();
                return RedirectToAction("NmpIndex");
            }

            ViewBag.Nmp_MaTG = new SelectList(db.NMP_TACGIA, "Nmp_MaTG", "NmpTenTacGia", nMP_SACH.Nmp_MaTG);
            return View(nMP_SACH);
        }

        // GET: NMP_SACH/Edit/5
        public ActionResult NmpEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NMP_SACH nMP_SACH = db.NMP_SACH.Find(id);
            if (nMP_SACH == null)
            {
                return HttpNotFound();
            }
            ViewBag.Nmp_MaTG = new SelectList(db.NMP_TACGIA, "Nmp_MaTG", "NmpTenTacGia", nMP_SACH.Nmp_MaTG);
            return View(nMP_SACH);
        }

        // POST: NMP_SACH/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmpEdit([Bind(Include = "Nmp_MaSach,Nmp_TenSach,Nmp_SoTrang,Nmp_NamXB,Nmp_MaTG,Nmp_TrangThai")] NMP_SACH nMP_SACH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nMP_SACH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NmpIndex");
            }
            ViewBag.Nmp_MaTG = new SelectList(db.NMP_TACGIA, "Nmp_MaTG", "NmpTenTacGia", nMP_SACH.Nmp_MaTG);
            return View(nMP_SACH);
        }

        // GET: NMP_SACH/Delete/5
        public ActionResult NmpDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NMP_SACH nMP_SACH = db.NMP_SACH.Find(id);
            if (nMP_SACH == null)
            {
                return HttpNotFound();
            }
            return View(nMP_SACH);
        }

        // POST: NMP_SACH/Delete/5
        [HttpPost, ActionName("NmpDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NMP_SACH nMP_SACH = db.NMP_SACH.Find(id);
            db.NMP_SACH.Remove(nMP_SACH);
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
