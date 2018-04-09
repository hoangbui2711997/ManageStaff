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
        public static List<Staff> staffs;
        public static List<Academic> academics;
        public static List<Course> courses;
        public static List<Degree> degrees;
        public static List<Document> documents;
        public static List<EducationField> educationFields;
        public static List<Faculty> faculties;
        public static List<Graduating> graduatings;
        public static List<Position> positions;
        public static List<ResearchProject> researchProjects;
        public static List<StaffDocument> staffDocuments;
        public static List<StaffGraduated> staffGraduateds;
        public static List<StaffProjectResearch> staffProjectResearches;
        public static List<Subject> subjects;

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
                    Email = m.Field<String>("Email")
                }).ToList();

                Adapters.staffs = staffs;
            } else
            {
                
            }
        }

    }
}