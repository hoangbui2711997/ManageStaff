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
    public class StaffProjectResearchesController : Controller
    {
        private ManageStaffs db = new ManageStaffs();

        // GET: StaffProjectResearches
        public ActionResult Index()
        {
            var staffProjectResearchs = db.StaffProjectResearchs.Include(s => s.ResearchProject).Include(s => s.Staff);
            return View(staffProjectResearchs.ToList());
        }

        // GET: StaffProjectResearches/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffProjectResearch staffProjectResearch = db.StaffProjectResearchs.Find(id);
            if (staffProjectResearch == null)
            {
                return HttpNotFound();
            }
            return View(staffProjectResearch);
        }

        // GET: StaffProjectResearches/Create
        public ActionResult Create()
        {
            ViewBag.ResearchProjectCode = new SelectList(db.ResearchProjects, "Code", "Name");
            ViewBag.StaffCode = new SelectList(db.Staffs, "Code", "Name");
            return View();
        }

        // POST: StaffProjectResearches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StaffCode,ResearchProjectCode")] StaffProjectResearch staffProjectResearch)
        {
            if (ModelState.IsValid)
            {
                db.StaffProjectResearchs.Add(staffProjectResearch);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ResearchProjectCode = new SelectList(db.ResearchProjects, "Code", "Name", staffProjectResearch.ResearchProjectCode);
            ViewBag.StaffCode = new SelectList(db.Staffs, "Code", "Name", staffProjectResearch.StaffCode);
            return View(staffProjectResearch);
        }

        // GET: StaffProjectResearches/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffProjectResearch staffProjectResearch = db.StaffProjectResearchs.Find(id);
            if (staffProjectResearch == null)
            {
                return HttpNotFound();
            }
            ViewBag.ResearchProjectCode = new SelectList(db.ResearchProjects, "Code", "Name", staffProjectResearch.ResearchProjectCode);
            ViewBag.StaffCode = new SelectList(db.Staffs, "Code", "Name", staffProjectResearch.StaffCode);
            return View(staffProjectResearch);
        }

        // POST: StaffProjectResearches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StaffCode,ResearchProjectCode")] StaffProjectResearch staffProjectResearch)
        {
            if (ModelState.IsValid)
            {
                db.Entry(staffProjectResearch).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ResearchProjectCode = new SelectList(db.ResearchProjects, "Code", "Name", staffProjectResearch.ResearchProjectCode);
            ViewBag.StaffCode = new SelectList(db.Staffs, "Code", "Name", staffProjectResearch.StaffCode);
            return View(staffProjectResearch);
        }

        // GET: StaffProjectResearches/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffProjectResearch staffProjectResearch = db.StaffProjectResearchs.Find(id);
            if (staffProjectResearch == null)
            {
                return HttpNotFound();
            }
            return View(staffProjectResearch);
        }

        // POST: StaffProjectResearches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            StaffProjectResearch staffProjectResearch = db.StaffProjectResearchs.Find(id);
            db.StaffProjectResearchs.Remove(staffProjectResearch);
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
