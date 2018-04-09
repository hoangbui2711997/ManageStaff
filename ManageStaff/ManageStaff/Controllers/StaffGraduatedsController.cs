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
//    public class StaffGraduatedsController : Controller
//    {
//        private ManageStaffs db = new ManageStaffs();

//        // GET: StaffGraduateds
//        public ActionResult Index()
//        {
//            var staffGraduateds = db.StaffGraduateds.Include(s => s.Graduating).Include(s => s.Staff);
//            return View(staffGraduateds.ToList());
//        }

//        // GET: StaffGraduateds/Details/5
//        public ActionResult Details(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            StaffGraduated staffGraduated = db.StaffGraduateds.Find(id);
//            if (staffGraduated == null)
//            {
//                return HttpNotFound();
//            }
//            return View(staffGraduated);
//        }

//        // GET: StaffGraduateds/Create
//        public ActionResult Create()
//        {
//            ViewBag.GraduatedCode = new SelectList(db.Graduatings, "Code", "Name");
//            ViewBag.StaffCode = new SelectList(db.Staffs, "Code", "Name");
//            return View();
//        }

//        // POST: StaffGraduateds/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "StaffCode,GraduatedCode,Descript")] StaffGraduated staffGraduated)
//        {
//            if (ModelState.IsValid)
//            {
//                db.StaffGraduateds.Add(staffGraduated);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            ViewBag.GraduatedCode = new SelectList(db.Graduatings, "Code", "Name", staffGraduated.GraduatedCode);
//            ViewBag.StaffCode = new SelectList(db.Staffs, "Code", "Name", staffGraduated.StaffCode);
//            return View(staffGraduated);
//        }

//        // GET: StaffGraduateds/Edit/5
//        public ActionResult Edit(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            StaffGraduated staffGraduated = db.StaffGraduateds.Find(id);
//            if (staffGraduated == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.GraduatedCode = new SelectList(db.Graduatings, "Code", "Name", staffGraduated.GraduatedCode);
//            ViewBag.StaffCode = new SelectList(db.Staffs, "Code", "Name", staffGraduated.StaffCode);
//            return View(staffGraduated);
//        }

//        // POST: StaffGraduateds/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "StaffCode,GraduatedCode,Descript")] StaffGraduated staffGraduated)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(staffGraduated).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            ViewBag.GraduatedCode = new SelectList(db.Graduatings, "Code", "Name", staffGraduated.GraduatedCode);
//            ViewBag.StaffCode = new SelectList(db.Staffs, "Code", "Name", staffGraduated.StaffCode);
//            return View(staffGraduated);
//        }

//        // GET: StaffGraduateds/Delete/5
//        public ActionResult Delete(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            StaffGraduated staffGraduated = db.StaffGraduateds.Find(id);
//            if (staffGraduated == null)
//            {
//                return HttpNotFound();
//            }
//            return View(staffGraduated);
//        }

//        // POST: StaffGraduateds/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(string id)
//        {
//            StaffGraduated staffGraduated = db.StaffGraduateds.Find(id);
//            db.StaffGraduateds.Remove(staffGraduated);
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
