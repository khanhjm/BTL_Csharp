/*
tblNhomhang: PK_NhomhangID, TenNhomhang, Mota;

tblHanghoa: PK_HanghoaID, FK_NhomhangID, TenHanghoa, Nhacungcap, Soluong, Dongia, Thoigianbaohanh;

tblHoadonnhaphang: PK_HoadonnhaphangID, FK_NhanvienID, Thoigiannhap, Tongtien;

tblHangnhap: FK_HoadonnhaphangID, FK_HanghoaID, Soluongnhap, Gianhap, Thanhtien;

tblHoadonbanhang: PK_HoadonbanhangID, FK_NhanvienID, TenKhachhang, Diachi, Sdt, Thoigianban, Tongtien;

tblHangban: FK_HoadonbanhangID, FK_HanghoaID, Soluongban, Giaban, Thanhtien;

tblNhanvien: PK_NhanvienID, TenNhanvien, Ngaysinh, Gioitinh, Chucvu, UserNV, PassNV;
*/
--create database BTL222;

-----------------------------------------------------------------------
---	              Tạo bảng
-----------------------------------------------------------------------
use BTL222;
-- Nhóm hàng
create table tblNhomhang(
	PK_iNhomhangID int primary key identity(1,1),
	sTenNhomhang nvarchar(50),
	sMota nvarchar(100));
-- Hàng hóa
create table tblHanghoa(
	PK_iHanghoaID int primary key identity(1,1),
	FK_iNhomhangID int,
	sTenHanghoa nvarchar(50),
	sNhacungcap nvarchar(50),
	iSoluong int,
	iDongia int,
	iThoigianbaohanh int);
-- Hóa đơn nhập hàng
create table tblHoadonnhaphang(
	PK_iHoadonnhaphangID int primary key identity(1,1),
	FK_iNhanvienID int,
	dThoigiannhap date,
	iTongtien int default 0);
-- Mặt hàng nhập
create table tblHangnhap(
	FK_iHoadonnhaphangID int,
	FK_iHanghoaID int,
	iSoluongnhap int,
	iGianhap int,
	iThanhtien int default 0);
-- Hóa đơn bán hàng
create table tblHoadonbanhang (
	PK_iHoadonbanhangID int primary key identity(1,1),
	FK_iNhanvienID int,
	sTenKhachhang nvarchar(50),
	sDiachi nvarchar(50),
	sSdt nvarchar(50),
	dThoigianban date,
	iTongtien int default 0);
-- Mặt hàng bán ra
create table tblHangban(
	FK_iHoadonbanhangID int,
	FK_iHanghoaID int,
	iSoluongban int,
	iGiaban int,
	iThanhtien int default 0);
-- Bảng nhân viên và tài khoản đăng nhập
create table tblNhanvien(
	PK_iNhanvienID int primary key identity(1,1),
	sTenNhanvien nvarchar(50),
	dNgaysinh date,
	bGioitinh bit,
	sChucvu nvarchar(50),
	sUserNV nvarchar(50),
	sPassNV nvarchar(50));

-----------------------------------------------------------------------
---	              Tạo Khóa ngoại
-----------------------------------------------------------------------
alter table tblHanghoa
add constraint FK_tblHanghoa_tblNhomhang foreign key (FK_iNhomhangID)
	references tblNhomhang(PK_iNhomhangID)

alter table tblHoadonbanhang
add constraint FK_tblHoadonbanhang_tblNhanvien foreign key (FK_iNhanvienID)
	references tblNhanvien(PK_iNhanvienID);

alter table tblHoadonnhaphang
add constraint FK_tblHoadonnhaphang_tblNhanvien foreign key (FK_iNhanvienID)
	references tblNhanvien(PK_iNhanvienID);
	
alter table tblHangban
add constraint FK_tblHangban_tblHoadonbanhang foreign key (FK_iHoadonbanhangID)
	references tblHoadonbanhang(PK_iHoadonbanhangID);

alter table tblHangnhap
add constraint FK_tblHangnhap_tblHoadonnhaphang foreign key (FK_iHoadonnhaphangID)
	references tblHoadonnhaphang(PK_iHoadonnhaphangID);

