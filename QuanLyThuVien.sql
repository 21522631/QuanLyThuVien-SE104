--DROP DATABASE QuanLyThuVien
CREATE DATABASE QuanLyThuVien
go
USE QuanLyThuVien
CREATE TABLE NHOMNGUOIDUNG
(
	ID int IDENTITY(1,1) primary key,
	MaNhomNguoiDung AS CAST('NND' + right('000' + CAST(ID as varchar(5)), 3) AS CHAR(6)),
	TenNhomNguoiDung nvarchar(255) NOT NULL
)

go
CREATE TABLE CHUCNANG
(
     ID int  primary key IDENTITY(1,1),
	 MaChucNang AS CAST('CN' + right('000' + CAST(ID as varchar(3)), 3) as char(5)),
     TenChucNang NVARCHAR(255) NOT NULL,
     TenManHinh NVARCHAR(255) NOT NULL
)

go
CREATE TABLE PHANQUYEN
(
    IDNhomNguoiDung INT FOREIGN KEY REFERENCES NHOMNGUOIDUNG on delete cascade,
    IDChucNang INT FOREIGN KEY REFERENCES CHUCNANG on delete cascade,
    PRIMARY KEY (IDNhomNguoiDung, IDChucNang)
)

go
CREATE TABLE NGUOIDUNG
(
	ID INT IDENTITY PRIMARY KEY,
	MaNguoiDung  AS CAST('ND'+ RIGHT('000000' + CAST(ID AS VARCHAR(4)), 4) AS CHAR(6)),
    TenNguoiDung NVARCHAR(MAX) NOT NULL,
    NgaySinh DATE,
    ChucVu NVARCHAR(MAX),
    TenDangNhap VARCHAR(256) UNIQUE NOT NULL,
    MatKhau VARCHAR(MAX) NOT NULL,
    IDNhomNguoiDung INT REFERENCES NHOMNGUOIDUNG on delete cascade NOT NULL
)

go
CREATE TABLE THELOAI
(
	ID int IDENTITY(1,1)  primary key,
	MaTheLoai As Cast('TL' + right('0000' + CAST(ID as varchar(4)), 4) as char(6)) persisted,  
	TenTheLoai NVARCHAR(MAX) NOT NULL
)

go
CREATE TABLE DAUSACH
(
	ID INT IDENTITY  PRIMARY KEY,
	MaDauSach  AS cast('DS'+ right('0000' + CAST(ID AS VARCHAR(10)), 4) as char(6)) PERSISTED,
	TenDauSach NVARCHAR(MAX) NOT NULL,
	IDTheLoai int references THELOAI NOT NULL,
)

go
CREATE TABLE TACGIA
(
	ID INT IDENTITY PRIMARY KEY,
	MATACGIA  AS CAST('TG'+ RIGHT('0000' + CAST(ID AS VARCHAR(10)), 4) AS CHAR(6))PERSISTED,
	TenTacGia NVARCHAR(MAX) NOT NULL
)

go
CREATE TABLE CT_TACGIA
(
	IDTacGia int references TACGIA  on delete cascade,
	IDTuaSach int references DAUSACH on delete cascade,
	primary key (IDTacGia, IDTuaSach)
)

go
CREATE TABLE SACH
(
	ID int IDENTITY(1,1) primary key,
	MaSach AS CAST('S'+ RIGHT('00000' + CAST(ID AS VARCHAR(10)), 5) AS CHAR(6)),
	IDTuaSach int references DAUSACH NOT NULL, 
	SoLuong int NOT NULL, 
	SoLuongConLai int NOT NULL, 
	DonGia int NOT NULL, 
	NamXB int NOT NULL, 
	NhaXB NVARCHAR(MAX) NOT NULL,
	DaAn int NOT NULL DEFAULT 0
)

go
create table CUONSACH
(
	ID int IDENTITY(1,1) primary key,
	MaCuonSach AS CAST('CS'+ RIGHT('0000' + CAST(ID AS VARCHAR(10)), 4) AS CHAR(6)) ,
	IDSach int references SACH NOT NULL,
	TinhTrang INT NOT NULL DEFAULT 1,
)

