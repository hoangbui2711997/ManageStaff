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
    public class CoursesController : Controller
    {
        //private ManageStaffs ManageStaffs.GetInstance() = new ManageStaffs();

        // GET: Courses
        public ActionResult Index()
        {
            var courses = ManageStaffs.GetInstance().Courses;
            return View(courses.ToList());
        }

        // GET: Courses/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = ManageStaffs.GetInstance().Courses.Find(e => e.Code == id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        //// GET: Courses/Create
        //public ActionResult Create()
        //{
        //    ViewBag.StaffCode = new SelectList(ManageStaffs.GetInstance().Staffs, "Code", "Name");
        //    ViewBag.SubjectCode = new SelectList(ManageStaffs.GetInstance().Subjects, "Code", "SubjectName");
        //    return View();
        //}

        //// POST: Courses/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Code,StaffCode,SubjectCode,LectureRoom,NumberOfStudent")] Course course)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        ManageStaffs.GetInstance().Courses.Add(course);
        //        ManageStaffs.GetInstance().SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.StaffCode = new SelectList(ManageStaffs.GetInstance().Staffs, "Code", "Name", course.StaffCode);
        //    ViewBag.SubjectCode = new SelectList(ManageStaffs.GetInstance().Subjects, "Code", "SubjectName", course.SubjectCode);
        //    return View(course);
        //}

        // GET: Courses/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = ManageStaffs.GetInstance().Courses.Find(e => e.Code == id);
            if (course == null)
            {
                return HttpNotFound();
            }
            ViewBag.StaffCode = new SelectList(ManageStaffs.GetInstance().Staffs, "Code", "Name", course.StaffCode);
            ViewBag.SubjectCode = new SelectList(ManageStaffs.GetInstance().Subjects, "Code", "SubjectName", course.SubjectCode);
            return View(course);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Code,StaffCode,SubjectCode,LectureRoom,NumberOfStudent")] Course course)
        {
            if (ModelState.IsValid)
            {
                //ManageStaffs.GetInstance().Entry(course).State = EntityState.Modified;
                //ManageStaffs.GetInstance().SaveChanges();
                TuongTacSQL.DoCourse.DoUpdate(course);
                return RedirectToAction("Index");
            }
            ViewBag.StaffCode = new SelectList(ManageStaffs.GetInstance().Staffs, "Code", "Name", course.StaffCode);
            ViewBag.SubjectCode = new SelectList(ManageStaffs.GetInstance().Subjects, "Code", "SubjectName", course.SubjectCode);
            return View(course);
        }

        // GET: Courses/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = ManageStaffs.GetInstance().Courses.Find(e => e.Code == id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            //Course course = ManageStaffs.GetInstance().Courses.Find(id);
            //ManageStaffs.GetInstance().Courses.Remove(course);
            //ManageStaffs.GetInstance().SaveChanges();
            TuongTacSQL.DoCourse.DoDelete(id);
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