alter table tblHangban
add constraint FK_tblHangban_tblHanghoa foreign key (FK_iHanghoaID)
	references tblHanghoa(PK_iHanghoaID);

alter table tblHangnhap
add constraint FK_tblHangnhap_tblHanghoa foreign key (FK_iHanghoaID)
	references tblHanghoa(PK_iHanghoaID);


-----------------------------------------------------------------------
---	              Tạo Procudure
-----------------------------------------------------------------------

---               Nhóm hàng
-- select
go
create proc sp_tblNhomhang_Select(
	@PK_iNhomhangID int)
as begin
	if @PK_iNhomhangID = 0 select * from tblNhomhang
	if @PK_iNhomhangID > 0 select * from tblNhomhang where PK_iNhomhangID = @PK_iNhomhangID
end
-- insert
go
create proc sp_tblNhomhang_Insert(
	@PK_iNhomhangID int out,
	@sTenNhomhang nvarchar(50),
	@sMota nvarchar(50) )
as begin
	insert into tblNhomhang (sTenNhomhang, sMota)
	values (@sTenNhomhang, @sMota)
	select @PK_iNhomhangID = @@IDENTITY
end
-- update
go
create proc sp_tblNhomhang_Update (
	@PK_iNhomhangID int,
	@sTenNhomhang nvarchar(50),
	@sMota nvarchar(50) )
as begin
	update tblNhomhang
	set sTenNhomhang = @sTenNhomhang, sMota = @sMota
	where PK_iNhomhangID = @PK_iNhomhangID
end
-- delete
go
create proc sp_tblNhomhang_Delete (
	@PK_iNhomhangID int )
as begin
	delete from tblNhomhang where PK_iNhomhangID = @PK_iNhomhangID
end

---               Kho hàng hóa
-- select
go
create proc sp_tblHanghoa_Select (
	@PK_iHanghoaID int )
as begin
	if @PK_iHanghoaID = 0
		select * from tblHanghoa
	if @PK_iHanghoaID > 0
		select * from tblHanghoa where PK_iHanghoaID = @PK_iHanghoaID
end
-- select by FK
go
create proc sp_tblHanghoa_SelectByFK (
	@FK_iNhomhangID int )
as begin
	if @FK_iNhomhangID = 0
		select * from tblHanghoa
	if @FK_iNhomhangID > 0
		select * from tblHanghoa where FK_iNhomhangID = @FK_iNhomhangID
end
-- insert
go
create proc sp_tblHanghoa_Insert (
	@PK_iHanghoaID int out,
	@FK_iNhomhangID int,
	@sTenHanghoa int,
	@sNhacungcap nvarchar(50),
	@iSoluong int,
	@iDongia int,
	@iThoigianbaohanh int )
as begin
	insert into tblHanghoa (FK_iNhomhangID, sTenHanghoa, sNhacungcap, iSoluong, iDongia, iThoigianbaohanh)
	values (@FK_iNhomhangID, @sTenHanghoa, @sNhacungcap, @iSoluong, @iDongia, @iThoigianbaohanh)
	select @PK_iHanghoaID = @@IDENTITY
end
-- update
go
create proc sp_tblHanghoa_Update (
	@PK_iHanghoaID int,
	@FK_iNhomhangID int,
	@sTenHanghoa int,
	@sNhacungcap nvarchar(50),
	@iSoluong int,
	@iDongia int,
	@iThoigianbaohanh int )
as begin
	update tblHanghoa
	set FK_iNhomhangID=@FK_iNhomhangID, sTenHanghoa=@sTenHanghoa, sNhacungcap=@sNhacungcap,
	iSoluong=@iSoluong, iDongia=@iDongia, iThoigianbaohanh=@iThoigianbaohanh
	where PK_iHanghoaID=@PK_iHanghoaID
end
-- delete by PK
go
create proc sp_tblHanghoa_Delete (
	@PK_iHanghoaID int )
as begin
	delete from tblHanghoa where PK_iHanghoaID=@PK_iHanghoaID
end
-- delete by FK
go
create proc sp_tblHanghoa_DeleteByFK (
	@FK_iNhomhangID int )
