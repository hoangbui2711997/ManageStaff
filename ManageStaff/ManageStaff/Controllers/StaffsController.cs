using System.Linq;
using System.Web.Mvc;
using ManageStaff.Models;
using ManageStaff.Data;
using System.Net;

namespace ManageStaff.Controllers
{
    public class StaffsController : Controller
    {
        private ManageStaffs db = ManageStaffs.GetInstance();

        // GET: Staffs
        public ActionResult Index()
        {
            if(User == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //var staffs = db.Staffs.Include(s => s.Academic).Include(s => s.Degree).Include(s => s.EducationField).Include(s => s.Position);
            
            return View(db.Staffs);
        }

        // GET: Staffs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Staff staff = db.Staffs.Find(e => e.Code == id);

            if (staff == null)
            {
                return HttpNotFound();
            }
            return View(staff);
        }

        // GET: Staffs/Create
        public ActionResult Create()
        {
            ViewBag.AcademicCode = new SelectList(db.Academics, "Code", "Name");
            ViewBag.DegreeCode = new SelectList(db.Degrees, "Code", "Name");
            ViewBag.EducationFieldCode = new SelectList(db.EducationFields, "Code", "Name");
            ViewBag.PositionCode = new SelectList(db.Positions, "Code", "Name");
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
                db.Staffs.Add(staff);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AcademicCode = new SelectList(db.Academics, "Code", "Name", staff.AcademicCode);
            ViewBag.DegreeCode = new SelectList(db.Degrees, "Code", "Name", staff.DegreeCode);
            ViewBag.EducationFieldCode = new SelectList(db.EducationFields, "Code", "Name", staff.EducationFieldCode);
            ViewBag.PositionCode = new SelectList(db.Positions, "Code", "Name", staff.PositionCode);
            return View(staff);
        }

        // GET: Staffs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff staff = db.Staffs.Find(e => e.Code == id);
            if (staff == null)
            {
                return HttpNotFound();
            }
            ViewBag.AcademicCode = new SelectList(db.Academics, "Code", "Name", staff.AcademicCode);
            ViewBag.DegreeCode = new SelectList(db.Degrees, "Code", "Name", staff.DegreeCode);
            ViewBag.EducationFieldCode = new SelectList(db.EducationFields, "Code", "Name", staff.EducationFieldCode);
            ViewBag.PositionCode = new SelectList(db.Positions, "Code", "Name", staff.PositionCode);
            return View(staff);
        }

        // POST: Staffs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Code,Name,DegreeCode,AcademicCode,PositionCode,EducationFieldCode,PhoneNumber,Email,ResearchInterests,ImageStaff")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(staff).State = EntityState.Modified;
                //db.SaveChanges();
                var staffs = db.Staffs.FirstOrDefault(e => e.Code == staff.Code);
                staffs = staff;

                return RedirectToAction("Index");
            }
            ViewBag.AcademicCode = new SelectList(db.Academics, "Code", "Name", staff.AcademicCode);
            ViewBag.DegreeCode = new SelectList(db.Degrees, "Code", "Name", staff.DegreeCode);
            ViewBag.EducationFieldCode = new SelectList(db.EducationFields, "Code", "Name", staff.EducationFieldCode);
            ViewBag.PositionCode = new SelectList(db.Positions, "Code", "Name", staff.PositionCode);
            return View(staff);
        }

        // GET: Staffs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff staff = db.Staffs.Find(e => e.Code == id);
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
            Staff staff = db.Staffs.Find(e => e.Code == id);
            db.Staffs.Remove(staff);
            //db.SaveChanges();
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
