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
    public class PositionsController : Controller
    {
        

        // GET: Positions
        public ActionResult Index()
        {
            return View(ManageStaffs.GetInstance().Positions.ToList());
        }

        // GET: Positions/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Position position = ManageStaffs.GetInstance().Positions.Find(e => e.Code == id);
            if (position == null)
            {
                return HttpNotFound();
            }
            return View(position);
        }

        //// GET: Positions/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Positions/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Code,Name,CodeView")] Position position)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        ManageStaffs.GetInstance().Positions.Add(position);
        //        ManageStaffs.GetInstance().SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(position);
        //}

        // GET: Positions/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Position position = ManageStaffs.GetInstance().Positions.Find(e => e.Code == id);
            if (position == null)
            {
                return HttpNotFound();
            }
            return View(position);
        }

        // POST: Positions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Code,Name,CodeView")] Position position)
        {
            if (ModelState.IsValid)
            {
                //ManageStaffs.GetInstance().Entry(position).State = EntityState.Modified;
                //ManageStaffs.GetInstance().SaveChanges();
                TuongTacSQL.DoPosition.DoUpdate(position);
                return RedirectToAction("Index");
            }
            return View(position);
        }

        // GET: Positions/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Position position = ManageStaffs.GetInstance().Positions.Find(e => e.Code == id);
            if (position == null)
            {
                return HttpNotFound();
            }
            return View(position);
        }

        // POST: Positions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            //Position position = ManageStaffs.GetInstance().Positions.Find(e => e.Code == id);
            //ManageStaffs.GetInstance().Positions.Remove(position);
            //ManageStaffs.GetInstance().SaveChanges();
            TuongTacSQL.DoPosition.DoDelete(id);
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
