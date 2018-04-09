using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManageStaff.Models
{
    public class Degree
    {
        [Required, StringLength(10), Key]
        public String Code { get; set; }
        [Required, StringLength(50)]
        public String Name { get; set; }
        [Required, StringLength(20)]
        public String CodeView { get; set; }

        public IEnumerable<Staff> Staffs { get; set; }



        public Degree()
        {
            Staffs = new List<Staff>();
        }

        public Degree(string code, string name, string codeView)
        {
            Code = code;
            Name = name;
            CodeView = codeView;
        }
        //        [Code]
        //        [varchar](10) NOT NULL,

        //[Name] [nvarchar](50) NULL,
        //	[Codeview]
        //        [nvarchar](20) NULL,
    }
}