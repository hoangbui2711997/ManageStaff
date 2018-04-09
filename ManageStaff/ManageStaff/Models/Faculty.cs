using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManageStaff.Models
{
    public class Faculty
    {
        [Required, StringLength(10), Key]
        public String Code { get; set; }
        [Required, StringLength(50)]
        public String FacultyName { get; set; }
        [Required, StringLength(50), Phone]
        public String FacultyPhone { get; set; }
        [Required, StringLength(50), EmailAddress]
        public String Email { get; set; }

        public IEnumerable<EducationField> EducationFields { get; set; }

        public Faculty()
        {
            EducationFields = new List<EducationField>();
        }
        //        [Code]
        //        [varchar](50) NOT NULL,

        //[Facultyname] [nvarchar](50) NULL,
        //	[Facultyphone]
        //        [varchar](50) NULL,
        //	[Email]
        //        [nvarchar](50) NULL,
    }
}