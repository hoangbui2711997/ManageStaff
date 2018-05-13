using ManageStaff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageStaff.Data
{
    public class TuongTacSQL
    {
        private static void updateData()
        {
            ManageStaffs manageStaff = ManageStaffs.GetInstance();
            manageStaff.Init();
        }

        public static class DoStaff
        {
            /// <summary>
            /// Xóa
            /// </summary>
            /// <param name="id"></param>
            public static void DoDelete(string id)
            {
                DoWithSql.DoVoidQuery(@"DELETE Staff WHERE Code = '" + id + @"'");
                updateData();
            }

            /// <summary>
            /// Sửa
            /// </summary>
            /// <param name="newStaff"></param>
            public static void DoUpdate(Staff newStaff)
            {
                DoInsert(newStaff);
            }

            /// <summary>
            /// Thêm bằng proc
            /// </summary>
            /// <param name="staff"></param>
            public static void DoInsert(Staff staff)
            {
                String s = "Exec insertUpdateStaff "+ 
                    "'" + staff.Code.Trim() + "'," +
                    "N'" + staff.Name.Trim() + "'," +
                    "'" + staff.PositionCode.Trim() + "', " +
                    "'" + staff.AcademicCode.Trim() + "'," +
                    "'" + staff.DegreeCode.Trim() + "'," +
                    "N'" + staff.Email.Trim() + "','" +
                    staff.ImageStaff.Trim() + "'," +
                    "'" + staff.EducationFieldCode.Trim() + "', "+
                    "'" + staff.PhoneNumber.Trim() + "'," +
                    "N'" + staff.ResearchInterests.Trim() + "'";

                DoWithSql.DoVoidQuery(s);
                updateData();
            }
        }

        public static class DoDocument
        {
            public static void DoDelete(string id)
            {
                DoWithSql.DoVoidQuery(@"DELETE Document WHERE Code = '" + id + @"'");
                updateData();
            }

            public static void DoUpdate(Document newDocs)
            {
                DoInsert(newDocs);
            }

            public static void DoInsert(Document docs)
            {
                String s = "Exec insertUpdateDocs " +
                    "'" + docs.Code.Trim() + "'," +
                    "N'" + docs.Name.Trim() + "'," +
                    "'" + docs.DateRelease.ToString().Trim() + "', " +
                    "N'" + docs.Link.Trim() + "'";

                DoWithSql.DoVoidQuery(s);
                updateData();
            }
        }

        public static class DoDegree {
            public static void DoDelete(string id)
            {
                DoWithSql.DoVoidQuery(@"DELETE Degree WHERE Code = '" + id + @"'");
                updateData();
            }

            public static void DoUpdate(Degree newDegree)
            {
                DoInsert(newDegree);
            }

            public static void DoInsert(Degree degree)
            {
                String s = "Exec insertUpdateDegree " +
                    "'" + degree.Code.Trim() + "'," +
                    "N'" + degree.Name.Trim() + "'," +
                    "N'" + degree.CodeView.Trim() + "'";

                DoWithSql.DoVoidQuery(s);
                updateData();
            }
        }

        public static class DoStaffDocument
        {
            public static void DoDelete(string staffCode, string docCode)
            {
                DoWithSql.DoVoidQuery(@"DELETE StaffDocument WHERE " +
                                      "StaffCode = '" + staffCode + @"' " + "and DocCode = '" + docCode + @"'");
                updateData();
            }

            public static void DoUpdate(StaffDocument newStaffDocument)
            {
                DoInsert(newStaffDocument);
            }

            public static void DoInsert(StaffDocument staffDocument)
            {
                String s = "Exec insertUpdateStaffDocument " +
                    "'" + staffDocument.StaffCode.Trim() + "'," +
                    "'" + staffDocument.DocumentCode.Trim() + "'," +
                    "N'" + staffDocument.PagesWrite.Trim() + "'," +
                    "N'" + staffDocument.Thread.Trim() + "'";

                DoWithSql.DoVoidQuery(s);
                updateData();
            }
        }

        public static class DoAcademic
        {
            public static void DoDelete(string id)
            {
                DoWithSql.DoVoidQuery(@"DELETE Academic WHERE Code = '" + id + @"'");
                updateData();
            }

            public static void DoUpdate(Academic newAcademic)
            {
                DoInsert(newAcademic);
            }

            public static void DoInsert(Academic academic)
            {
                String s = "Exec insertUpdateAcademic " +
                    "'" + academic.Code.Trim() + "'," +
                    "N'" + academic.Name.Trim() + "'," +
                    "'" + academic.Codeview.Trim() + "'";

                DoWithSql.DoVoidQuery(s);
                updateData();
            }
        }

        public static class DoPosition
        {
            public static void DoDelete(string id)
            {
                DoWithSql.DoVoidQuery(@"DELETE Position WHERE Code = '" + id + @"'");
                updateData();
            }

            public static void DoUpdate(Position newPosition)
            {
                DoInsert(newPosition);
            }

            public static void DoInsert(Position position)
            {
                String s = "Exec insertUpdatePosition " +
                    "'" + position.Code.Trim() + "'," +
                    "N'" + position.Name.Trim() + "'," +
                    "'" + position.CodeView + "'";

                DoWithSql.DoVoidQuery(s);
                updateData();
            }
        }

        public static class DoCourse
        {
            public static void DoDelete(string id)
            {
                DoWithSql.DoVoidQuery(@"DELETE Course WHERE Code = '" + id + @"'");
                updateData();
            }

            public static void DoUpdate(Course newCourse)
            {
                DoInsert(newCourse);
            }

            public static void DoInsert(Course position)
            {
                String s = "Exec insertUpdateCourse " +
                    "'" + position.Code.Trim() + "'," +
                    "'" + position.StaffCode.Trim() + "'," +
                    "N'" + position.LectureRoom.Trim() + "'" +
                    "" + position.NumberOfStudent + "" +
                    "'" + position.SubjectCode.Trim() + "'"
                    ;

                DoWithSql.DoVoidQuery(s);
                updateData();
            }
        }

        public static class DoSubject
        {
            public static void DoDelete(string id)
            {
                DoWithSql.DoVoidQuery(@"DELETE Subject WHERE Code = '" + id + @"'");
                updateData();
            }

            public static void DoUpdate(Subject newSubject)
            {
                DoInsert(newSubject);
            }

            public static void DoInsert(Subject subject)
            {
                String s = "Exec insertUpdateSubject " +
                    "'" + subject.Code.Trim() + "'," +
                    "" + subject.NumberOfCredit + "" +
                    "" + subject.NumberOfLesson + "" +
                    "" + subject.NumberOfTheory + "" +
                    "" + subject.NumberOfExercise + "" +
                    "" + subject.NumberOfDiscussion + "" +
                    "" + subject.NumberOfPractice + "" +
                    "N'" + subject.ExamForm.Trim() + "'" +
                    "N'" + subject.CodeView.Trim() + "'" +
                    "N'" + subject.SubjectName.Trim() + "'"
                    ;

                DoWithSql.DoVoidQuery(s);
                updateData();
            }
        }

        public static class DoStaffProjectResearch
        {
            public static void DoDelete(string staffCode, string projectResearchCode)
            {
                DoWithSql.DoVoidQuery(@"DELETE Staff_ProjectResearch WHERE StaffCode = '" + staffCode + @"' , ProjectResearchCode = '" + projectResearchCode + "'");
                updateData();
            }

            public static void DoUpdate(StaffProjectResearch newStaffProjectResearch)
            {
                DoInsert(newStaffProjectResearch);
            }

            public static void DoInsert(StaffProjectResearch staffProjectResearch)
            {
                String s = "Exec insertUpdateStaffProjectResearch " +
                    "'" + staffProjectResearch.StaffCode.Trim() + "'," +
                    "'" + staffProjectResearch.ResearchProjectCode.Trim() + "'"
                    ;

                DoWithSql.DoVoidQuery(s);
                updateData();
            }
        }

        public static class DoResearchProject
        {
            public static void DoDelete(string id)
            {
                DoWithSql.DoVoidQuery(@"DELETE ResearchProject WHERE Code = '" + id + @"'");
                updateData();
            }

            public static void DoUpdate(ResearchProject newResearchProject)
            {
                DoInsert(newResearchProject);
            }

            public static void DoInsert(ResearchProject researchProject)
            {
                String s = "Exec insertUpdateResearchProject " +
                    "'" + researchProject.Code.Trim() + "'," +
                    "'" + researchProject.StaffCode + "'" +
                    "N'" + researchProject.Name.Trim() + "'" +
                    "N'" + researchProject.Level.Trim() + "'" +
                    "'" + researchProject.LeaderCode + "'" +
                    "N'" + researchProject.Members.Trim() + "'" +
                    "'" + researchProject.Time.ToString().Trim() + "'" +
                    "N'" + researchProject.State.Trim() + "'" +
                    "N'" + researchProject.Rank.Trim() + "'"
                    ;

                DoWithSql.DoVoidQuery(s);
                updateData();
            }
        }

        public static class DoStaffGraduated
        {
            public static void DoDelete(string staffCode, string graduatingCode)
            {
                DoWithSql.DoVoidQuery(@"DELETE StaffGraduated WHERE StaffCode = '" + staffCode + @"' and GraduatingCode = '" + graduatingCode +"'");
                updateData();
            }

            public static void DoUpdate(StaffGraduated newStaffGraduated)
            {
                DoInsert(newStaffGraduated);
            }

            public static void DoInsert(StaffGraduated staffGraduated)
            {
                String s = "Exec insertUpdateStaffGraduated " +
                    "'" + staffGraduated.StaffCode.Trim() + "', " +
                    "N'" + staffGraduated.Descript.Trim() + "', " +
                    "'" + staffGraduated.GraduatedCode.Trim() + "'"
                    ;

                DoWithSql.DoVoidQuery(s);
                updateData();
            }
        }

        public static class DoFaculty
        {
            public static void DoDelete(string id)
            {
                DoWithSql.DoVoidQuery(@"DELETE Faculty WHERE Code = '" + id + @"'");
                updateData();
            }

            public static void DoUpdate(Faculty newFaculty)
            {
                DoInsert(newFaculty);
            }

            public static void DoInsert(Faculty faculty)
            {
                String s = "Exec insertUpdateFaculty " +
                    "'" + faculty.Code.Trim() + "', " +
                    "N'" + faculty.FacultyName.Trim() + "', " +
                    "'" + faculty.FacultyPhone.Trim() + "', " +
                    "'" + faculty.Email.Trim() + "'"
                    ;

                DoWithSql.DoVoidQuery(s);
                updateData();
            }
        }

        public static class DoEducationField
        {
            public static void DoDelete(string id)
            {
                DoWithSql.DoVoidQuery(@"DELETE EducationField WHERE Code = '" + id + @"'");
                updateData();
            }

            public static void DoUpdate(EducationField newEducationField)
            {
                DoInsert(newEducationField);
            }

            public static void DoInsert(EducationField educationField)
            {
                String s = "Exec insertUpdateEducationField " +
                    "'" + educationField.Code.Trim() + "', " +
                    "N'" + educationField.Name.Trim() + "', " +
                    "'" + educationField.FalcutyCode.Trim() + "', " +
                    "N'" + educationField.CodeView.Trim() + "'"
                    ;

                DoWithSql.DoVoidQuery(s);
                updateData();
            }
        }

        public static class DoGraduating
        {
            public static void DoDelete(string id)
            {
                DoWithSql.DoVoidQuery(@"DELETE Graduating WHERE Code = '" + id + @"'");
                updateData();
            }

            public static void DoUpdate(Graduating newGraduating)
            {
                DoInsert(newGraduating);
            }

            public static void DoInsert(Graduating graduating)
            {
                String s = "Exec insertUpdateGraduating " +
                    "'" + graduating.Code.Trim() + "', " +
                    "N'" + graduating.Name.Trim() + "', " +
                    "N'" + graduating.Address.Trim() + "', " +
                    "'" + graduating.Time.Trim() + "'"
                    ;

                DoWithSql.DoVoidQuery(s);
                updateData();
            }
        }
    }
}