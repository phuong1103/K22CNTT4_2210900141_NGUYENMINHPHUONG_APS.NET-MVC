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
    public class NMP_TACGIAController : Controller
    {
        private NguyenMinhPhuong_2210900141Entities2 db = new NguyenMinhPhuong_2210900141Entities2();

        // GET: NMP_TACGIA
        public ActionResult NmpIndex()
        {
            return View(db.NMP_TACGIA.ToList());
        }

        // GET: NMP_TACGIA/Details/5
        public ActionResult NmpDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NMP_TACGIA nMP_TACGIA = db.NMP_TACGIA.Find(id);
            if (nMP_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nMP_TACGIA);
        }

        // GET: NMP_TACGIA/Create
        public ActionResult NmpCreate()
        {
            return View();
        }

        // POST: NMP_TACGIA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmpCreate([Bind(Include = "Nmp_MaTG,NmpTenTacGia")] NMP_TACGIA nMP_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.NMP_TACGIA.Add(nMP_TACGIA);
                db.SaveChanges();
                return RedirectToAction("NmpIndex");
            }

            return View(nMP_TACGIA);
        }

        // GET: NMP_TACGIA/Edit/5
        public ActionResult NmpEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NMP_TACGIA nMP_TACGIA = db.NMP_TACGIA.Find(id);
            if (nMP_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nMP_TACGIA);
        }

        // POST: NMP_TACGIA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmpEdit([Bind(Include = "Nmp_MaTG,NmpTenTacGia")] NMP_TACGIA nMP_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nMP_TACGIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NmpIndex");
            }
            return View(nMP_TACGIA);
        }

        // GET: NMP_TACGIA/Delete/5
        public ActionResult NmpDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NMP_TACGIA nMP_TACGIA = db.NMP_TACGIA.Find(id);
            if (nMP_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nMP_TACGIA);
        }

        // POST: NMP_TACGIA/Delete/5
        [HttpPost, ActionName("NmpDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NMP_TACGIA nMP_TACGIA = db.NMP_TACGIA.Find(id);
            db.NMP_TACGIA.Remove(nMP_TACGIA);
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