as begin
	delete from tblHanghoa where FK_iNhomhangID=@FK_iNhomhangID
end

---               Hóa đơn nhập hàng
-- select
go
create proc sp_tblHoadonnhaphang_Select (
	@PK_iHoadonnhaphangID int )
as begin
	if @PK_iHoadonnhaphangID = 0
		select * from tblHoadonnhaphang
	if @PK_iHoadonnhaphangID > 0
		select * from tblHoadonnhaphang where PK_iHoadonnhaphangID=@PK_iHoadonnhaphangID
end
-- select by FK
go
create proc sp_tblHoadonnhaphang_SelectByFK (
	@FK_iNhanvienID int )
as begin
	if @FK_iNhanvienID = 0
		select * from tblHoadonnhaphang
	if @FK_iNhanvienID > 0
		select * from tblHoadonnhaphang where FK_iNhanvienID=@FK_iNhanvienID
end
-- insert
go
create proc sp_tblHoadonnhaphang_Insert (
	@PK_iHoadonnhaphangID int out,
	@FK_iNhanvienID int,
	@dThoigiannhap date,
	@iTongtien int )
as begin
	insert into tblHoadonnhaphang (FK_iNhanvienID, dThoigiannhap, iTongtien)
	values (@FK_iNhanvienID, @dThoigiannhap, @iTongtien)
	select @PK_iHoadonnhaphangID=@@IDENTITY
end
-- update
go
create proc sp_tblHoadonnhaphang_Update (
	@PK_iHoadonnhaphangID int,
	@FK_iNhanvienID int,
	@dThoigiannhap date,
	@iTongtien int )
as begin
	update tblHoadonnhaphang
	set FK_iNhanvienID=@FK_iNhanvienID, dThoigiannhap=@dThoigiannhap, iTongtien=@iTongtien
	where PK_iHoadonnhaphangID=@PK_iHoadonnhaphangID
end
-- delete
go
create proc sp_tblHoadonnhaphang_Delete (
	@PK_iHoadonnhaphang int )
as begin
	delete from tblHoadonnhaphang where PK_iHoadonnhaphangID=@PK_iHoadonnhaphang
end
-- delete by FK
go
create proc sp_tblHoadonnhaphang_DeleteByFK (
	@FK_iNhanvienID int )
as begin
	delete from tblHoadonnhaphang where FK_iNhanvienID=@FK_iNhanvienID
end

---               Mặt hàng nhập
-- select
go
create proc sp_tblHangnhap_Select (
	@FK_iHoadonnhaphangID int,
	@FK_iHanghoaID int )
as begin
	if ( @FK_iHoadonnhaphangID=0 and @FK_iHanghoaID=0 ) select * from tblHangnhap
	else if (@FK_iHoadonnhaphangID=0 and @FK_iHanghoaID>0 ) select * from tblHangnhap where FK_iHanghoaID=@FK_iHanghoaID
	else if (@FK_iHoadonnhaphangID>0 and @FK_iHanghoaID=0 ) select * from tblHangnhap where FK_iHoadonnhaphangID=@FK_iHoadonnhaphangID
	else select * from tblHangnhap where FK_iHoadonnhaphangID=@FK_iHoadonnhaphangID and FK_iHanghoaID=@FK_iHanghoaID
end

-- insert
go
create proc sp_tblHangnhap_Insert (
	@FK_iHoadonnhaphangID int,
	@FK_iHanghoaID int,
	@iSoluongnhap int,
	@iGianhap int,
	@iThanhtien int)
as begin
	insert into tblHangnhap (FK_iHoadonnhaphangID, FK_iHanghoaID, iSoluongnhap, iGianhap, iThanhtien)
	values (@FK_iHoadonnhaphangID, @FK_iHanghoaID, @iSoluongnhap, @iGianhap, @iThanhtien)
end
-- update
go
create proc sp_tblHangnhap_Update(
	@FK_iHoadonnhaphangID int,
	@FK_iHanghoaID int,
	@iSoluongnhap int,
	@iGianhap int,
	@iThanhtien int )
