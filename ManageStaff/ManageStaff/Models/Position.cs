using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManageStaff.Models
{
    /// <summary>
    /// Position là chức vụ
    /// </summary>
    public class Position
    {
        public Position()
        {
            Staffs = new List<Staff>();
        }

        public Position(string code, string name, string codeView)
        {
            Staffs = new List<Staff>();
            Code = code;
            Name = name;
            CodeView = codeView;
        }

        public IEnumerable<Staff> Staffs { get; set; }

        [Required, StringLength(10), Key]
        public String Code { get; set; }

        [Required, StringLength(50)]
        public String Name { get; set; }

        [Required, StringLength(20)]
        public String CodeView { get; set; }


        //        [Code]
        //        [varchar](10) NOT NULL,

        //[Name] [nvarchar](50) NULL,
        //	[Codeview]
        //        [nvarchar](20) NULL,
    }
}