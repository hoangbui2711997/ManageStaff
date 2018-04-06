using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManageStaff.Models
{
    public class Subject
    {
        [Required, StringLength(10), Key]
        public String Code { get; set; }
        [Required, StringLength(10)]
        public String SubjectName { get; set; }
        [Required]
        public int NumberOfCredit { get; set; }
        [Required]
        public int NumberOfLesson { get; set; }
        [Required]
        public int NumberOfTheory { get; set; }
        [Required]
        public int NumberOfExercise { get; set; }
        [Required]
        public int NumberOfDiscussion { get; set; }
        [Required]
        public int NumberOfPractice { get; set; }
        [Required, StringLength(20)]
        public String ExamForm { get; set; }
        [Required, StringLength(10)]
        public String CodeView { get; set; }

        public ICollection<Course> Courses { get; set; }

        public Subject()
        {
            Courses = new List<Course>();
        }
        //        [Code]
        //        [varchar](50) NOT NULL,

        //[Subjectname] [nvarchar](50) NULL,
        //	[Numberofcredit]
        //        [int] NULL,
        //	[Numberoflesson]
        //        [int] NULL,
        //	[Numberoftheory]
        //        [int] NULL,
        //	[Numberofexercise]
        //        [int] NULL,
        //	[Numberofdiscussion]
        //        [int] NULL,
        //	[Numberofpractice]
        //        [int] NULL,
        //	[Requiredsubject]
        //        [char](10) NULL,
        //	[Semester]
        //        [int] NULL,
        //	[Examform]
        //        [nvarchar](20) NULL,
        //	[Reviewlesson]
        //        [bit]
        //        NULL,
        //	[Codeview]
        //        [nvarchar](20) NULL,
    }
}