as begin
	update tblHangnhap set
	iSoluongnhap=@iSoluongnhap, iGianhap=@iGianhap, iThanhtien=@iThanhtien
	where FK_iHoadonnhaphangID=@FK_iHoadonnhaphangID and FK_iHanghoaID=@FK_iHanghoaID
end
-- delete
go
create proc sp_tblHangnhap_Delete (
	@FK_iHoadonnhaphangID int,
	@FK_iHanghoaID int )
as begin
	if (@FK_iHoadonnhaphangID=0 and @FK_iHanghoaID>0 ) delete from tblHangnhap where FK_iHanghoaID=@FK_iHanghoaID
	else if (@FK_iHoadonnhaphangID>0 and @FK_iHanghoaID=0 ) delete from tblHangnhap where FK_iHoadonnhaphangID=@FK_iHoadonnhaphangID
	else delete from tblHangnhap where FK_iHoadonnhaphangID=@FK_iHoadonnhaphangID and FK_iHanghoaID=@FK_iHanghoaID
end

---               Hóa đơn bán hàng
-- select
go
create proc sp_tblHoadonbanhang_Select (
	@PK_iHoadonbanhangID int )
as begin
	if @PK_iHoadonbanhangID = 0
		select * from tblHoadonbanhang
	if @PK_iHoadonbanhangID > 0
		select * from tblHoadonbanhang where PK_iHoadonbanhangID = @PK_iHoadonbanhangID
end
-- select by FK
go
create proc sp_tblHoadonbanhang_SelectByFK (
	@FK_iNhanvienID int )
as begin
	if @FK_iNhanvienID = 0
		select * from tblHoadonbanhang
	if @FK_iNhanvienID > 0
		select * from tblHoadonbanhang where FK_iNhanvienID=@FK_iNhanvienID
end
-- insert
go
create proc sp_tblHoadonbanhang_Insert (
	@PK_iHoadonbanhangID int out,
	@FK_iNhanvienID int,
	@sTenKhachhang nvarchar(50),
	@sDiachi nvarchar(50),
	@sSdt nvarchar(50),
	@dThoigianban date,
	@iTongtien int )
as begin
	insert into tblHoadonbanhang(FK_iNhanvienID, sTenKhachhang, sDiachi, sSdt, dThoigianban, iTongtien)
	values (@FK_iNhanvienID, @sTenKhachhang, @sDiachi, @sSdt, @dThoigianban, @iTongtien)
	select @PK_iHoadonbanhangID = @@IDENTITY
end
-- update
go
create proc sp_tblHoadonbanhang_Update (
	@PK_iHoadonbanhangID int,
	@FK_iNhanvienID int,
	@sTenKhachhang nvarchar(50),
	@sDiachi nvarchar(50),
	@sSdt nvarchar(50),
	@dThoigianban date,
	@iTongtien int )
as begin
	update tblHoadonbanhang
	set FK_iNhanvienID = @FK_iNhanvienID, sTenKhachhang = @sTenKhachhang, sDiachi = @sDiachi,
		sSdt = @sSdt, dThoigianban = @dThoigianban, iTongtien = @iTongtien
	where PK_iHoadonbanhangID = @PK_iHoadonbanhangID
end
-- delete
go
create proc sp_tblHoadonbanhang_Delete (
	@PK_iHoadonbanhangID int )
as begin
	delete from tblHoadonbanhang where PK_iHoadonbanhangID = @PK_iHoadonbanhangID
end
-- delete by FK
go
create proc sp_tblHoadonbanhang_DeleteByFK (
	@FK_iNhanvienID int )
as begin
	delete from tblHoadonbanhang where FK_iNhanvienID = @FK_iNhanvienID
end
---               Mặt hàng bán ra
-- select
go
create proc sp_tblHangban_Select (
	@FK_iHoadonbanhangID int,
	@FK_iHanghoaID int )
