using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ManageStaff.Models
{
    public class EducationField
    {
        [Required, StringLength(10), Key]
        public String Code { get; set; }
        [Required, StringLength(50)]
        public String Name { get; set; }

        [Required, StringLength(10)]
        public String FalcutyCode { get; set; }

        [ForeignKey("FalcutyCode")]
        public Faculty Faculty { get; set; }
        [Required, StringLength(20)]
        public String CodeView { get; set; }

        public IEnumerable<Staff> Staffs { get; set; }

        public EducationField()
        {
            Staffs = new List<Staff>();
        }
        //        [Code]
        //        [varchar](50) NOT NULL,

        //[Name] [nvarchar](50) NULL,
        //	[Facultycode]
        //        [varchar](50) NULL,
        //	[Codeview]
        //        [nvarchar](20) NULL,
    }
}