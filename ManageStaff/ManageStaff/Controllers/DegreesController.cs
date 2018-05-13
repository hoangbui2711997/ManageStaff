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
    public class DegreesController : Controller
    {
        //private ManageStaffs ManageStaffs.GetInstance() = ManageStaffs.GetInstance();

        // GET: Degrees
        public ActionResult Index()
        {
            return View(ManageStaffs.GetInstance().Degrees.ToList());
        }

        // GET: Degrees/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Degree degree = ManageStaffs.GetInstance().Degrees.Find(e => e.Code == id);
            if (degree == null)
            {
                return HttpNotFound();
            }
            return View(degree);
        }

        //// GET: Degrees/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Degrees/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Code,Name,CodeView")] Degree degree)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        ManageStaffs.GetInstance().Degrees.Add(degree);

        //        //ManageStaffs.GetInstance().SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(degree);
        //}

        // GET: Degrees/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Degree degree = ManageStaffs.GetInstance().Degrees.Find(e => e.Code == id);
            if (degree == null)
            {
                return HttpNotFound();
            }
            return View(degree);
        }

        // POST: Degrees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Code,Name,CodeView")] Degree degree)
        {
            if (ModelState.IsValid)
            {
                //ManageStaffs.GetInstance().Entry(degree).State = EntityState.Modified;
                //ManageStaffs.GetInstance().SaveChanges();
                TuongTacSQL.DoDegree.DoUpdate(degree);
                return RedirectToAction("Index");
            }
            return View(degree);
        }

        // GET: Degrees/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Degree degree = ManageStaffs.GetInstance().Degrees.Find(e => e.Code == id);
            if (degree == null)
            {
                return HttpNotFound();
            }
            return View(degree);
        }

        // POST: Degrees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            //Degree degree = ManageStaffs.GetInstance().Degrees.Find(id);
            //ManageStaffs.GetInstance().Degrees.Remove(degree);
            //ManageStaffs.GetInstance().SaveChanges();
            TuongTacSQL.DoDegree.DoDelete(id);
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
