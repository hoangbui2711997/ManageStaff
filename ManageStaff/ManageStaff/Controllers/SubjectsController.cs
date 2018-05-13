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
    public class SubjectsController : Controller
    {
        //private ManageStaffs ManageStaffs.GetInstance() = new ManageStaffs();

        // GET: Subjects
        public ActionResult Index()
        {
            return View(ManageStaffs.GetInstance().Subjects.ToList());
        }

        // GET: Subjects/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject subject = ManageStaffs.GetInstance().Subjects.Find(e => e.Code == id);
            if (subject == null)
            {
                return HttpNotFound();
            }
            return View(subject);
        }

        //// GET: Subjects/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Subjects/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Code,SubjectName,NumberOfCredit,NumberOfLesson,NumberOfTheory,NumberOfExercise,NumberOfDiscussion,NumberOfPractice,ExamForm,CodeView")] Subject subject)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        ManageStaffs.GetInstance().Subjects.Add(subject);
        //        ManageStaffs.GetInstance().SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(subject);
        //}

        // GET: Subjects/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject subject = ManageStaffs.GetInstance().Subjects.Find(e => e.Code == id);
            if (subject == null)
            {
                return HttpNotFound();
            }
            return View(subject);
        }

        // POST: Subjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Code,SubjectName,NumberOfCredit,NumberOfLesson,NumberOfTheory,NumberOfExercise,NumberOfDiscussion,NumberOfPractice,ExamForm,CodeView")] Subject subject)
        {
            if (ModelState.IsValid)
            {
                //ManageStaffs.GetInstance().Entry(subject).State = EntityState.Modified;
                //ManageStaffs.GetInstance().SaveChanges();
                TuongTacSQL.DoSubject.DoUpdate(subject);
                return RedirectToAction("Index");
            }
            return View(subject);
        }

        // GET: Subjects/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject subject = ManageStaffs.GetInstance().Subjects.Find(e => e.Code == id);
            if (subject == null)
            {
                return HttpNotFound();
            }
            return View(subject);
        }

        // POST: Subjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            //Subject subject = ManageStaffs.GetInstance().Subjects.Find(id);
            //ManageStaffs.GetInstance().Subjects.Remove(subject);
            //ManageStaffs.GetInstance().SaveChanges();
            TuongTacSQL.DoSubject.DoDelete(id);
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
