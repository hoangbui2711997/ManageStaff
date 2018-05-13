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
        //private ManageStaffs ManageStaffs.GetInstance() = new ManageStaffs();

        // GET: StaffProjectResearches
        public ActionResult Index()
        {
            var staffProjectResearchs = ManageStaffs.GetInstance().StaffProjectResearchs;
            return View(staffProjectResearchs.ToList());
        }

        // GET: StaffProjectResearches/Details/5
        public ActionResult Details(string staffCode, string projectResearchCode)
        {
            if (staffCode == null && projectResearchCode == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffProjectResearch staffProjectResearch = ManageStaffs.GetInstance()
                .StaffProjectResearchs
                .Find(e => e.StaffCode == staffCode && e.ResearchProjectCode == projectResearchCode);
            if (staffProjectResearch == null)
            {
                return HttpNotFound();
            }
            return View(staffProjectResearch);
        }

        //// GET: StaffProjectResearches/Create
        //public ActionResult Create()
        //{
        //    ViewBag.ResearchProjectCode = new SelectList(ManageStaffs.GetInstance().ResearchProjects, "Code", "Name");
        //    ViewBag.StaffCode = new SelectList(ManageStaffs.GetInstance().Staffs, "Code", "Name");
        //    return View();
        //}

        //// POST: StaffProjectResearches/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "StaffCode,ResearchProjectCode")] StaffProjectResearch staffProjectResearch)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        ManageStaffs.GetInstance().StaffProjectResearchs.Add(staffProjectResearch);
        //        ManageStaffs.GetInstance().SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.ResearchProjectCode = new SelectList(ManageStaffs.GetInstance().ResearchProjects, "Code", "Name", staffProjectResearch.ResearchProjectCode);
        //    ViewBag.StaffCode = new SelectList(ManageStaffs.GetInstance().Staffs, "Code", "Name", staffProjectResearch.StaffCode);
        //    return View(staffProjectResearch);
        //}

        // GET: StaffProjectResearches/Edit/5
        public ActionResult Edit(string staffCode, string projectResearchCode)
        {
            if (staffCode == null || projectResearchCode == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffProjectResearch staffProjectResearch = ManageStaffs.GetInstance().StaffProjectResearchs.Find(e => e.StaffCode == staffCode && e.ResearchProjectCode == projectResearchCode);
            if (staffProjectResearch == null)
            {
                return HttpNotFound();
            }
            ViewBag.ResearchProjectCode = new SelectList(ManageStaffs.GetInstance().ResearchProjects, "Code", "Name", staffProjectResearch.ResearchProjectCode);
            ViewBag.StaffCode = new SelectList(ManageStaffs.GetInstance().Staffs, "Code", "Name", staffProjectResearch.StaffCode);
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
                //ManageStaffs.GetInstance().Entry(staffProjectResearch).State = EntityState.Modified;
                //ManageStaffs.GetInstance().SaveChanges();
                TuongTacSQL.DoStaffProjectResearch.DoUpdate(staffProjectResearch);
                return RedirectToAction("Index");
            }
            ViewBag.ResearchProjectCode = new SelectList(ManageStaffs.GetInstance().ResearchProjects, "Code", "Name", staffProjectResearch.ResearchProjectCode);
            ViewBag.StaffCode = new SelectList(ManageStaffs.GetInstance().Staffs, "Code", "Name", staffProjectResearch.StaffCode);
            return View(staffProjectResearch);
        }

        // GET: StaffProjectResearches/Delete/5
        public ActionResult Delete(string staffCode, string projectResearchCode)
        {
            if (staffCode == null || projectResearchCode == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffProjectResearch staffProjectResearch = ManageStaffs.GetInstance()
                .StaffProjectResearchs
                .Find(e => e.StaffCode == staffCode && e.ResearchProjectCode == projectResearchCode);
            if (staffProjectResearch == null)
            {
                return HttpNotFound();
            }
            return View(staffProjectResearch);
        }

        // POST: StaffProjectResearches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string staffCode, string projectResearchCode)
        {
            //StaffProjectResearch staffProjectResearch = ManageStaffs.GetInstance().StaffProjectResearchs.Find(id);
            //ManageStaffs.GetInstance().StaffProjectResearchs.Remove(staffProjectResearch);
            //ManageStaffs.GetInstance().SaveChanges();
            TuongTacSQL.DoStaffProjectResearch.DoDelete(staffCode, projectResearchCode);
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        ManageStaffs.GetInstance().Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
