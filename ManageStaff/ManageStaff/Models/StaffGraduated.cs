using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManageStaff.Models
{
    public class StaffGraduated
    {
        
        [StringLength(10)]
        public String StaffCode { get; set; }
        [StringLength(10)]
        public String GraduatedCode { get; set; }

        [Required, StringLength(500)]
        public String Descript { get; set; }

        [ForeignKey("StaffCode")]
        public Staff Staff { get; set; }
        [ForeignKey("GraduatedCode")]
        public Graduating Graduating { get; set; }

        //public virtual Staff Staff { get; set; }
        //public virtual Graduating Graduating { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //}
        //        [StaffCode]
        //        [varchar](10) NOT NULL,

        //[Descript] [nvarchar](500) NULL,
        //	[GraduatingCode]
        //        [varchar](10) NOT NULL,
    }
}