as begin
	if ( @FK_iHoadonbanhangID=0 and @FK_iHanghoaID=0 ) select * from tblHangban
	else if (@FK_iHoadonbanhangID=0 and @FK_iHanghoaID>0 ) select * from tblHangban where FK_iHanghoaID=@FK_iHanghoaID
	else if (@FK_iHoadonbanhangID>0 and @FK_iHanghoaID=0 ) select * from tblHangban where FK_iHoadonbanhangID=@FK_iHoadonbanhangID
	else select * from tblHangban where FK_iHoadonbanhangID=@FK_iHoadonbanhangID and FK_iHanghoaID=@FK_iHanghoaID
end
-- insert
go
create proc sp_tblHangban_Insert (
	@FK_iHoadonbanhangID int,
	@FK_iHanghoaID int,
	@iSoluongban int,
	@iGiaban int,
	@iThanhtien int )
as begin
	insert into tblHangban( FK_iHoadonbanhangID, FK_iHanghoaID, iSoluongban, iGiaban, iThanhtien)
	values (@FK_iHoadonbanhangID, @FK_iHanghoaID, @iSoluongban, @iGiaban, @iThanhtien)
end
-- update
go
create proc sp_tblHangban_Update (
	@FK_iHoadonbanhangID int,
	@FK_iHanghoaID int,
	@iSoluongban int,
	@iGiaban int,
	@iThanhtien int )
as begin
	update tblHangban
	set iSoluongban = @iSoluongban, iGiaban = @iGiaban, iThanhtien = @iThanhtien
	where tblHangban.FK_iHoadonbanhangID = @FK_iHoadonbanhangID and tblHangban.FK_iHanghoaID = @FK_iHanghoaID
end
-- delete
go
create proc sp_tblHangban_Delete (
	@FK_iHoadonbanhangID int,
	@FK_iHanghoaID int)
as begin
	if (@FK_iHoadonbanhangID=0 and @FK_iHanghoaID>0 ) delete from tblHangban where FK_iHanghoaID=@FK_iHanghoaID
	else if (@FK_iHoadonbanhangID>0 and @FK_iHanghoaID=0 ) delete from tblHangban where FK_iHoadonbanhangID=@FK_iHoadonbanhangID
	else delete from tblHangban where FK_iHoadonbanhangID=@FK_iHoadonbanhangID and FK_iHanghoaID=@FK_iHanghoaID
end

---               Nhân viên
-- select
go
create proc sp_tblNhanvien_Select (
	@PK_iNhanvienID int
)
as begin
	if @PK_iNhanvienID = 0
		select * from tblNhanvien 
	if @PK_iNhanvienID > 0
		select * from tblNhanvien where PK_iNhanvienID = @PK_iNhanvienID
end
-- select user, pass
go
create proc sp_tblNhanvien_Login (
	@sUserNV nvarchar(50),
	@sPassNV nvarchar(50)
)
as begin
	select * from tblNhanvien where sUserNV=@sUserNV and sPassNV=@sPassNV
end

-- insert
go
create proc sp_tblNhanvien_Insert (
	@PK_iNhanvienID int out,
	@sTenNhanvien nvarchar(50),
	@dNgaysinh date,
	@bGioitinh bit,
	@sChucvu nvarchar(50),
	@sUserNV nvarchar(50),
	@sPassNV nvarchar(50)
) as begin
	insert into tblNhanvien (sTenNhanvien,dNgaysinh,bGioitinh,sChucvu,sUserNV,sPassNV)
	values (@sTenNhanvien,@dNgaysinh,@bGioitinh,@sChucvu,@sUserNV,@sPassNV)
	select @PK_iNhanvienID=@@IDENTITY
end
-- update
go
create proc sp_tblNhanvien_Update (
	@PK_iNhanvienID int out,
	@sTenNhanvien nvarchar(50),
	@dNgaysinh date,
	@bGioitinh bit,
	@sChucvu nvarchar(50),
	@sUserNV nvarchar(50),
	@sPassNV nvarchar(50)
) as begin
	update tblNhanvien
	set sTenNhanvien=@sTenNhanvien, dNgaysinh=@dNgaysinh, bGioitinh=@bGioitinh, sChucvu=@sChucvu,
	sUserNV=@sUserNV, sPassNV=@sPassNV
	where PK_iNhanvienID=@PK_iNhanvienID
