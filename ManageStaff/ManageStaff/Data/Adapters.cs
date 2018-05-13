using ManageStaff.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ManageStaff.Data
{
    // Bat ky Database nao truyen vao voi thong tin cua class se duoc chuyen sang List tuong tu
    public class Adapters
    {
        public static IEnumerable<Staff> staffs;
        public static IEnumerable<Academic> academics;
        public static IEnumerable<Course> courses;
        public static IEnumerable<Degree> degrees;
        public static IEnumerable<Document> documents;
        public static IEnumerable<EducationField> educationFields;
        public static IEnumerable<Faculty> faculties;
        public static IEnumerable<Graduating> graduatings;
        public static IEnumerable<Position> positions;
        public static IEnumerable<ResearchProject> researchProjects;
        public static IEnumerable<StaffDocument> staffDocuments;
        public static IEnumerable<StaffGraduated> staffGraduateds;
        public static IEnumerable<StaffProjectResearch> staffProjectResearches;
        public static IEnumerable<Subject> subjects;

        public static void Convert(DataTable nameTable, String nameModel)
        {
            if("Staff".Equals(nameModel))
            {
                List<Staff> staffs = nameTable.AsEnumerable().Select(m => new Staff()
                {
                    Code = m.Field<String>("Code"),
                    AcademicCode = m.Field<String>("Academicode"),
                    DegreeCode = m.Field<String>("Degreecode"),
                    Name = m.Field<String>("Name"),
                    ImageStaff = m.Field<String>("Image"),
                    PositionCode = m.Field<String>("PositionCode"),
                    EducationFieldCode = m.Field<String>("EducationFieldCode"),
                    PhoneNumber = m.Field<String>("Phonenumber"),
                    ResearchInterests = m.Field<String>("Researchinterests"),
                    Email = m.Field<String>("Email"),
                    SortBio = m.Field<String>("ShortBio"),
                    Degree = degrees.ToList().Find(e => e.Code == m.Field<String>("Degreecode")),
                    Academic = academics.ToList().Find(e => e.Code == m.Field<String>("Academicode")),
                    Position = positions.ToList().Find(e => e.Code == m.Field<String>("PositionCode")),
                    EducationField = educationFields.ToList().Find(e => e.Code == m.Field<String>("EducationFieldCode"))
                }).ToList();

                Adapters.staffs = staffs;
            } else if("Degree".Equals(nameModel))
            {
                List<Degree> degrees = nameTable.AsEnumerable().Select(m => new Degree()
                {
                    Code = m.Field<String>("Code"),
                    CodeView = m.Field<String>("Codeview"),
                    Name = m.Field<String>("Name"),
                    //Staffs = (Adapters.staffs.ToList().Where(e => e.DegreeCode == m.Field<String>("Code")))
                }).ToList();

                Adapters.degrees = degrees;
            } else if ("Position".Equals(nameModel))
            {
                List<Position> positions = nameTable.AsEnumerable().Select(m => new Position()
                {
                    Code = m.Field<String>("Code"),
                    CodeView = m.Field<String>("Codeview"),
                    Name = m.Field<String>("Name"),
                    //Staffs = (Adapters.staffs.ToList().Where(e => e.PositionCode == m.Field<String>("Code")))
                }).ToList();

                Adapters.positions = positions;
            } else if ("Academic".Equals(nameModel))
            {
                List<Academic> academics = nameTable.AsEnumerable().Select(m => new Academic()
                {
                    Code = m.Field<String>("Code"),
                    Codeview = m.Field<String>("Codeview"),
                    Name = m.Field<String>("Name"),
                    //Staffs = (Adapters.staffs.ToList().Where(e => e.AcademicCode == m.Field<String>("Code")))
                }).ToList();

                Adapters.academics = academics;
            } else if ("EducationField".Equals(nameModel))
            {
                List<EducationField> educationFields = nameTable.AsEnumerable().Select(m => new EducationField()
                {
                    Code = m.Field<String>("Code"),
                    CodeView = m.Field<String>("Codeview"),
                    Name = m.Field<String>("Name"),
                    //Staffs = (Adapters.staffs.ToList().Where(e => e.EducationFieldCode == m.Field<String>("Code"))),
                    Faculty = faculties.ToList().Find(e => e.Code == m.Field<String>("Code")),
                    FalcutyCode = m.Field<String>("Facultycode")
                }).ToList();

                Adapters.educationFields = educationFields;
            } else if ("Faculty".Equals(nameModel))
            {
                List<Faculty> faculties = nameTable.AsEnumerable().Select(m => new Faculty()
                {
                    Code = m.Field<String>("Code"),
                    Email = m.Field<String>("Email"),
                    FacultyPhone = m.Field<String>("Facultyphone"),
                    //EducationFields = (Adapters.educationFields.ToList().Where(e => e.FalcutyCode == m.Field<String>("Code"))),
                    FacultyName = m.Field<String>("Facultyname")
                }).ToList();

                Adapters.faculties = faculties;
            } else if ("Course".Equals(nameModel))
            {

            }
        }

    }
}