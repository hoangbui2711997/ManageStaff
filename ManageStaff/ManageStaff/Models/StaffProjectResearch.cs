using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ManageStaff.Models
{
    public class StaffProjectResearch
    {
        
        [StringLength(10)]
        public String StaffCode { get; set; }
        
        [StringLength(10)]
        public String ResearchProjectCode { get; set; }

        [ForeignKey("StaffCode")]
        public Staff Staff { get; set; }
        [ForeignKey("ResearchProjectCode"), StringLength(10)]
        public ResearchProject ResearchProject { get; set; }

        //public virtual Staff Staff { get; set; }
        //public virtual ResearchProject ResearchProject { get; set; }
        //        [StaffCode]
        //        [varchar](10) NOT NULL,
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{

        //}
        //[ProjectReaseachCode] [varchar](10) NOT NULL,
    }
}