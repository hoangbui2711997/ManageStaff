using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManageStaff.Models
{
    public class StaffDocument
    {
        [Required, StringLength(10)]
        public String StaffCode { get; set; }
        [Required, StringLength(10)]
        public String DocumentCode { get; set; }

        [ForeignKey("StaffCode")]
        public Staff Staff { get; set; }
        [ForeignKey("DocumentCode")]
        public Document Document { get; set; }
        [Required, StringLength(50)]
        public String PagesWrite { get; set; }
        [Required, StringLength(200)]
        public String Thread { get; set; }

        //public virtual Staff Staff { get; set; }
        //public virtual Document Document { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //}
        //        [StaffCode]
        //        [varchar](10) NOT NULL,

        //[DocCode] [varchar](10) NOT NULL,

        //[PagesWrite] [varchar](50) NULL,
        //	[Thread]
        //        [nvarchar](200) NULL,
    }
}