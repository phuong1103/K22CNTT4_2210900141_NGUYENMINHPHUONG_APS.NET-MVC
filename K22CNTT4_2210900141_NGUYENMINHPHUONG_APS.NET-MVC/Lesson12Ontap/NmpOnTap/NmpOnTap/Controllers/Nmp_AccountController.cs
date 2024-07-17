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
    public class Nmp_AccountController : Controller
    {
        private NguyenMinhPhuongOnTapEntities db = new NguyenMinhPhuongOnTapEntities();

        // GET: Nmp_Account
        public ActionResult Index()
        {
            return View(db.Nmp_Account.ToList());
        }

        // GET: Nmp_Account/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nmp_Account nmp_Account = db.Nmp_Account.Find(id);
            if (nmp_Account == null)
            {
                return HttpNotFound();
            }
            return View(nmp_Account);
        }

        // GET: Nmp_Account/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nmp_Account/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nmp_ID,Nmp_UserName,Nmp_PassWord,Nmp_FullName,Nmp_Email,Nmp_Phone,Nmp_Active")] Nmp_Account nmp_Account)
        {
            if (ModelState.IsValid)
            {
                db.Nmp_Account.Add(nmp_Account);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nmp_Account);
        }

        // GET: Nmp_Account/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nmp_Account nmp_Account = db.Nmp_Account.Find(id);
            if (nmp_Account == null)
            {
                return HttpNotFound();
            }
            return View(nmp_Account);
        }

        // POST: Nmp_Account/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Nmp_ID,Nmp_UserName,Nmp_PassWord,Nmp_FullName,Nmp_Email,Nmp_Phone,Nmp_Active")] Nmp_Account nmp_Account)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nmp_Account).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nmp_Account);
        }

        // GET: Nmp_Account/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nmp_Account nmp_Account = db.Nmp_Account.Find(id);
            if (nmp_Account == null)
            {
                return HttpNotFound();
            }
            return View(nmp_Account);
        }

        // POST: Nmp_Account/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Nmp_Account nmp_Account = db.Nmp_Account.Find(id);
            db.Nmp_Account.Remove(nmp_Account);
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
        //Log in

        public ActionResult NmpLogin()
            {
            var nmpModels = new Nmp_Account();
                return View(); 
            }
        [HttpPost]
        public ActionResult NmpLogin(Nmp_Account nmp_Account)
        {
            var nmpCheck = db.Nmp_Account.Where(x=>x.Nmp_UserName.Equals(nmp_Account.Nmp_UserName) && x.Nmp_PassWord.Equals(nmp_Account.Nmp_PassWord)).FirstOrDefault();
            if (nmpCheck != null)
            {
                //Lưu Sesion
                Session["NmpAccount"] = nmpCheck;
                return Redirect("/");
            }

            return View();
        }
        // signin
        public ActionResult NmpSignIn()
        {
            return View();
        }
        public ActionResult NmpSignIn( Nmp_Account nmp_Account)
        {
            return View();
        }
    }
}
