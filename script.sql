USE [master]
GO
/****** Object:  Database [QLCHN]    Script Date: 27/09/2021 10:59:58 pm ******/
CREATE DATABASE [QLCHN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLCHN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLCHN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLCHN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLCHN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLCHN] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLCHN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLCHN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLCHN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLCHN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLCHN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLCHN] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLCHN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLCHN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLCHN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLCHN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLCHN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLCHN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLCHN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLCHN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLCHN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLCHN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLCHN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLCHN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLCHN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLCHN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLCHN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLCHN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLCHN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLCHN] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLCHN] SET  MULTI_USER 
GO
ALTER DATABASE [QLCHN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLCHN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLCHN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLCHN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLCHN] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLCHN] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLCHN] SET QUERY_STORE = OFF
GO
USE [QLCHN]
GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 27/09/2021 10:59:58 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[MaDonHang] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[DonGia] [money] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietDonHang] PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatHang]    Script Date: 27/09/2021 10:59:58 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatHang](
	[MaDonHang] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [int] NOT NULL,
	[NgayDatHang] [date] NOT NULL,
 CONSTRAINT [PK_DatHang] PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 27/09/2021 10:59:58 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nchar](100) NOT NULL,
	[DiaChi] [nchar](100) NOT NULL,
	[SoDienThoai] [nchar](11) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loai]    Script Date: 27/09/2021 10:59:58 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loai](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nchar](50) NOT NULL,
	[MoTa] [nchar](100) NOT NULL,
 CONSTRAINT [PK_Loai] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 27/09/2021 10:59:58 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nchar](100) NOT NULL,
	[DiaChi] [nchar](50) NULL,
	[DienThoai] [nchar](20) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 27/09/2021 10:59:58 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[TenSP] [nchar](40) NOT NULL,
	[MaNCC] [int] NOT NULL,
	[MaLoai] [int] NOT NULL,
	[DonGia] [money] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 27/09/2021 10:59:58 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TaiKhoan] [nchar](20) NOT NULL,
	[MatKhau] [nchar](20) NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (1, 3, 70.0000, 10)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (1, 5, 90.0000, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (1, 7, 60.0000, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (1, 8, 50.0000, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (1, 10, 125.0000, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (1, 11, 30.0000, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (1, 13, 120.0000, 3)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (1, 14, 100.0000, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (1, 16, 100.0000, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (1, 1029, 80.0000, 3)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (2, 4, 80.0000, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (2, 7, 60.0000, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (2, 8, 50.0000, 5)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (2, 13, 120.0000, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (2, 1029, 800000.0000, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (4, 4, 80.0000, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (4, 7, 60.0000, 3)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (4, 10, 125.0000, 1)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (7, 5, 90.0000, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (7, 7, 60.0000, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (7, 9, 90.0000, 2)
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSP], [DonGia], [SoLuong]) VALUES (7, 10, 125.0000, 1)
GO
SET IDENTITY_INSERT [dbo].[DatHang] ON 

INSERT [dbo].[DatHang] ([MaDonHang], [MaKhachHang], [NgayDatHang]) VALUES (1, 1, CAST(N'2021-07-05' AS Date))
INSERT [dbo].[DatHang] ([MaDonHang], [MaKhachHang], [NgayDatHang]) VALUES (2, 4, CAST(N'2021-06-05' AS Date))
INSERT [dbo].[DatHang] ([MaDonHang], [MaKhachHang], [NgayDatHang]) VALUES (4, 8, CAST(N'2021-06-01' AS Date))
INSERT [dbo].[DatHang] ([MaDonHang], [MaKhachHang], [NgayDatHang]) VALUES (5, 4, CAST(N'2021-06-07' AS Date))
INSERT [dbo].[DatHang] ([MaDonHang], [MaKhachHang], [NgayDatHang]) VALUES (6, 4, CAST(N'2021-09-02' AS Date))
INSERT [dbo].[DatHang] ([MaDonHang], [MaKhachHang], [NgayDatHang]) VALUES (7, 8, CAST(N'2021-06-22' AS Date))
SET IDENTITY_INSERT [dbo].[DatHang] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKhachHang], [Ten], [DiaChi], [SoDienThoai]) VALUES (1, N'Nguyễn Ngọc Hậu                                                                                     ', N'Hồ Chí Minh                                                                                         ', N'0903951635 ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [Ten], [DiaChi], [SoDienThoai]) VALUES (2, N'Đặng Thanh Huy                                                                                      ', N'Đà Lạt                                                                                              ', N'0902425432 ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [Ten], [DiaChi], [SoDienThoai]) VALUES (4, N'Trần Gia Huy                                                                                        ', N'Vũng Tàu                                                                                            ', N'0735433247 ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [Ten], [DiaChi], [SoDienThoai]) VALUES (6, N'Trương Quỳnh My                                                                                     ', N'Thủ Đức                                                                                             ', N'21344446234')
INSERT [dbo].[KhachHang] ([MaKhachHang], [Ten], [DiaChi], [SoDienThoai]) VALUES (8, N'Hà My                                                                                               ', N'Phú Quốc                                                                                            ', N'0985436758 ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [Ten], [DiaChi], [SoDienThoai]) VALUES (1010, N'Lê Anh Khoa                                                                                         ', N'Huế                                                                                                 ', N'078654238  ')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[Loai] ON 

INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa]) VALUES (1, N'Thực phẩm chức năng                               ', N'Phục hồi sức khỏe                                                                                   ')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa]) VALUES (2, N'Chăm sóc cá nhân                                  ', N'Đồ dùng cá nhân                                                                                     ')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa]) VALUES (3, N'Sức khỏe hằng ngày                                ', N'Thuốc ho cảm sốt                                                                                    ')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa]) VALUES (4, N'Làm đẹp                                           ', N'Dụng cụ làm đẹp và mỹ phẩm                                                                          ')
SET IDENTITY_INSERT [dbo].[Loai] OFF
GO
SET IDENTITY_INSERT [dbo].[NhaCungCap] ON 

INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [DienThoai]) VALUES (1, N'Hàn                                                                                                 ', N'Seoul                                             ', N'8205845966          ')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [DienThoai]) VALUES (2, N'Mỹ                                                                                                  ', N'Washington, D.C.                                  ', N'	907057689          ')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [DienThoai]) VALUES (3, N'Nhật                                                                                                ', N'Tokyo                                             ', N'81065689765         ')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [DienThoai]) VALUES (4, N'Pháp                                                                                                ', N'Pari                                              ', N'334758697           ')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [DienThoai]) VALUES (5, N'Ý                                                                                                   ', N'Roma                                              ', N'39657486509         ')
SET IDENTITY_INSERT [dbo].[NhaCungCap] OFF
GO
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNCC], [MaLoai], [DonGia], [SoLuong]) VALUES (3, N'Viên uống bổ sung kẽm                   ', 2, 1, 70.0000, 1000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNCC], [MaLoai], [DonGia], [SoLuong]) VALUES (4, N'Kẹo ngậm bổ sung Vitamin C              ', 3, 1, 80.0000, 2000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNCC], [MaLoai], [DonGia], [SoLuong]) VALUES (5, N'Viên uống bổ sung canxi magie và kẽm    ', 1, 1, 90.0000, 800)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNCC], [MaLoai], [DonGia], [SoLuong]) VALUES (6, N'Viên dầu cá Nature Made Fish Oil        ', 4, 1, 55.0000, 5000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNCC], [MaLoai], [DonGia], [SoLuong]) VALUES (7, N'Chăm sóc răng miệng                     ', 5, 2, 60.0000, 500)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNCC], [MaLoai], [DonGia], [SoLuong]) VALUES (8, N'Dụng cụ cạo râu                         ', 2, 2, 50.0000, 2500)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNCC], [MaLoai], [DonGia], [SoLuong]) VALUES (9, N'Viên giảm đau và ngăn ngừa nhồi máu     ', 4, 3, 90.0000, 7000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNCC], [MaLoai], [DonGia], [SoLuong]) VALUES (10, N'Dầu gió trắng Con Ó của Mỹ              ', 5, 3, 125.0000, 400)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNCC], [MaLoai], [DonGia], [SoLuong]) VALUES (11, N'Viên uống giảm ho long đờm              ', 1, 3, 30.0000, 600)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNCC], [MaLoai], [DonGia], [SoLuong]) VALUES (12, N'Kem dưỡng ẩm chống lão hoá              ', 3, 4, 46.0000, 900)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNCC], [MaLoai], [DonGia], [SoLuong]) VALUES (13, N'Set dầu gội và xả chống rụng tóc        ', 3, 4, 120.0000, 600)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNCC], [MaLoai], [DonGia], [SoLuong]) VALUES (14, N'Viên uống trắng da Relumins             ', 5, 4, 100.0000, 1500)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNCC], [MaLoai], [DonGia], [SoLuong]) VALUES (16, N'Viên uống bổ sung kẽm  C                ', 2, 1, 30.0000, 4000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaNCC], [MaLoai], [DonGia], [SoLuong]) VALUES (1029, N'Sửa rửa mặt                             ', 4, 2, 80.0000, 200)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
GO
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau]) VALUES (N'ngochau             ', N'hau                 ')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau]) VALUES (N'thanhhuy            ', N'456huy              ')
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_DatHang] FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[DatHang] ([MaDonHang])
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_DatHang]
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_SanPham]
GO
ALTER TABLE [dbo].[DatHang]  WITH CHECK ADD  CONSTRAINT [FK_DatHang_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[DatHang] CHECK CONSTRAINT [FK_DatHang_KhachHang]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_Loai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[Loai] ([MaLoai])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_Loai]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_NhaCungCap]
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraSPDonHang]    Script Date: 27/09/2021 10:59:58 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[sp_KiemTraSPDonHang] @MaDH int, @MaSP int
as 
begin 
	set nocount on
	declare @sl int 
	select @sl = count(*) from [ChiTietDonHang]
	where MaDonHang = @MaDH and MaSP = @MaSP
	select @sl as alias
end
GO
/****** Object:  StoredProcedure [dbo].[sp_TimSP]    Script Date: 27/09/2021 10:59:58 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_TimSP] @ma int
as 
begin
	set nocount on
	select *
	from [SanPham]
	where MaSP  = @ma
end
GO
USE [master]
GO
ALTER DATABASE [QLCHN] SET  READ_WRITE 
GO
