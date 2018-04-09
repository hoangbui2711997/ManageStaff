//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using ManageStaff.Data;
//using ManageStaff.Models;

//namespace ManageStaff.Controllers
//{
//    public class DegreesController : Controller
//    {
//        private ManageStaffs db = new ManageStaffs();

//        // GET: Degrees
//        public ActionResult Index()
//        {
//            return View(db.Degrees.ToList());
//        }

//        // GET: Degrees/Details/5
//        public ActionResult Details(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Degree degree = db.Degrees.Find(id);
//            if (degree == null)
//            {
//                return HttpNotFound();
//            }
//            return View(degree);
//        }

//        // GET: Degrees/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Degrees/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Code,Name,CodeView")] Degree degree)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Degrees.Add(degree);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(degree);
//        }

//        // GET: Degrees/Edit/5
//        public ActionResult Edit(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Degree degree = db.Degrees.Find(id);
//            if (degree == null)
//            {
//                return HttpNotFound();
//            }
//            return View(degree);
//        }

//        // POST: Degrees/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Code,Name,CodeView")] Degree degree)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(degree).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(degree);
//        }

//        // GET: Degrees/Delete/5
//        public ActionResult Delete(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Degree degree = db.Degrees.Find(id);
//            if (degree == null)
//            {
//                return HttpNotFound();
//            }
//            return View(degree);
//        }

//        // POST: Degrees/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(string id)
//        {
//            Degree degree = db.Degrees.Find(id);
//            db.Degrees.Remove(degree);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}
