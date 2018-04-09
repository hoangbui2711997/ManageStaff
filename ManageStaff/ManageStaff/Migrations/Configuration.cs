//namespace ManageStaff.Migrations
//{
//    using ManageStaff.Models;
//    using System;
//    using System.Data.Entity;
//    using System.Data.Entity.Migrations;
//    using System.Linq;

//    internal sealed class Configuration : DbMigrationsConfiguration<ManageStaff.Data.ManageStaffs>
//    {
//        public Configuration()
//        {
//            AutomaticMigrationsEnabled = false;
//        }

//        protected override void Seed(ManageStaff.Data.ManageStaffs context)
//        {
//            //  This method will be called after migrating to the latest version.

//            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
//            //  to avoid creating duplicate seed data. E.g.
//            //
//            //    context.People.AddOrUpdate(
//            //      p => p.FullName,
//            //      new Person { FullName = "Andrew Peters" },
//            //      new Person { FullName = "Brice Lambson" },
//            //      new Person { FullName = "Rowan Miller" }
//            //    );
//            //

//            //            Insert into dbo.Degree(Code, Name, Codeview) values(N'01', N'Thạc sĩ', N'THS')
//            //Insert into dbo.Degree(Code, Name, Codeview) values(N'02', N'Tiến sĩ', N'TS')
//            context.Degrees.AddOrUpdate(new Degree("01", "Tiến sĩ", "TS" ));
//            context.Degrees.AddOrUpdate(new Degree("02", "Thạc sĩ", "THS"));

//            //            Insert into dbo.Position(Code, Name, Codeview) values(N'01', N'Chủ nhiệm khoa', N'CNK')
//            //Insert into dbo.Position(Code, Name, Codeview) values(N'02', N'Chủ nhiệm bộ môn', N'CNBM')
//            //Insert into dbo.Position(Code, Name, Codeview) values(N'03', N'Phó chủ nhiệm khoa', N'PCNK')
//            //Insert into dbo.Position(Code, Name, Codeview) values(N'04', N'Phó chủ nhiệm bộ môn', N'PCNBM')
//            //Insert into dbo.Position(Code, Name, Codeview) values(N'05', N'Giáo viên', N'Gv')
//            //Insert into dbo.Position(Code, Name, Codeview) values(N'06', N'Giáo viên thỉnh giảng', N'GvTG')
//            context.Positions.AddOrUpdate(new Position(code: "01", name: "Chủ nhiệm khoa", codeView: "CNK"));
//            context.Positions.AddOrUpdate(new Position(code: "02", name: "Chủ nhiệm bộ môn", codeView: "CNBM"));
//            context.Positions.AddOrUpdate(new Position(code: "03", name: "Phó chủ nhiệm khoa", codeView: "PCNK"));
//            context.Positions.AddOrUpdate(new Position(code: "04", name: "Phó chủ nhiệm bộ môn", codeView: "PCNBM"));
//            context.Positions.AddOrUpdate(new Position(code: "05", name: "Giáo viên", codeView: "Gv"));
//            context.Positions.AddOrUpdate(new Position(code: "06", name: "Giáo viên thỉnh giảng", codeView: "GVTG"));
//        }
//    }
//}
