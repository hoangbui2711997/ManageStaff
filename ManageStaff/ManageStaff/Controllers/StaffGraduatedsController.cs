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
    public class StaffGraduatedsController : Controller
    {
        //private ManageStaffs ManageStaffs.GetInstance() = new ManageStaffs();

        // GET: StaffGraduateds
        public ActionResult Index()
        {
            var staffGraduateds = ManageStaffs.GetInstance().StaffGraduateds;
            return View(staffGraduateds.ToList());
        }

        // GET: StaffGraduateds/Details/5
        public ActionResult Details(string staffCode, string graduatingCode)
        {
            if (staffCode == null || graduatingCode == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffGraduated staffGraduated = ManageStaffs.GetInstance().StaffGraduateds.Find(e => e.StaffCode == staffCode && e.GraduatedCode == graduatingCode);
            if (staffGraduated == null)
            {
                return HttpNotFound();
            }
            return View(staffGraduated);
        }

        //// GET: StaffGraduateds/Create
        //public ActionResult Create()
        //{
        //    ViewBag.GraduatedCode = new SelectList(ManageStaffs.GetInstance().Graduatings, "Code", "Name");
        //    ViewBag.StaffCode = new SelectList(ManageStaffs.GetInstance().Staffs, "Code", "Name");
        //    return View();
        //}

        //// POST: StaffGraduateds/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "StaffCode,GraduatedCode,Descript")] StaffGraduated staffGraduated)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //ManageStaffs.GetInstance().StaffGraduateds.Add(staffGraduated);
        //        //ManageStaffs.GetInstance().SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.GraduatedCode = new SelectList(ManageStaffs.GetInstance().Graduatings, "Code", "Name", staffGraduated.GraduatedCode);
        //    ViewBag.StaffCode = new SelectList(ManageStaffs.GetInstance().Staffs, "Code", "Name", staffGraduated.StaffCode);
        //    return View(staffGraduated);
        //}

        // GET: StaffGraduateds/Edit/5
        public ActionResult Edit(string staffCode, string graduatingCode)
        {
            if (staffCode == null || graduatingCode == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffGraduated staffGraduated = ManageStaffs.GetInstance().StaffGraduateds.Find(e => e.StaffCode == staffCode && e.GraduatedCode == graduatingCode);
            if (staffGraduated == null)
            {
                return HttpNotFound();
            }
            ViewBag.GraduatedCode = new SelectList(ManageStaffs.GetInstance().Graduatings, "Code", "Name", staffGraduated.GraduatedCode);
            ViewBag.StaffCode = new SelectList(ManageStaffs.GetInstance().Staffs, "Code", "Name", staffGraduated.StaffCode);
            return View(staffGraduated);
        }

        // POST: StaffGraduateds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StaffCode,GraduatedCode,Descript")] StaffGraduated staffGraduated)
        {
            if (ModelState.IsValid)
            {
                //ManageStaffs.GetInstance().Entry(staffGraduated).State = EntityState.Modified;
                //ManageStaffs.GetInstance().SaveChanges();
                TuongTacSQL.DoStaffGraduated.DoUpdate(staffGraduated);
                return RedirectToAction("Index");
            }
            ViewBag.GraduatedCode = new SelectList(ManageStaffs.GetInstance().Graduatings, "Code", "Name", staffGraduated.GraduatedCode);
            ViewBag.StaffCode = new SelectList(ManageStaffs.GetInstance().Staffs, "Code", "Name", staffGraduated.StaffCode);
            return View(staffGraduated);
        }

        // GET: StaffGraduateds/Delete/5
        public ActionResult Delete(string staffCode, string graduatingCode)
        {
            if (staffCode == null || graduatingCode == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffGraduated staffGraduated = ManageStaffs.GetInstance().StaffGraduateds.Find(e => e.StaffCode == staffCode && e.GraduatedCode == graduatingCode);
            if (staffGraduated == null)
            {
                return HttpNotFound();
            }
            return View(staffGraduated);
        }

        // POST: StaffGraduateds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string staffCode, string graduatingCode)
        {
            //StaffGraduated staffGraduated = ManageStaffs.GetInstance().StaffGraduateds.Find(id);
            //ManageStaffs.GetInstance().StaffGraduateds.Remove(staffGraduated);
            //ManageStaffs.GetInstance().SaveChanges();
            TuongTacSQL.DoStaffGraduated.DoDelete(staffCode, graduatingCode);
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
