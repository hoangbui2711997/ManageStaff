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
//    public class DocumentsController : Controller
//    {
//        private ManageStaffs db = new ManageStaffs();

//        // GET: Documents
//        public ActionResult Index()
//        {
//            return View(db.Documents.ToList());
//        }

//        // GET: Documents/Details/5
//        public ActionResult Details(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Document document = db.Documents.Find(id);
//            if (document == null)
//            {
//                return HttpNotFound();
//            }
//            return View(document);
//        }

//        // GET: Documents/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Documents/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Code,Name,DateRelease,Link")] Document document)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Documents.Add(document);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(document);
//        }

//        // GET: Documents/Edit/5
//        public ActionResult Edit(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Document document = db.Documents.Find(id);
//            if (document == null)
//            {
//                return HttpNotFound();
//            }
//            return View(document);
//        }

//        // POST: Documents/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Code,Name,DateRelease,Link")] Document document)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(document).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(document);
//        }

//        // GET: Documents/Delete/5
//        public ActionResult Delete(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Document document = db.Documents.Find(id);
//            if (document == null)
//            {
//                return HttpNotFound();
//            }
//            return View(document);
//        }

//        // POST: Documents/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(string id)
//        {
//            Document document = db.Documents.Find(id);
//            db.Documents.Remove(document);
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