go
CREATE TABLE PHIEUNHAPSACH
(
	SoPhieuNhap int IDENTITY(1,1) primary key,
	TongTien int NOT NULL DEFAULT 0, 
	NgayNhap Datetime NOT NULL
)

go
CREATE TABLE CT_PHIEUNHAP
(
	SoPhieuNhap int references PHIEUNHAPSACH(SoPhieuNhap),
	IDSach int references SACH,
	DonGia int NOT NULL, 
	ThanhTien int NOT NULL, 
	SoLuongNhap int NOT NULL, 
	primary key (SoPhieuNhap, IDSach)
)

go
CREATE TABLE LOAIDOCGIA
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	MaLoaiDocGia  AS CAST('LDG'+ RIGHT('000' + CAST(ID AS VARCHAR(10)), 3) AS CHAR(6)),
	TenLoaiDocGia NVARCHAR(MAX) NOT NULL
)

go
CREATE TABLE DOCGIA
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	MaDocGia  AS CAST('DG'+ RIGHT('0000' + CAST(ID AS VARCHAR(10)), 4) AS CHAR(6)),
	TenDocGia NVARCHAR(MAX) NOT NULL,
	NgaySinh datetime NOT NULL, 
	DiaChi NVARCHAR(MAX),
	Email VARCHAR(MAX),
	NgayLapThe Datetime NOT NULL, 
	NgayHetHan Datetime NOT NULL, 
	IDLoaiDocGia INT references LOAIDOCGIA NOT NULL, 
	TongNoHienTai int NOT NULL DEFAULT 0,
	IDNguoiDung INT REFERENCES NGUOIDUNG UNIQUE NOT NULL
)

go
create table PHIEUMUONTRA
(
	SoPhieuMuonTra int IDENTITY(1,1) primary key,
	IDDocGia int references DOCGIA NOT NULL,
	IDCuonSach int references CUONSACH NOT NULL,
	NgayMuon Datetime NOT NULL, 
	NgayTra Datetime, 
	HanTra Datetime NOT NULL,
	SoTienPhat int DEFAULT 0
)

go
create table PHIEUTHUTIENPHAT
(
	SoPhieuThuTienPhat int IDENTITY(1,1) primary key,
	IDDocGia int references DOCGIA NOT NULL,
	SoTienThu int NOT NULL DEFAULT 0,
	NgayLap datetime NOT NULL
)

go
create table BCLUOTMUONTHEOTHELOAI
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Thang int NOT NULL, 
	Nam int NOT NULL, 
	MaBaoCao AS CAST('BCLM' + RIGHT('0' + CAST(THANG AS CHAR(2)), 2) + CAST(NAM AS CHAR(4)) AS CHAR(10)) 
				PERSISTED,
	TongSoLuotMuon int NOT NULL DEFAULT 0
)

go
create table CT_BCLUOTMUONTHEOTHELOAI
(
	IDBaoCao INT references BCLUOTMUONTHEOTHELOAI,
	IDTheLoai int references THELOAI,
	SoLuotMuon int NOT NULL DEFAULT 0, 
	TiLe numeric(4,2) DEFAULT 0,
	primary key (IDBaoCao, IDTheLoai)
)
go
create table BCSACHTRATRE
(
	Ngay datetime not null,
	IDCuonSach int references CUONSACH on delete cascade,
	NgayMuon datetime NOT NULL,
	SoNgayTre int NOT NULL DEFAULT 0
	primary key(Ngay, IDCuonSach)
)
go
CREATE TABLE THAMSO
(
	ID int identity(1,1) primary key,
	TuoiToiThieu int NOT NULL, 
	TuoiToiDa int NOT NULL, 
	ThoiHanThe int NOT NULL, 
	KhoangCachXuatBan int NOT NULL , 
	SoSachMuonToiDa int NOT NULL, 
	SoNgayMuonToiDa int NOT NULL, 
	DonGiaPhat int NOT NULL,
	AD_QDKTTienThu int NOT NULL
)
