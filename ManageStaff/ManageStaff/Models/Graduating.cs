using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManageStaff.Models
{
    public class Graduating
    {
        [Required, StringLength(50), Key]
        public String Code { get; set; }
        [Required, StringLength(50)]
        public String Name { get; set; }
        [Required, StringLength(100)]
        public String Address { get; set; }
        [Required, DataType(DataType.DateTime)]
        public String Time { get; set; }

        public ICollection<StaffGraduated> StaffGraduateds { get; set; }

        public Graduating()
        {
            StaffGraduateds = new List<StaffGraduated>();
        }
        //        [Code]
        //        [varchar](50) NOT NULL,

        //[Name] [nvarchar](50) NULL,
        //	[Address]
        //        [nvarchar](100) NULL,
        //	[Time]
        //        [datetime]
        //        NULL,
    }
}