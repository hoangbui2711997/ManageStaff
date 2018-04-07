using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManageStaff.Models
{
    public class Staff
    {
        [Required, StringLength(10), Key]
        public String Code { get; set; }

        [Required, StringLength(50)]
        public String Name { get; set; }

        [Required]
        public Degree Degree { get; set; }

        [Required]
        public Academic Academic { get; set; }

        [Required]
        public Position Position { get; set; }

        [Required]
        public EducationField EducationField { get; set; }

        [Required, StringLength(20)]
        public String PhoneNumber { get; set; }

        [Required, StringLength(50), DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        [Required, StringLength(200)]
        public String ResearchInterests { get; set; }

        [Required, DataType(DataType.ImageUrl)]
        public String ImageStaff { get; set; }
        //[StringLength(10)]
        //public ICollection<ImageStaff> ImageStaffs { get; set; }

        //[ForeignKey("ImageStaffCode")]
        //public ImageStaff ImageStaff { get; set; }

        public ICollection<Course> Courses { get; set; }
        public ICollection<StaffProjectResearch> StaffProjectResearchs { get; set; }
        public ICollection<StaffDocument> StaffDocuments { get; set; }
        public ICollection<StaffGraduated> StaffGraduateds { get; set; }

        public Staff()
        {
            Courses = new List<Course>();
            StaffProjectResearchs = new List<StaffProjectResearch>();
            StaffDocuments = new List<StaffDocument>();
            StaffGraduateds = new List<StaffGraduated>();
            //ImageStaffs = new List<ImageStaff>();
        }

        //	[Imagecode]
        //        [varchar](1
        //	0) NULL,
    }
}