using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ManageStaff.Models
{
    public class Course
    {
        [Required, StringLength(10), Key]
        public String Code { get; set; }
        public Staff Staff { get; set; }
        [Required, StringLength(20)]
        public String LectureRoom { get; set; }
        [Required]
        public int NumberOfStudent { get; set; }
        public Subject Subject { get; set; }

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