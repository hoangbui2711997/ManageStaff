using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ManageStaff.Models
{
    public class ImageStaff
    {
        [Required, StringLength(10), Key]
        public String Code { get; set; }

        [StringLength(10)]
        public String StaffCode { get; set; }

        [ForeignKey("StaffCode")]
        public Staff Staff { get; set; }

        [Required, StringLength(50)]
        public String Descript { get; set; }

        [Required, DataType(DataType.ImageUrl)]
        public String Image { get; set; }

        public ImageStaff()
        {

        }

        //        [Code]
        //        [varchar](10) NOT NULL,

        //[Staffcode] [varchar](10) NULL,
        //	[Descript]
        //        [nvarchar](50) NULL,
        //	[Image]
        //        [image]
        //        NULL,
    }
}