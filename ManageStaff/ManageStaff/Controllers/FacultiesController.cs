﻿//using System;
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
//    public class FacultiesController : Controller
//    {
//        private ManageStaffs db = new ManageStaffs();

//        // GET: Faculties
//        public ActionResult Index()
//        {
//            return View(db.Facultys.ToList());
//        }

//        // GET: Faculties/Details/5
//        public ActionResult Details(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Faculty faculty = db.Facultys.Find(id);
//            if (faculty == null)
//            {
//                return HttpNotFound();
//            }
//            return View(faculty);
//        }

//        // GET: Faculties/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Faculties/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Code,FacultyName,FacultyPhone,Email")] Faculty faculty)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Facultys.Add(faculty);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(faculty);
//        }

//        // GET: Faculties/Edit/5
//        public ActionResult Edit(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Faculty faculty = db.Facultys.Find(id);
//            if (faculty == null)
//            {
//                return HttpNotFound();
//            }
//            return View(faculty);
//        }

//        // POST: Faculties/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Code,FacultyName,FacultyPhone,Email")] Faculty faculty)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(faculty).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(faculty);
//        }

//        // GET: Faculties/Delete/5
//        public ActionResult Delete(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Faculty faculty = db.Facultys.Find(id);
//            if (faculty == null)
//            {
//                return HttpNotFound();
//            }
//            return View(faculty);
//        }

//        // POST: Faculties/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(string id)
//        {
//            Faculty faculty = db.Facultys.Find(id);
//            db.Facultys.Remove(faculty);
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
