using System.Linq;
using System.Web.Mvc;
using ManageStaff.Models;
using ManageStaff.Data;
using System.Net;
using System;
using System.Collections.Generic;

namespace ManageStaff.Controllers
{
    [Authorize]
    public class StaffsController : Controller
    {

        // GET: Staffs
        public ActionResult Index()
        {
            if(User == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //var staffs = ManageStaffs.GetInstance().Staffs.Include(s => s.Academic).Include(s => s.Degree).Include(s => s.EducationField).Include(s => s.Position);
            
            return View(ManageStaffs.GetInstance().Staffs);
        }

        public JsonResult TestSearch(string bomon)
        {
            List<Staff> staffs = ManageStaffs.GetInstance().Staffs.FindAll(

                e =>  (e.EducationField!= null && e.EducationField.Name.Contains(bomon)));
            return Json(staffs, JsonRequestBehavior.AllowGet);
        }

        // GET: Staffs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Staff staff = ManageStaffs.GetInstance().Staffs.Find(e => e.Code == id);

            if (staff == null)
            {
                return HttpNotFound();
            }
            return View(staff);
        }

        // GET: Staffs/Create
        public ActionResult Create()
        {
            ViewBag.AcademicCode = new SelectList(ManageStaffs.GetInstance().Academics, "Code", "Name");
            ViewBag.DegreeCode = new SelectList(ManageStaffs.GetInstance().Degrees, "Code", "Name");
            ViewBag.EducationFieldCode = new SelectList(ManageStaffs.GetInstance().EducationFields, "Code", "Name");
            ViewBag.PositionCode = new SelectList(ManageStaffs.GetInstance().Positions, "Code", "Name");
            return View();
        }

        // POST: Staffs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Code,Name,DegreeCode,AcademicCode,PositionCode,EducationFieldCode,PhoneNumber,Email,ResearchInterests,ImageStaff")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                //ManageStaffs.GetInstance().SaveChanges();
                TuongTacSQL.DoStaff.DoInsert(staff);
                return RedirectToAction("Index");
            }

            ViewBag.AcademicCode = new SelectList(ManageStaffs.GetInstance().Academics, "Code", "Name", staff.AcademicCode);
            ViewBag.DegreeCode = new SelectList(ManageStaffs.GetInstance().Degrees, "Code", "Name", staff.DegreeCode);
            ViewBag.EducationFieldCode = new SelectList(ManageStaffs.GetInstance().EducationFields, "Code", "Name", staff.EducationFieldCode);
            ViewBag.PositionCode = new SelectList(ManageStaffs.GetInstance().Positions, "Code", "Name", staff.PositionCode);

            return View(staff);
        }

        // GET: Staffs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff staff = ManageStaffs.GetInstance().Staffs.Find(e => e.Code == id);
            if (staff == null)
            {
                return HttpNotFound();
            }
            ViewBag.AcademicCode = new SelectList(ManageStaffs.GetInstance().Academics, "Code", "Name", staff.AcademicCode);
            ViewBag.DegreeCode = new SelectList(ManageStaffs.GetInstance().Degrees, "Code", "Name", staff.DegreeCode);
            ViewBag.EducationFieldCode = new SelectList(ManageStaffs.GetInstance().EducationFields, "Code", "Name", staff.EducationFieldCode);
            ViewBag.PositionCode = new SelectList(ManageStaffs.GetInstance().Positions, "Code", "Name", staff.PositionCode);
            
            return View(staff);
        }

        // POST: Staffs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Code,Name,DegreeCode,AcademicCode,PositionCode,EducationFieldCode,PhoneNumber,Email,ResearchInterests,ImageStaff")] Staff staff)
        {
            staff.SortBio = "";
            if (ModelState.IsValid)
            {
                //ManageStaffs.GetInstance().Entry(staff).State = EntityState.Modified;
                //ManageStaffs.GetInstance().SaveChanges();
                //var staffs = ManageStaffs.GetInstance().Staffs.FirstOrDefault(e => e.Code == staff.Code);

                TuongTacSQL.DoStaff.DoUpdate(staff);
                return RedirectToAction("Index");
            }
            ViewBag.AcademicCode = new SelectList(ManageStaffs.GetInstance().Academics, "Code", "Name", staff.AcademicCode);
            ViewBag.DegreeCode = new SelectList(ManageStaffs.GetInstance().Degrees, "Code", "Name", staff.DegreeCode);
            ViewBag.EducationFieldCode = new SelectList(ManageStaffs.GetInstance().EducationFields, "Code", "Name", staff.EducationFieldCode);
            ViewBag.PositionCode = new SelectList(ManageStaffs.GetInstance().Positions, "Code", "Name", staff.PositionCode);
            return View(staff);
        }

        // GET: Staffs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff staff = ManageStaffs.GetInstance().Staffs.Find(e => e.Code == id);
            if (staff == null)
            {
                return HttpNotFound();
            }
            return View(staff);
        }

        // POST: Staffs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Staff staff = ManageStaffs.GetInstance().Staffs.Find(e => e.Code == id);
            //ManageStaffs.GetInstance().SaveChanges();

            TuongTacSQL.DoStaff.DoDelete(id);
            return RedirectToAction("Index");
        }

        public JsonResult test()
        {
            var data = ManageStaffs.GetInstance().Staffs;
            return Json(data,JsonRequestBehavior.AllowGet);
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
