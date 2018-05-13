using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManageStaff.Models
{
    public class ResearchProject
    {
        [Required, StringLength(10), Key]
        public String Code { get; set; }

        [Required, StringLength(10), Key]
        public String StaffCode { get; set; }

        [Required, StringLength(10), Key]
        public String LeaderCode { get; set; }

        public Staff Staff { get; set; }

        public Staff Leader { get; set; }

        [Required, StringLength(50)]
        public String Name { get; set; }

        [Required, StringLength(20)]
        public String Level { get; set; }

        [Required, StringLength(200)]
        public String Members { get; set; }

        [Required, DataType(DataType.DateTime)]
        public DateTime Time { get; set; }

        [Required, StringLength(50)]
        public String State { get; set; }

        [Required, StringLength(10)]
        public String Rank { get; set; }

        public ICollection<StaffProjectResearch> StaffProjectResearchs { get; set; }
        
        public ResearchProject()
        {
            StaffProjectResearchs = new List<StaffProjectResearch>();
        }
        //        [Code]
        //        [varchar](10) NOT NULL,

        //[Staffcode] [varchar](10) NULL,
        //	[Name]
        //        [nvarchar](50) NULL,
        //	[Level]
        //        [nvarchar](20) NULL,
        //	[Leader]
        //        [char](10) NULL,
        //	[Members]
        //        [nvarchar](200) NULL,
        //	[Time]
        //        [datetime]
        //        NULL,
        //	[State]
        //        [nvarchar](50) NULL,
        //	[Rank]
        //        [nvarchar](10) NULL,
    }
}