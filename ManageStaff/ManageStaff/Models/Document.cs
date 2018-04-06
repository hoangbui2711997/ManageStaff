using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManageStaff.Models
{
    public class Document
    {
        [Required, StringLength(10), Key]
        public String Code { get; set; }
        [Required, StringLength(50)]
        public String Name { get; set; }
        [Required, DataType(DataType.DateTime)]
        public DateTime DateRelease { get; set; }
        [Required, StringLength(200)]
        public String Link { get; set; }

        public ICollection<StaffDocument> StaffDocuments { get; set; }

        public Document()
        {
            StaffDocuments = new List<StaffDocument>();
        }
//        [Code]
//        [varchar](10) NOT NULL,

//[Name] [nvarchar](50) NULL,
//	[DayRelease]
//        [date]
//        NULL,
//	[Link]
//        [nvarchar](200) NULL,
    }
}