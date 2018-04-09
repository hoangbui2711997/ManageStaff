using ManageStaff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ManageStaff.Data
{
    public class ManageStaffs
    {
        public List<Academic> Academics { get; set; }
        public List<Course> Courses { get; set; }
        public List<Degree> Degrees { get; set; }
        public List<Document> Documents { get; set; }
        public List<EducationField> EducationFields { get; set; }
        public List<Faculty> Facultys { get; set; }
        //publiListmageStaff> ImageStaffs { get; set; }
        public List<Position> Positions { get; set; }
        public List<ResearchProject> ResearchProjects { get; set; }
        public List<Staff> Staffs { get; set; }
        public List<StaffDocument> StaffDocuments { get; set; }
        public List<StaffGraduated> StaffGraduateds { get; set; }
        public List<StaffProjectResearch> StaffProjectResearchs { get; set; }
        public List<Subject> Subjects { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<StaffProjectResearch>().HasKey(c => new { c.StaffCode, c.ResearchProjectCode });
        //    modelBuilder.Entity<StaffDocument>().HasKey(c => new { c.StaffCode, c.DocumentCode });
        //    modelBuilder.Entity<StaffGraduated>().HasKey(c => new { c.StaffCode, c.GraduatedCode });
        //    //base.OnModelCreating(modelBuilder);
        //}

        public DataTable Graduatings { get; set; }

        public ManageStaffs()
        {
            Init();
            

        }

        public void Init()
        {
            DataTable dataOfStaff = DoWithSql.DoQuery("SELECT * FROM Staff");
            // Convert datatable of Staff to Staff List
            Adapters.Convert(dataOfStaff, "Staff");
            // After convert get data from Adapter
            Staffs = Adapters.staffs;

        }

        //public ManageStaffs()
        //{
        //    // Disable the database initializer in favor of using Code First Migrations.
        //    Database.SetInitializer<ManageStaffs>(null);
        //}
    }
}