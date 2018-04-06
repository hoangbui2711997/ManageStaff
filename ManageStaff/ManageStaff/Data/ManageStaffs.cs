using ManageStaff.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ManageStaff.Data
{
    public class ManageStaffs : DbContext
    {
        public DbSet<Academic> Academics { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<EducationField> EducationFields { get; set; }
        public DbSet<Faculty> Facultys { get; set; }
        //public DbSet<ImageStaff> ImageStaffs { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<ResearchProject> ResearchProjects { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<StaffDocument> StaffDocuments { get; set; }
        public DbSet<StaffGraduated> StaffGraduateds { get; set; }
        public DbSet<StaffProjectResearch> StaffProjectResearchs { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StaffProjectResearch>().HasKey(c => new { c.StaffCode, c.ResearchProjectCode });
            modelBuilder.Entity<StaffDocument>().HasKey(c => new { c.StaffCode, c.DocumentCode });
            modelBuilder.Entity<StaffGraduated>().HasKey(c => new { c.StaffCode, c.GraduatedCode });
            //base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<ManageStaff.Models.Graduating> Graduatings { get; set; }



        //public ManageStaffs()
        //{
        //    // Disable the database initializer in favor of using Code First Migrations.
        //    Database.SetInitializer<ManageStaffs>(null);
        //}
    }
}