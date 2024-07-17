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
    public class NmpTacGiasController : Controller
    {
        private NguyenMinhPhuongOnTapEntities db = new NguyenMinhPhuongOnTapEntities();

        // GET: NmpTacGias
        public ActionResult NmpIndex()
        {
            return View(db.NmpTacGia.ToList());
        }

        // GET: NmpTacGias/Details/5
        public ActionResult NmpDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmpTacGia nmpTacGia = db.NmpTacGia.Find(id);
            if (nmpTacGia == null)
            {
                return HttpNotFound();
            }
            return View(nmpTacGia);
        }

        // GET: NmpTacGias/Create
        public ActionResult NmpCreate()
        {
            return View();
        }

        // POST: NmpTacGias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmpCreate([Bind(Include = "Nmp_MaTG,Nmp_TenTG")] NmpTacGia nmpTacGia)
        {
            if (ModelState.IsValid)
            {
                db.NmpTacGia.Add(nmpTacGia);
                db.SaveChanges();
                return RedirectToAction("NmpIndex");
            }

            return View(nmpTacGia);
        }

        // GET: NmpTacGias/Edit/5
        public ActionResult NmpEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmpTacGia nmpTacGia = db.NmpTacGia.Find(id);
            if (nmpTacGia == null)
            {
                return HttpNotFound();
            }
            return View(nmpTacGia);
        }

        // POST: NmpTacGias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmpEdit([Bind(Include = "Nmp_MaTG,Nmp_TenTG")] NmpTacGia nmpTacGia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nmpTacGia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NmpIndex");
            }
            return View(nmpTacGia);
        }

        // GET: NmpTacGias/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmpTacGia nmpTacGia = db.NmpTacGia.Find(id);
            if (nmpTacGia == null)
            {
                return HttpNotFound();
            }
            return View(nmpTacGia);
        }

        // POST: NmpTacGias/Delete/5
        [HttpPost, ActionName("NmpDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NmpTacGia nmpTacGia = db.NmpTacGia.Find(id);
            db.NmpTacGia.Remove(nmpTacGia);
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