end
-- delete
go
create proc sp_tblNhanvien_Delete (
	@PK_iNhanvienID int
) as begin
	delete from tblNhanvien where PK_iNhanvienID=@PK_iNhanvienID
end

--------------------------------------------------------------------
/*                     Procedure to Create Report                 */
go
create proc sp_tblHoadonbanhang_CreateReport
as begin 
select 
	PK_iHoadonbanhangID, 
	tblHoadonbanhang.FK_iNhanvienID, 
	tblNhanvien.sTenNhanvien, sTenKhachhang , 
	sDiachi, 
	sSdt, 
	dThoigianban, 
	iTongtien 
from tblHoadonbanhang join tblNhanvien 
	on tblHoadonbanhang.FK_iNhanvienID = tblNhanvien.PK_iNhanvienID
end




----- triggerr

-- khi thêm hàng bán, số lượng hàng trong hàng hóa giảm
go
create trigger tblhanghoa_them
on tblHangban after insert
as begin
	declare @iHanghoaID int, @iSoluongban int
	set @iHanghoaID = (select FK_iHanghoaID from inserted)
	set @iSoluongban = (select iSoluongban from inserted)
	if(exists(select * from tblHanghoa where PK_iHanghoaID=@iHanghoaID))
		begin
			update tblHanghoa
				set iSoluong = iSoluong-@iSoluongban
				where PK_iHanghoaID=@iHanghoaID
		end
end

-- khi xóa hàng bán, số lượng hàng trong hàng hóa tăng
go
create trigger tblhanghoa_xoa
on tblHangban after delete
as begin
	declare @iHanghoaID int, @iSoluongban int
	set @iHanghoaID = (select FK_iHanghoaID from deleted)
	set @iSoluongban = (select iSoluongban from deleted)
	if(exists(select * from tblHanghoa where PK_iHanghoaID=@iHanghoaID))
		begin
			update tblHanghoa
				set iSoluong = iSoluong+@iSoluongban
				where PK_iHanghoaID=@iHanghoaID
		end
end

--go HUNG....

go
create proc select_NhomHang
as
begin
	select * from tblNhomhang
end
--- Search
go
create proc sp_tblNhomhang_Search(
	@sTenNhomhang nvarchar(50))
as begin
	select * from tblNhomhang where sTenNhomhang LIKE N'%'+@sTenNhomhang+'%'
end
----
go
create proc Select_tblHanghoa
as begin
	select tblHanghoa.PK_iHanghoaID,tblHanghoa.sTenHanghoa,tblHanghoa.sNhacungcap,tblNhomhang.sTenNhomhang,tblHanghoa.iSoluong,tblHanghoa.iDongia,tblHanghoa.iThoigianbaohanh  
	from tblHanghoa
	left join tblNhomhang on tblNhomhang.PK_iNhomhangID=tblHanghoa.FK_iNhomhangID
end	
--- Search tên hàng
go
create proc sp_tblHanghoa_Search(
	@sTenHanghoa nvarchar(50))
as begin
	select tblHanghoa.PK_iHanghoaID,tblHanghoa.sTenHanghoa,tblHanghoa.sNhacungcap,tblNhomhang.sTenNhomhang,tblHanghoa.iSoluong,tblHanghoa.iDongia,tblHanghoa.iThoigianbaohanh 
	from tblHanghoa 
	left join tblNhomhang on tblNhomhang.PK_iNhomhangID=tblHanghoa.FK_iNhomhangID
	where sTenHanghoa LIKE N'%'+@sTenHanghoa+'%'
end
--- Search nha cc
go
create proc Search_NhaCC_tblHangHoa(
	@sNhacungcap nvarchar(50))
as begin
	select tblHanghoa.PK_iHanghoaID,tblHanghoa.sTenHanghoa,tblHanghoa.sNhacungcap,tblNhomhang.sTenNhomhang,tblHanghoa.iSoluong,tblHanghoa.iDongia,tblHanghoa.iThoigianbaohanh 
	from tblHanghoa 
	left join tblNhomhang on tblNhomhang.PK_iNhomhangID=tblHanghoa.FK_iNhomhangID
	where sNhacungcap LIKE N'%'+@sNhacungcap+'%'
end