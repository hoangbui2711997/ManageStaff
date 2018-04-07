using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManageStaff.Models
{
    public class Course
    {
        [Required, StringLength(10), Key]
        public String Code { get; set; }

        [Required, StringLength(10)]
        public String StaffCode { get; set; }
        [Required, StringLength(10)]
        public String SubjectCode { get; set; }

        [ForeignKey("StaffCode")]
        public Staff Staff { get; set; }
        [ForeignKey("SubjectCode")]
        public Subject Subject { get; set; }
        [Required, StringLength(20)]
        public String LectureRoom { get; set; }
        [Required]
        public int NumberOfStudent { get; set; }

//        [Code]
//        [varchar](10) NOT NULL,

//[Staffcode] [varchar](10) not NULL,

//[Lectureroom] [nvarchar] (20) null,
//	[Numberofstudent]
//        int null,
//	[Subjectcode]
//        [varchar](10) not NULL,
    }
}