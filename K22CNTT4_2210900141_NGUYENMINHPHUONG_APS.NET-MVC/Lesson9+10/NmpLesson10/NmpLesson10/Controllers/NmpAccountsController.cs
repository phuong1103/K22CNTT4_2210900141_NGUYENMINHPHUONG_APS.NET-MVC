using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NmpLesson10.Models;

namespace NmpLesson10.Controllers
{
    public class NmpAccountsController : Controller
    {
        private NmpK22cntt4Lesson10Entities db = new NmpK22cntt4Lesson10Entities();

        // GET: NmpAccounts
        public ActionResult Index()
        {
            return View(db.NmpAccount.ToList());
        }

        // GET: NmpAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmpAccount nmpAccount = db.NmpAccount.Find(id);
            if (nmpAccount == null)
            {
                return HttpNotFound();
            }
            return View(nmpAccount);
        }

        // GET: NmpAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NmpAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NmpID,NmpUserName,NmpPassword,NmpFullName,NmpEmail,NmpPhone,NmpActive")] NmpAccount nmpAccount)
        {
            if (ModelState.IsValid)
            {
                db.NmpAccount.Add(nmpAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nmpAccount);
        }

        // GET: NmpAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmpAccount nmpAccount = db.NmpAccount.Find(id);
            if (nmpAccount == null)
            {
                return HttpNotFound();
            }
            return View(nmpAccount);
        }

        // POST: NmpAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NmpID,NmpUserName,NmpPassword,NmpFullName,NmpEmail,NmpPhone,NmpActive")] NmpAccount nmpAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nmpAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nmpAccount);
        }

        // GET: NmpAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmpAccount nmpAccount = db.NmpAccount.Find(id);
            if (nmpAccount == null)
            {
                return HttpNotFound();
            }
            return View(nmpAccount);
        }

        // POST: NmpAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NmpAccount nmpAccount = db.NmpAccount.Find(id);
            db.NmpAccount.Remove(nmpAccount);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        // log in
        public ActionResult NmpLogin()
        {
          
            var nmpModel = new NmpAccount();
        return View(); 
        }
        [HttpPost]
        public ActionResult NmpLogin(NmpAccount nmpAccount)
        {
            var nmpCheck = db.NmpAccount.Where(x => x.NmpUserName.Equals(nmpAccount.NmpUserName)&& x.NmpPassword.Equals(nmpAccount.NmpPassword)).FirstOrDefault();
            if (nmpCheck != null) {
                //Lưu session
                Session["NmpAccounts"] = nmpCheck;
                return Redirect("/");
            }
            return View(nmpAccount);
        }
    }
}
