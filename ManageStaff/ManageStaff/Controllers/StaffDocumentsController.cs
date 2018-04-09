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
//    public class StaffDocumentsController : Controller
//    {
//        private ManageStaffs db = new ManageStaffs();

//        // GET: StaffDocuments
//        public ActionResult Index()
//        {
//            var staffDocuments = db.StaffDocuments.Include(s => s.Document).Include(s => s.Staff);
//            return View(staffDocuments.ToList());
//        }

//        // GET: StaffDocuments/Details/5
//        public ActionResult Details(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            StaffDocument staffDocument = db.StaffDocuments.Find(id);
//            if (staffDocument == null)
//            {
//                return HttpNotFound();
//            }
//            return View(staffDocument);
//        }

//        // GET: StaffDocuments/Create
//        public ActionResult Create()
//        {
//            ViewBag.DocumentCode = new SelectList(db.Documents, "Code", "Name");
//            ViewBag.StaffCode = new SelectList(db.Staffs, "Code", "Name");
//            return View();
//        }

//        // POST: StaffDocuments/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "StaffCode,DocumentCode,PagesWrite,Thread")] StaffDocument staffDocument)
//        {
//            if (ModelState.IsValid)
//            {
//                db.StaffDocuments.Add(staffDocument);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            ViewBag.DocumentCode = new SelectList(db.Documents, "Code", "Name", staffDocument.DocumentCode);
//            ViewBag.StaffCode = new SelectList(db.Staffs, "Code", "Name", staffDocument.StaffCode);
//            return View(staffDocument);
//        }

//        // GET: StaffDocuments/Edit/5
//        public ActionResult Edit(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            StaffDocument staffDocument = db.StaffDocuments.Find(id);
//            if (staffDocument == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.DocumentCode = new SelectList(db.Documents, "Code", "Name", staffDocument.DocumentCode);
//            ViewBag.StaffCode = new SelectList(db.Staffs, "Code", "Name", staffDocument.StaffCode);
//            return View(staffDocument);
//        }

//        // POST: StaffDocuments/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "StaffCode,DocumentCode,PagesWrite,Thread")] StaffDocument staffDocument)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(staffDocument).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            ViewBag.DocumentCode = new SelectList(db.Documents, "Code", "Name", staffDocument.DocumentCode);
//            ViewBag.StaffCode = new SelectList(db.Staffs, "Code", "Name", staffDocument.StaffCode);
//            return View(staffDocument);
//        }

//        // GET: StaffDocuments/Delete/5
//        public ActionResult Delete(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            StaffDocument staffDocument = db.StaffDocuments.Find(id);
//            if (staffDocument == null)
//            {
//                return HttpNotFound();
//            }
//            return View(staffDocument);
//        }

//        // POST: StaffDocuments/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(string id)
//        {
//            StaffDocument staffDocument = db.StaffDocuments.Find(id);
//            db.StaffDocuments.Remove(staffDocument);
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
