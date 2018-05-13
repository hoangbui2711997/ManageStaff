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
    public class AcademicsController : Controller
    {
        
        // GET: Academics
        public ActionResult Index()
        {
            return View(ManageStaffs.GetInstance().Academics.ToList());
        }

        // GET: Academics/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Academic academic = ManageStaffs.GetInstance().Academics.Find(e => e.Code == id);
            if (academic == null)
            {
                return HttpNotFound();
            }
            return View(academic);
        }

        //// GET: Academics/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Academics/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Code,Name,Codeview")] Academic academic)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Academics.Add(academic);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(academic);
        //}

        // GET: Academics/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Academic academic = ManageStaffs.GetInstance().Academics.Find(e => e.Code == id);
            if (academic == null)
            {
                return HttpNotFound();
            }
            return View(academic);
        }

        // POST: Academics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Code,Name,Codeview")] Academic academic)
        {
            if (ModelState.IsValid)
            {
                TuongTacSQL.DoAcademic.DoUpdate(academic);
                //db.Entry(academic).State = EntityState.Modified;
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(academic);
        }

        // GET: Academics/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Academic academic = ManageStaffs.GetInstance().Academics.Find(e => e.Code == id);
            if (academic == null)
            {
                return HttpNotFound();
            }
            return View(academic);
        }

        // POST: Academics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            //Academic academic = db.Academics.Find(e => e.Code);
            //db.Academics.Remove(academic);
            //db.SaveChanges();

            TuongTacSQL.DoAcademic.DoDelete(id);
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
