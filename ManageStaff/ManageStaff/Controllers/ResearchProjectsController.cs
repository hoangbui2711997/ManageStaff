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
    public class ResearchProjectsController : Controller
    {
        //private ManageStaffs ManageStaffs.GetInstance() = new ManageStaffs();

        // GET: ResearchProjects
        public ActionResult Index()
        {
            return View(ManageStaffs.GetInstance().ResearchProjects.ToList());
        }

        // GET: ResearchProjects/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResearchProject researchProject = ManageStaffs.GetInstance().ResearchProjects.Find(e => e.Code == id);
            if (researchProject == null)
            {
                return HttpNotFound();
            }
            return View(researchProject);
        }

        //// GET: ResearchProjects/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ResearchProjects/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Code,Name,Level,Members,Time,State,Rank")] ResearchProject researchProject)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        ManageStaffs.GetInstance().ResearchProjects.Add(researchProject);
        //        ManageStaffs.GetInstance().SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(researchProject);
        //}

        // GET: ResearchProjects/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResearchProject researchProject = ManageStaffs.GetInstance().ResearchProjects.Find(e => e.Code == id);
            if (researchProject == null)
            {
                return HttpNotFound();
            }
            return View(researchProject);
        }

        // POST: ResearchProjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Code,Name,Level,Members,Time,State,Rank")] ResearchProject researchProject)
        {
            if (ModelState.IsValid)
            {
                //ManageStaffs.GetInstance().Entry(researchProject).State = EntityState.Modified;
                //ManageStaffs.GetInstance().SaveChanges();
                TuongTacSQL.DoResearchProject.DoUpdate(researchProject);
                return RedirectToAction("Index");
            }
            return View(researchProject);
        }

        // GET: ResearchProjects/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResearchProject researchProject = ManageStaffs.GetInstance().ResearchProjects.Find(e => e.Code == id);
            if (researchProject == null)
            {
                return HttpNotFound();
            }
            return View(researchProject);
        }

        // POST: ResearchProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            //ResearchProject researchProject = ManageStaffs.GetInstance().ResearchProjects.Find(e => e.Code == id);
            //ManageStaffs.GetInstance().ResearchProjects.Remove(researchProject);
            //ManageStaffs.GetInstance().SaveChanges();
            TuongTacSQL.DoResearchProject.DoDelete(id);
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
