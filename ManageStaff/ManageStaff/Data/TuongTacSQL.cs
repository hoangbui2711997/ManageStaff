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
            public static void DoDelete(string id)
            {
                DoWithSql.DoVoidQuery(@"DELETE Staff WHERE Code = '" + id + @"'");
                updateData();
            }

            public static void DoUpdate(Staff newStaff)
            {
                DoInsert(newStaff);
            }

            public static void DoInsert(Staff staff)
            {
                String s = "Exec insertUpdateStaff '" + staff.Code.Trim() + "'," +
                    "N'" + staff.Name.Trim() + "'," +
                    "'" + staff.PositionCode.Trim() + "', '" + staff.AcademicCode.Trim() + "'," +
                    "'" + staff.DegreeCode.Trim() + "'," +
                    "N'" + staff.Email.Trim() + "','" + staff.ImageStaff.Trim() + "'," +
                    "'" + staff.EducationFieldCode.Trim() + "', '" + staff.PhoneNumber.Trim() + "'," +
                    "N'" + staff.ResearchInterests.Trim() + "'";

                DoWithSql.DoVoidQuery(s);
                updateData();
            }
        }

        public static class DoDocument
        {

        }
    }
}