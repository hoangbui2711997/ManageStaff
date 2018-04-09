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

        private static ManageStaffs getInstance;

        public static ManageStaffs GetInstance()
        {
            if (getInstance == null)
            {
                getInstance = new ManageStaffs();
            } else
            {

            }
            return getInstance;
        }

        private ManageStaffs()
        {
            Init();
        }

        public void Init()
        {
            DataTable dataOfStaff = DoWithSql.DoQuery("SELECT * FROM Faculty");
            DataTable dataOfStaff1 = DoWithSql.DoQuery("SELECT * FROM EducationField");
            DataTable dataOfStaff2 = DoWithSql.DoQuery("SELECT * FROM Academic");
            DataTable dataOfStaff3 = DoWithSql.DoQuery("SELECT * FROM Position");
            DataTable dataOfStaff4 = DoWithSql.DoQuery("SELECT * FROM Degree");
            DataTable dataOfStaff5 = DoWithSql.DoQuery("SELECT * FROM Staff");

            // Convert datatable of Staff to Staff List
            Adapters.Convert(dataOfStaff, "Faculty");
            Adapters.Convert(dataOfStaff1, "EducationField");
            Adapters.Convert(dataOfStaff2, "Academic");
            Adapters.Convert(dataOfStaff3, "Position");
            Adapters.Convert(dataOfStaff4, "Degree");
            Adapters.Convert(dataOfStaff5, "Staff");

            // After convert get data from Adapter
            Facultys = Adapters.faculties.ToList();
            EducationFields = Adapters.educationFields.ToList();
            Academics = Adapters.academics.ToList();
            Positions = Adapters.positions.ToList();
            Degrees = Adapters.degrees.ToList();
            Staffs = Adapters.staffs.ToList();
           
        }

        //public ManageStaffs()
        //{
        //    // Disable the database initializer in favor of using Code First Migrations.
        //    Database.SetInitializer<ManageStaffs>(null);
        //}
    }
}