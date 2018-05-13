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
    public class StaffDocumentsController : Controller
    {
        //private ManageStaffs ManageStaffs.GetInstance() = new ManageStaffs();

        // GET: StaffDocuments
        public ActionResult Index()
        {
            var staffDocuments = ManageStaffs.GetInstance().StaffDocuments;
            return View(staffDocuments.ToList());
        }

        // GET: StaffDocuments/Details/5
        public ActionResult Details(string staffCode, string docCode)
        {
            if (staffCode == null || docCode == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffDocument staffDocument = ManageStaffs.GetInstance().StaffDocuments.Find(e => e.StaffCode == staffCode && e.DocumentCode == docCode);
            if (staffDocument == null)
            {
                return HttpNotFound();
            }
            return View(staffDocument);
        }

        //// GET: StaffDocuments/Create
        //public ActionResult Create()
        //{
        //    ViewBag.DocumentCode = new SelectList(ManageStaffs.GetInstance().Documents, "Code", "Name");
        //    ViewBag.StaffCode = new SelectList(ManageStaffs.GetInstance().Staffs, "Code", "Name");
        //    return View();
        //}

        //// POST: StaffDocuments/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "StaffCode,DocumentCode,PagesWrite,Thread")] StaffDocument staffDocument)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        ManageStaffs.GetInstance().StaffDocuments.Add(staffDocument);
        //        ManageStaffs.GetInstance().SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.DocumentCode = new SelectList(ManageStaffs.GetInstance().Documents, "Code", "Name", staffDocument.DocumentCode);
        //    ViewBag.StaffCode = new SelectList(ManageStaffs.GetInstance().Staffs, "Code", "Name", staffDocument.StaffCode);
        //    return View(staffDocument);
        //}

        // GET: StaffDocuments/Edit/5
        public ActionResult Edit(string staffCode, string docCode)
        {
            if (staffCode == null || docCode == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffDocument staffDocument = ManageStaffs.GetInstance()
                .StaffDocuments
                .Find(e => e.StaffCode == staffCode && e.DocumentCode == docCode);
            if (staffDocument == null)
            {
                return HttpNotFound();
            }
            ViewBag.DocumentCode = new SelectList(ManageStaffs.GetInstance().Documents, "Code", "Name", staffDocument.DocumentCode);
            ViewBag.StaffCode = new SelectList(ManageStaffs.GetInstance().Staffs, "Code", "Name", staffDocument.StaffCode);
            return View(staffDocument);
        }

        // POST: StaffDocuments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StaffCode,DocumentCode,PagesWrite,Thread")] StaffDocument staffDocument)
        {
            if (ModelState.IsValid)
            {
                //ManageStaffs.GetInstance().Entry(staffDocument).State = EntityState.Modified;
                //ManageStaffs.GetInstance().SaveChanges();
                TuongTacSQL.DoStaffDocument.DoUpdate(staffDocument);
                return RedirectToAction("Index");
            }
            ViewBag.DocumentCode = new SelectList(ManageStaffs.GetInstance().Documents, "Code", "Name", staffDocument.DocumentCode);
            ViewBag.StaffCode = new SelectList(ManageStaffs.GetInstance().Staffs, "Code", "Name", staffDocument.StaffCode);
            return View(staffDocument);
        }

        // GET: StaffDocuments/Delete/5
        public ActionResult Delete(string staffCode, string docCode)
        {
            if (staffCode == null || docCode == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffDocument staffDocument = ManageStaffs.GetInstance()
                .StaffDocuments
                .Find(e => e.StaffCode == staffCode && e.DocumentCode == docCode);
            if (staffDocument == null)
            {
                return HttpNotFound();
            }
            return View(staffDocument);
        }

        // POST: StaffDocuments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string staffCode, string docCode)
        {
            //StaffDocument staffDocument = ManageStaffs.GetInstance().StaffDocuments.Find(id);
            //ManageStaffs.GetInstance().StaffDocuments.Remove(staffDocument);
            //ManageStaffs.GetInstance().SaveChanges();
            TuongTacSQL.DoStaffDocument.DoDelete(staffCode, docCode);
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
