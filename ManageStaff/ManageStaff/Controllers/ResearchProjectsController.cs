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
//    public class ResearchProjectsController : Controller
//    {
//        private ManageStaffs db = new ManageStaffs();

//        // GET: ResearchProjects
//        public ActionResult Index()
//        {
//            return View(db.ResearchProjects.ToList());
//        }

//        // GET: ResearchProjects/Details/5
//        public ActionResult Details(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ResearchProject researchProject = db.ResearchProjects.Find(id);
//            if (researchProject == null)
//            {
//                return HttpNotFound();
//            }
//            return View(researchProject);
//        }

//        // GET: ResearchProjects/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: ResearchProjects/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Code,Name,Level,Members,Time,State,Rank")] ResearchProject researchProject)
//        {
//            if (ModelState.IsValid)
//            {
//                db.ResearchProjects.Add(researchProject);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(researchProject);
//        }

//        // GET: ResearchProjects/Edit/5
//        public ActionResult Edit(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ResearchProject researchProject = db.ResearchProjects.Find(id);
//            if (researchProject == null)
//            {
//                return HttpNotFound();
//            }
//            return View(researchProject);
//        }

//        // POST: ResearchProjects/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Code,Name,Level,Members,Time,State,Rank")] ResearchProject researchProject)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(researchProject).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(researchProject);
//        }

//        // GET: ResearchProjects/Delete/5
//        public ActionResult Delete(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ResearchProject researchProject = db.ResearchProjects.Find(id);
//            if (researchProject == null)
//            {
//                return HttpNotFound();
//            }
//            return View(researchProject);
//        }

//        // POST: ResearchProjects/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(string id)
//        {
//            ResearchProject researchProject = db.ResearchProjects.Find(id);
//            db.ResearchProjects.Remove(researchProject);
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
