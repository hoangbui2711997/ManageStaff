select * from Staffs

-- chuc vu
select * from Positions
go

-- hoc vi
select * from Degrees
go

-- hoc ham
select * from Academics
go

-- khoa
select * from Faculties
go

insert into Faculties values('001', N'Khoa vô tuyến điện tử', '069.515.384', 'info@fre.mta.edu.vn')
go

 --bo mon
select * from EducationFields
go

insert into EducationFields values('010', N'Xung số - Vi xử lý', '001', 'XS - VXL')
go

insert into Degrees values('03', N'Kỹ sư', 'KS')
go

insert into Academics values('01', N'Trợ giảng', N'Trợ giảng')
go

insert into Academics values('02', N'Giảng viên' , N'Giảng viên')
go

insert into Positions values('07', N'Trưởng phòng thí nghiệm', 'TPTN')
go

select * from Staffs
--select BulkColumn from Openrowset(Bulk 'C:\Users\DEVON\Desktop\image\image\hvktqs.jpg', Single_Blob) as img

-- format (MaGV, Ten, Hoc vi, Hoc Ham, Chuc vu, Bo mon, Dien Thoai, Email, ImageStaff)

insert into Staffs(Code, Name, PositionCode, AcademicCode, DegreeCode, Email, ImageStaff,
 EducationFieldCode, PhoneNumber, ResearchInterests)
values('999', N'Nguyễn Hải Dương', '02', '02', '01', N'haiduongnguyen(a)mta.edu.vn',
(select BulkColumn from Openrowset(Bulk 'C:\Users\DEVON\Desktop\imageStaff\Bm-Nguyen_Hai_Duong.jpg', Single_Blob) as img),
'010', 'Khong co', 'Hệ thống nhúng, Kỹ thuật vi xử lý')
go

insert into Staffs(Code, Name, PositionCode, AcademicCode, DegreeCode, Email, ImageStaff,
 EducationFieldCode, PhoneNumber, ResearchInterests)
values('1000', N'Hoàng Văn Phúc', '04', '02', '01', N'haiduongnguyen(a)mta.edu.vn',
(select BulkColumn from Openrowset(Bulk 'C:\Users\DEVON\Desktop\imageStaff\Bm-Hoang_Van_Phuc.jpg', Single_Blob) as img),
'010', 'Khong co', 'TK vi mạch, Thiết kế HT số, HT nhúng, IoT, DSP, DSR')
go

insert into Staffs(Code, Name, PositionCode, AcademicCode, DegreeCode, Email, ImageStaff,
 EducationFieldCode, PhoneNumber, ResearchInterests)
values('1001', N'Dương Quang Mạnh', '07', '02', '01', N'haiduongnguyen(a)mta.edu.vn',
(select BulkColumn from Openrowset(Bulk 'C:\Users\DEVON\Desktop\imageStaff\Bm-Duong_Quang_Manh.JPG', Single_Blob) as img),
'010', 'Khong co', 'Vi điện tử, Thiết kế hệ thống số')
go

insert into Staffs(Code, Name, PositionCode, AcademicCode, DegreeCode, Email, ImageStaff,
 EducationFieldCode, PhoneNumber, ResearchInterests)
values('1002', N'Phạm Tuấn Giáo', '05', '02', '01', N'haiduongnguyen(a)mta.edu.vn',
(select BulkColumn from Openrowset(Bulk 'C:\Users\DEVON\Desktop\imageStaff\Bm-Pham_Tuan_Giao.jpg', Single_Blob) as img),
'010', 'Khong co', 'Xử lý số tín hiệu, Xử lý tín hiệu mạng anten')
go

insert into Staffs(Code, Name, PositionCode, AcademicCode, DegreeCode, Email, ImageStaff,
 EducationFieldCode, PhoneNumber, ResearchInterests)
values('1003', N'Nguyễn Hoài Anh', '05', '02', '01', N'haiduongnguyen(a)mta.edu.vn',
(select BulkColumn from Openrowset(Bulk 'C:\Users\DEVON\Desktop\imageStaff\KhongCoAnh.png', Single_Blob) as img),
'010', 'Khong co', 'Vi điện tử, Hệ thống thông tin')
go

insert into Staffs(Code, Name, PositionCode, AcademicCode, DegreeCode, Email, ImageStaff,
 EducationFieldCode, PhoneNumber, ResearchInterests)
values('1004', N'Nguyễn Đình Tuấn', '05', '02', '01', N'haiduongnguyen(a)mta.edu.vn',
(select BulkColumn from Openrowset(Bulk 'C:\Users\DEVON\Desktop\imageStaff\Bm-Nguyen_Dinh_Tuan.jpg', Single_Blob) as img),
'010', 'Khong co', 'Thiết kế hệ thống số')
go

insert into Staffs(Code, Name, PositionCode, AcademicCode, DegreeCode, Email, ImageStaff,
 EducationFieldCode, PhoneNumber, ResearchInterests)
values('1005', N'Đào Văn Lân', '05', '02', '01', N'haiduongnguyen(a)mta.edu.vn',
(select BulkColumn from Openrowset(Bulk 'C:\Users\DEVON\Desktop\imageStaff\Bm-Dao_Van_Lan.JPG', Single_Blob) as img),
'010', 'Khong co', 'Thiết kế HT số, Hệ thống nhúng, IoT, Xử lý tiếng nói')
go

insert into Staffs(Code, Name, PositionCode, AcademicCode, DegreeCode, Email, ImageStaff,
 EducationFieldCode, PhoneNumber, ResearchInterests)
values('1006', N'Nguyễn Văn Tình', '05', '01', '03', N'haiduongnguyen(a)mta.edu.vn',
(select BulkColumn from Openrowset(Bulk 'C:\Users\DEVON\Desktop\imageStaff\Bm-Nguyen_Van_Tinh.png', Single_Blob) as img),
'010', 'Khong co', 'Thiết kế hệ thống số')
go

insert into Staffs(Code, Name, PositionCode, AcademicCode, DegreeCode, Email, ImageStaff,
 EducationFieldCode, PhoneNumber, ResearchInterests)
values('1007', N'Nguyễn Khoa Sang', '02', '01', '02', N'haiduongnguyen(a)mta.edu.vn',
(select BulkColumn from Openrowset(Bulk 'C:\Users\DEVON\Desktop\imageStaff\Bm-Nguyen_Khoa_Sang.jpg', Single_Blob) as img),
'010', 'Khong co', 'Lập trình hệ thống')
go

insert into Staffs(Code, Name, PositionCode, AcademicCode, DegreeCode, Email, ImageStaff,
 EducationFieldCode, PhoneNumber, ResearchInterests)
values('1008', N'Hoàng Thị Yến', '02', '01', '03', N'haiduongnguyen(a)mta.edu.vn',
(select BulkColumn from Openrowset(Bulk 'C:\Users\DEVON\Desktop\imageStaff\Bm-Hoang_Thi_Yen.jpg', Single_Blob) as img),
'010', 'Khong co', 'Lập trình hệ thống')
go
