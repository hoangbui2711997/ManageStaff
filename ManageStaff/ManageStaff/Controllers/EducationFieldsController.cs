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
    public class EducationFieldsController : Controller
    {
        //private ManageStaffs ManageStaffs.GetInstance() = new ManageStaffs();

        // GET: EducationFields
        public ActionResult Index()
        {
            var educationFields = ManageStaffs.GetInstance().EducationFields;
            return View(educationFields.ToList());
        }

        // GET: EducationFields/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EducationField educationField = ManageStaffs.GetInstance().EducationFields.Find(e => e.Code == id);
            if (educationField == null)
            {
                return HttpNotFound();
            }
            return View(educationField);
        }

        // GET: EducationFields/Create
        public ActionResult Create()
        {
            ViewBag.FalcutyCode = new SelectList(ManageStaffs.GetInstance().Facultys, "Code", "FacultyName");
            return View();
        }

        // POST: EducationFields/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Code,Name,FalcutyCode,CodeView")] EducationField educationField)
        {
            if (ModelState.IsValid)
            {
                //ManageStaffs.GetInstance().EducationFields.Add(educationField);
                //ManageStaffs.GetInstance().SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FalcutyCode = new SelectList(ManageStaffs.GetInstance().Facultys, "Code", "FacultyName", educationField.FalcutyCode);
            return View(educationField);
        }

        // GET: EducationFields/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EducationField educationField = ManageStaffs.GetInstance().EducationFields.Find(e => e.Code == id);
            if (educationField == null)
            {
                return HttpNotFound();
            }
            ViewBag.FalcutyCode = new SelectList(ManageStaffs.GetInstance().Facultys, "Code", "FacultyName", educationField.FalcutyCode);
            return View(educationField);
        }

        // POST: EducationFields/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Code,Name,FalcutyCode,CodeView")] EducationField educationField)
        {
            if (ModelState.IsValid)
            {
                //ManageStaffs.GetInstance().Entry(educationField).State = EntityState.Modified;
                //ManageStaffs.GetInstance().SaveChanges();
                TuongTacSQL.DoEducationField.DoUpdate(educationField);
                return RedirectToAction("Index");
            }
            ViewBag.FalcutyCode = new SelectList(ManageStaffs.GetInstance().Facultys, "Code", "FacultyName", educationField.FalcutyCode);
            return View(educationField);
        }

        // GET: EducationFields/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EducationField educationField = ManageStaffs.GetInstance().EducationFields.Find(e => e.Code == id);
            if (educationField == null)
            {
                return HttpNotFound();
            }
            return View(educationField);
        }

        // POST: EducationFields/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            //EducationField educationField = ManageStaffs.GetInstance().EducationFields.Find(id);
            //ManageStaffs.GetInstance().EducationFields.Remove(educationField);
            //ManageStaffs.GetInstance().SaveChanges();
            TuongTacSQL.DoEducationField.DoDelete(id);
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
