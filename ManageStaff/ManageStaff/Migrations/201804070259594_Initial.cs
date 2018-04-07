namespace ManageStaff.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Academics",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 50),
                        Codeview = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 50),
                        DegreeCode = c.String(nullable: false, maxLength: 10),
                        AcademicCode = c.String(nullable: false, maxLength: 10),
                        PositionCode = c.String(nullable: false, maxLength: 10),
                        EducationFieldCode = c.String(nullable: false, maxLength: 10),
                        PhoneNumber = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 50),
                        ResearchInterests = c.String(nullable: false, maxLength: 200),
                        ImageStaff = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Code)
                .ForeignKey("dbo.Academics", t => t.AcademicCode, cascadeDelete: true)
                .ForeignKey("dbo.Degrees", t => t.DegreeCode, cascadeDelete: true)
                .ForeignKey("dbo.EducationFields", t => t.EducationFieldCode, cascadeDelete: true)
                .ForeignKey("dbo.Positions", t => t.PositionCode, cascadeDelete: true)
                .Index(t => t.DegreeCode)
                .Index(t => t.AcademicCode)
                .Index(t => t.PositionCode)
                .Index(t => t.EducationFieldCode);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 10),
                        StaffCode = c.String(nullable: false, maxLength: 10),
                        SubjectCode = c.String(nullable: false, maxLength: 10),
                        LectureRoom = c.String(nullable: false, maxLength: 20),
                        NumberOfStudent = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Code)
                .ForeignKey("dbo.Staffs", t => t.StaffCode, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectCode, cascadeDelete: true)
                .Index(t => t.StaffCode)
                .Index(t => t.SubjectCode);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 10),
                        SubjectName = c.String(nullable: false, maxLength: 10),
                        NumberOfCredit = c.Int(nullable: false),
                        NumberOfLesson = c.Int(nullable: false),
                        NumberOfTheory = c.Int(nullable: false),
                        NumberOfExercise = c.Int(nullable: false),
                        NumberOfDiscussion = c.Int(nullable: false),
                        NumberOfPractice = c.Int(nullable: false),
                        ExamForm = c.String(nullable: false, maxLength: 20),
                        CodeView = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.Degrees",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 50),
                        CodeView = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.EducationFields",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 50),
                        FalcutyCode = c.String(nullable: false, maxLength: 10),
                        CodeView = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Code)
                .ForeignKey("dbo.Faculties", t => t.FalcutyCode, cascadeDelete: true)
                .Index(t => t.FalcutyCode);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 10),
                        FacultyName = c.String(nullable: false, maxLength: 50),
                        FacultyPhone = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 50),
                        CodeView = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.StaffDocuments",
                c => new
                    {
                        StaffCode = c.String(nullable: false, maxLength: 10),
                        DocumentCode = c.String(nullable: false, maxLength: 10),
                        PagesWrite = c.String(nullable: false, maxLength: 50),
                        Thread = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => new { t.StaffCode, t.DocumentCode })
                .ForeignKey("dbo.Documents", t => t.DocumentCode, cascadeDelete: true)
                .ForeignKey("dbo.Staffs", t => t.StaffCode, cascadeDelete: true)
                .Index(t => t.StaffCode)
                .Index(t => t.DocumentCode);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 50),
                        DateRelease = c.DateTime(nullable: false),
                        Link = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.StaffGraduateds",
                c => new
                    {
                        StaffCode = c.String(nullable: false, maxLength: 10),
                        GraduatedCode = c.String(nullable: false, maxLength: 50),
                        Descript = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => new { t.StaffCode, t.GraduatedCode })
                .ForeignKey("dbo.Graduatings", t => t.GraduatedCode, cascadeDelete: true)
                .ForeignKey("dbo.Staffs", t => t.StaffCode, cascadeDelete: true)
                .Index(t => t.StaffCode)
                .Index(t => t.GraduatedCode);
            
            CreateTable(
                "dbo.Graduatings",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 50),
                        Name = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 100),
                        Time = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.StaffProjectResearches",
                c => new
                    {
                        StaffCode = c.String(nullable: false, maxLength: 10),
                        ResearchProjectCode = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => new { t.StaffCode, t.ResearchProjectCode })
                .ForeignKey("dbo.ResearchProjects", t => t.ResearchProjectCode, cascadeDelete: true)
                .ForeignKey("dbo.Staffs", t => t.StaffCode, cascadeDelete: true)
                .Index(t => t.StaffCode)
                .Index(t => t.ResearchProjectCode);
            
            CreateTable(
                "dbo.ResearchProjects",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 50),
                        Level = c.String(nullable: false, maxLength: 20),
                        Members = c.String(nullable: false, maxLength: 200),
                        Time = c.DateTime(nullable: false),
                        State = c.String(nullable: false, maxLength: 50),
                        Rank = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Code);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StaffProjectResearches", "StaffCode", "dbo.Staffs");
            DropForeignKey("dbo.StaffProjectResearches", "ResearchProjectCode", "dbo.ResearchProjects");
            DropForeignKey("dbo.StaffGraduateds", "StaffCode", "dbo.Staffs");
            DropForeignKey("dbo.StaffGraduateds", "GraduatedCode", "dbo.Graduatings");
            DropForeignKey("dbo.StaffDocuments", "StaffCode", "dbo.Staffs");
            DropForeignKey("dbo.StaffDocuments", "DocumentCode", "dbo.Documents");
            DropForeignKey("dbo.Staffs", "PositionCode", "dbo.Positions");
            DropForeignKey("dbo.Staffs", "EducationFieldCode", "dbo.EducationFields");
            DropForeignKey("dbo.EducationFields", "FalcutyCode", "dbo.Faculties");
            DropForeignKey("dbo.Staffs", "DegreeCode", "dbo.Degrees");
            DropForeignKey("dbo.Courses", "SubjectCode", "dbo.Subjects");
            DropForeignKey("dbo.Courses", "StaffCode", "dbo.Staffs");
            DropForeignKey("dbo.Staffs", "AcademicCode", "dbo.Academics");
            DropIndex("dbo.StaffProjectResearches", new[] { "ResearchProjectCode" });
            DropIndex("dbo.StaffProjectResearches", new[] { "StaffCode" });
            DropIndex("dbo.StaffGraduateds", new[] { "GraduatedCode" });
            DropIndex("dbo.StaffGraduateds", new[] { "StaffCode" });
            DropIndex("dbo.StaffDocuments", new[] { "DocumentCode" });
            DropIndex("dbo.StaffDocuments", new[] { "StaffCode" });
            DropIndex("dbo.EducationFields", new[] { "FalcutyCode" });
            DropIndex("dbo.Courses", new[] { "SubjectCode" });
            DropIndex("dbo.Courses", new[] { "StaffCode" });
            DropIndex("dbo.Staffs", new[] { "EducationFieldCode" });
            DropIndex("dbo.Staffs", new[] { "PositionCode" });
            DropIndex("dbo.Staffs", new[] { "AcademicCode" });
            DropIndex("dbo.Staffs", new[] { "DegreeCode" });
            DropTable("dbo.ResearchProjects");
            DropTable("dbo.StaffProjectResearches");
            DropTable("dbo.Graduatings");
            DropTable("dbo.StaffGraduateds");
            DropTable("dbo.Documents");
            DropTable("dbo.StaffDocuments");
            DropTable("dbo.Positions");
            DropTable("dbo.Faculties");
            DropTable("dbo.EducationFields");
            DropTable("dbo.Degrees");
            DropTable("dbo.Subjects");
            DropTable("dbo.Courses");
            DropTable("dbo.Staffs");
            DropTable("dbo.Academics");
        }
    }
}
