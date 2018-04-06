using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ManageStaff.Data;
using ManageStaff.Models;

namespace ManageStaff.Controllers
{
    public class GraduatingsController : Controller
    {
        private ManageStaffs db = new ManageStaffs();

        // GET: Graduatings
        public ActionResult Index()
        {
            return View(db.Graduatings.ToList());
        }

        // GET: Graduatings/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Graduating graduating = db.Graduatings.Find(id);
            if (graduating == null)
            {
                return HttpNotFound();
            }
            return View(graduating);
        }

        // GET: Graduatings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Graduatings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Code,Name,Address,Time")] Graduating graduating)
        {
            if (ModelState.IsValid)
            {
                db.Graduatings.Add(graduating);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(graduating);
        }

        // GET: Graduatings/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Graduating graduating = db.Graduatings.Find(id);
            if (graduating == null)
            {
                return HttpNotFound();
            }
            return View(graduating);
        }

        // POST: Graduatings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Code,Name,Address,Time")] Graduating graduating)
        {
            if (ModelState.IsValid)
            {
                db.Entry(graduating).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(graduating);
        }

        // GET: Graduatings/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Graduating graduating = db.Graduatings.Find(id);
            if (graduating == null)
            {
                return HttpNotFound();
            }
            return View(graduating);
        }

        // POST: Graduatings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Graduating graduating = db.Graduatings.Find(id);
            db.Graduatings.Remove(graduating);
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
    }
}
