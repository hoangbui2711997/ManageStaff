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
    public class DocumentsController : Controller
    {
        //private ManageStaffs ManageStaffs.GetInstance() = new ManageStaffs();

        // GET: Documents
        public ActionResult Index()
        {
            return View(ManageStaffs.GetInstance().Documents.ToList());
        }

        // GET: Documents/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Document document = ManageStaffs.GetInstance().Documents.Find(e => e.Code == id);
            if (document == null)
            {
                return HttpNotFound();
            }
            return View(document);
        }

        //// GET: Documents/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Documents/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Code,Name,DateRelease,Link")] Document document)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        ManageStaffs.GetInstance().Documents.Add(document);
        //        ManageStaffs.GetInstance().SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(document);
        //}

        // GET: Documents/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Document document = ManageStaffs.GetInstance().Documents.Find(e => e.Code == id);
            if (document == null)
            {
                return HttpNotFound();
            }
            return View(document);
        }

        // POST: Documents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Code,Name,DateRelease,Link")] Document document)
        {
            if (ModelState.IsValid)
            {
                //ManageStaffs.GetInstance().Entry(document).State = EntityState.Modified;
                //ManageStaffs.GetInstance().SaveChanges();
                TuongTacSQL.DoDocument.DoUpdate(document);
                return RedirectToAction("Index");
            }
            return View(document);
        }

        // GET: Documents/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Document document = ManageStaffs.GetInstance().Documents.Find(e => e.Code == id);
            if (document == null)
            {
                return HttpNotFound();
            }
            return View(document);
        }

        // POST: Documents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            //Document document = ManageStaffs.GetInstance().Documents.Find(e => e.Code == id);
            //ManageStaffs.GetInstance().Documents.Remove(document);
            //ManageStaffs.GetInstance().SaveChanges();
            TuongTacSQL.DoDocument.DoDelete(id);
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
