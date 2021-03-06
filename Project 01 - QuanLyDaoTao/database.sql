USE [DB-QuanLyDaoTao]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 1/21/2022 8:08:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BangDiem]    Script Date: 1/21/2022 8:08:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangDiem](
	[ID] [uniqueidentifier] NOT NULL,
	[HocVienID] [uniqueidentifier] NOT NULL,
	[ThiCuID] [uniqueidentifier] NOT NULL,
	[DanhMucID] [uniqueidentifier] NOT NULL,
	[DiemThi] [real] NULL,
	[GhiChu] [nvarchar](1024) NULL,
	[Xoa] [bit] NOT NULL,
 CONSTRAINT [PK_BangDiem] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaoLuu]    Script Date: 1/21/2022 8:08:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoLuu](
	[ID] [uniqueidentifier] NOT NULL,
	[NgayBaoLuu] [datetime] NULL,
	[LyDo] [nvarchar](1024) NULL,
	[DonBaoLuu] [nvarchar](400) NULL,
	[MaLopMoi] [varchar](1) NULL,
	[Ghichu] [nvarchar](1024) NULL,
	[LopHocID] [uniqueidentifier] NOT NULL,
	[HocVienID] [uniqueidentifier] NOT NULL,
	[Xoa] [bit] NOT NULL,
 CONSTRAINT [PK_BaoLuu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BoTriPhongHoc]    Script Date: 1/21/2022 8:08:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoTriPhongHoc](
	[ID] [uniqueidentifier] NOT NULL,
	[NgayBatDau] [datetime] NULL,
	[NgayKetThuc] [datetime] NULL,
	[GhiChu] [nvarchar](1024) NULL,
	[LopHocID] [uniqueidentifier] NOT NULL,
	[PhongHocID] [uniqueidentifier] NOT NULL,
	[Xoa] [bit] NOT NULL,
 CONSTRAINT [PK_BoTriPhongHoc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuongTrinhDaoTao]    Script Date: 1/21/2022 8:08:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuongTrinhDaoTao](
	[ID] [uniqueidentifier] NOT NULL,
	[MaCT] [nvarchar](32) NULL,
	[TenCT] [nvarchar](256) NULL,
	[HocPhi] [money] NULL,
	[NgayBanHanh] [datetime] NULL,
	[NoiDungCT] [nvarchar](400) NULL,
	[QDBanHanh] [nvarchar](400) NULL,
	[GhiChu] [nvarchar](1024) NULL,
	[TrangThai] [int] NULL,
	[Xoa] [bit] NULL,
 CONSTRAINT [PK_ChuongTrinhDaoTao] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DMMonHoc]    Script Date: 1/21/2022 8:08:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DMMonHoc](
	[ID] [uniqueidentifier] NOT NULL,
	[MonHocID] [uniqueidentifier] NOT NULL,
	[KhungCTID] [uniqueidentifier] NOT NULL,
	[HinhThucThi] [nvarchar](128) NULL,
	[GhiChu] [nvarchar](1024) NULL,
	[Xoa] [bit] NOT NULL,
 CONSTRAINT [PK_DMMonHoc_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FileUploaded]    Script Date: 1/21/2022 8:08:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FileUploaded](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenTep] [nvarchar](200) NOT NULL,
	[NoiLuuTru] [nvarchar](500) NOT NULL,
	[DoiTuongID] [uniqueidentifier] NOT NULL,
	[STTTep] [int] NOT NULL,
	[Xoa] [bit] NOT NULL,
 CONSTRAINT [PK_FileUploaded] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 1/21/2022 8:08:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[ID] [uniqueidentifier] NOT NULL,
	[MaGV] [varchar](32) NULL,
	[HoTen] [nvarchar](128) NULL,
	[DiaChi] [nvarchar](256) NULL,
	[SDT] [varchar](16) NULL,
	[Email] [varchar](64) NULL,
	[DonViCongTac] [nvarchar](256) NULL,
	[MaSoThue] [varchar](16) NULL,
	[TrinhDo] [nvarchar](128) NULL,
	[BangCap] [nvarchar](400) NULL,
	[ChungChi] [nvarchar](400) NULL,
	[Xoa] [bit] NOT NULL,
 CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocVien]    Script Date: 1/21/2022 8:08:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocVien](
	[ID] [uniqueidentifier] NOT NULL,
	[MaHV] [varchar](32) NOT NULL,
	[HoTen] [nvarchar](128) NULL,
	[GioiTinh] [nvarchar](12) NULL,
	[NgaySinh] [datetime] NULL,
	[NoiSinh] [nvarchar](128) NULL,
	[SDT] [varchar](16) NULL,
	[DiaChi] [nvarchar](256) NULL,
	[Email] [varchar](64) NULL,
	[HinhAnh] [nvarchar](400) NULL,
	[TrinhDo] [nvarchar](64) NULL,
	[NgheNghiep] [nvarchar](128) NULL,
	[DonViCongTac] [nvarchar](256) NULL,
	[ChucVu] [nvarchar](128) NULL,
	[SoQDHocNghe] [varchar](64) NULL,
	[SoSoBHXH] [varchar](32) NULL,
	[HotenNBT] [nvarchar](128) NULL,
	[SDTNBT] [varchar](16) NULL,
	[GhiChu] [nvarchar](1024) NULL,
	[LopHocID] [uniqueidentifier] NOT NULL,
	[Xoa] [bit] NOT NULL,
 CONSTRAINT [PK_HocVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhungCT]    Script Date: 1/21/2022 8:08:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhungCT](
	[ID] [uniqueidentifier] NOT NULL,
	[MaKhungCT] [varchar](32) NOT NULL,
	[GhiChu] [nvarchar](1024) NULL,
	[NhanVienID] [uniqueidentifier] NULL,
	[LopHocID] [uniqueidentifier] NOT NULL,
	[Xoa] [bit] NOT NULL,
 CONSTRAINT [PK_KhungCT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhungGioHoc]    Script Date: 1/21/2022 8:08:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhungGioHoc](
	[ID] [uniqueidentifier] NOT NULL,
	[MaKhungGio] [varchar](32) NOT NULL,
	[GioBatDau] [datetime] NULL,
	[GioKetThuc] [datetime] NULL,
	[GhiChu] [nvarchar](1024) NULL,
	[DanhMucID] [uniqueidentifier] NOT NULL,
	[HopDongID] [uniqueidentifier] NOT NULL,
	[Xoa] [bit] NOT NULL,
 CONSTRAINT [PK_KhungGioHoc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopHoc]    Script Date: 1/21/2022 8:08:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHoc](
	[ID] [uniqueidentifier] NOT NULL,
	[MaLop] [nvarchar](32) NOT NULL,
	[NgayKhaiGiang] [datetime] NULL,
	[NgayKetThuc] [datetime] NULL,
	[SoLuongHV] [int] NULL,
	[QDMoLop] [nvarchar](400) NULL,
	[ThoiKhoaBieu] [nvarchar](400) NULL,
	[GhiChu] [nvarchar](1024) NULL,
	[CTDaoTaoID] [uniqueidentifier] NOT NULL,
	[Xoa] [bit] NOT NULL,
 CONSTRAINT [PK_LopHoc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 1/21/2022 8:08:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[ID] [uniqueidentifier] NOT NULL,
	[MaMonHoc] [varchar](32) NOT NULL,
	[TenMonHoc] [nvarchar](256) NULL,
	[Sogio] [int] NULL,
	[GhiChu] [nvarchar](1024) NULL,
	[CTDaoTaoID] [uniqueidentifier] NOT NULL,
	[Xoa] [bit] NOT NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongHoc]    Script Date: 1/21/2022 8:08:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongHoc](
	[ID] [uniqueidentifier] NOT NULL,
	[MaPhong] [varchar](32) NOT NULL,
	[TenPhong] [nvarchar](256) NULL,
	[SoMayTinh] [int] NULL,
	[Ghichu] [nvarchar](1024) NULL,
	[Xoa] [bit] NOT NULL,
 CONSTRAINT [PK_PhongHoc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLChungChi]    Script Date: 1/21/2022 8:08:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLChungChi](
	[ID] [uniqueidentifier] NOT NULL,
	[SoHieuCC] [varchar](32) NOT NULL,
	[TrangThai] [bit] NULL,
	[NgayNhan] [datetime] NULL,
	[NhanVienID] [uniqueidentifier] NULL,
	[LopHocID] [uniqueidentifier] NOT NULL,
	[HocVienID] [uniqueidentifier] NOT NULL,
	[Xoa] [bit] NOT NULL,
 CONSTRAINT [PK_QLChungChi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleClaims]    Script Date: 1/21/2022 8:08:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_RoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 1/21/2022 8:08:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThiCu]    Script Date: 1/21/2022 8:08:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThiCu](
	[ID] [uniqueidentifier] NOT NULL,
	[MaThi] [varchar](32) NOT NULL,
	[LanThi] [int] NULL,
	[NgayThi] [datetime] NULL,
	[HinhThucThi] [nvarchar](128) NULL,
	[MaDeThi] [varchar](32) NULL,
	[SLThamDu] [int] NULL,
	[SLVang] [int] NULL,
	[BienBan] [nvarchar](400) NULL,
	[MaNV] [varchar](32) NULL,
	[DanhMucID] [uniqueidentifier] NOT NULL,
	[Xoa] [bit] NOT NULL,
 CONSTRAINT [PK_ThiCu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThoiKhoaBieu]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThoiKhoaBieu](
	[ID] [uniqueidentifier] NOT NULL,
	[Thu] [nvarchar](64) NULL,
	[Ghichu] [nvarchar](1024) NULL,
	[KhungGioID] [uniqueidentifier] NOT NULL,
	[LopHocID] [uniqueidentifier] NOT NULL,
	[Xoa] [bit] NOT NULL,
 CONSTRAINT [PK_ThoiKhoaBieu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongTinHD]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinHD](
	[ID] [uniqueidentifier] NOT NULL,
	[MaHopDong] [varchar](32) NOT NULL,
	[GiangVienID] [uniqueidentifier] NOT NULL,
	[SoGio] [int] NULL,
	[ThuLao] [int] NULL,
	[NgayKy] [datetime] NULL,
	[NgayThanhLy] [datetime] NULL,
	[HopDongGD] [nvarchar](400) NULL,
	[HopDongTL] [nvarchar](400) NULL,
	[MaNVLamHD] [varchar](1) NULL,
	[MaNVTLHD] [varchar](1) NULL,
	[DanhMucID] [uniqueidentifier] NOT NULL,
	[Xoa] [bit] NOT NULL,
 CONSTRAINT [PK_ThongTinHD] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserClaims]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLogins]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_UserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [nvarchar](450) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[ConfirmPassword] [nvarchar](max) NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTokens]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220120152320_v0.1', N'5.0.12')
GO
INSERT [dbo].[BangDiem] ([ID], [HocVienID], [ThiCuID], [DanhMucID], [DiemThi], [GhiChu], [Xoa]) VALUES (N'cd9e8968-906d-4182-9fff-2f9b24c48d23', N'70aeaf1b-3406-440c-a6dc-33b4f109406c', N'9547b3e9-556a-4626-93d3-5a579da10a20', N'543e2d2d-7af6-4461-afaf-ed35c4bdfa5b', 10, NULL, 1)
INSERT [dbo].[BangDiem] ([ID], [HocVienID], [ThiCuID], [DanhMucID], [DiemThi], [GhiChu], [Xoa]) VALUES (N'd413c205-3eaf-4f87-b003-8c2185436403', N'ef3b90b7-a8e0-4dbb-9823-94cdd8299b28', N'9547b3e9-556a-4626-93d3-5a579da10a20', N'543e2d2d-7af6-4461-afaf-ed35c4bdfa5b', 7, NULL, 0)
GO
INSERT [dbo].[BaoLuu] ([ID], [NgayBaoLuu], [LyDo], [DonBaoLuu], [MaLopMoi], [Ghichu], [LopHocID], [HocVienID], [Xoa]) VALUES (N'85c32f34-87c8-4a6c-ab4e-59e4447ef5f5', CAST(N'2020-01-01T00:00:00.000' AS DateTime), N'KHONG', N'donbaoluuu.docx', NULL, NULL, N'2767125b-7784-4293-92fc-1fa85ac0771c', N'1328699a-2ec6-4200-9b1f-ee1d6a637b75', 0)
INSERT [dbo].[BaoLuu] ([ID], [NgayBaoLuu], [LyDo], [DonBaoLuu], [MaLopMoi], [Ghichu], [LopHocID], [HocVienID], [Xoa]) VALUES (N'387f6181-856e-46a6-8070-b973febf243d', CAST(N'2020-02-01T00:00:00.000' AS DateTime), NULL, N'donbaoluuu.docx', NULL, NULL, N'2767125b-7784-4293-92fc-1fa85ac0771c', N'ef3b90b7-a8e0-4dbb-9823-94cdd8299b28', 0)
GO
INSERT [dbo].[BoTriPhongHoc] ([ID], [NgayBatDau], [NgayKetThuc], [GhiChu], [LopHocID], [PhongHocID], [Xoa]) VALUES (N'8cbd6df1-fd43-4b31-b08b-53a35ba0e421', CAST(N'2022-01-01T00:00:00.000' AS DateTime), CAST(N'2022-04-01T00:00:00.000' AS DateTime), NULL, N'2767125b-7784-4293-92fc-1fa85ac0771c', N'f4680ce0-1c20-4222-89a0-04d950251e6c', 0)
INSERT [dbo].[BoTriPhongHoc] ([ID], [NgayBatDau], [NgayKetThuc], [GhiChu], [LopHocID], [PhongHocID], [Xoa]) VALUES (N'986ca1b2-1151-4352-84a9-696a897d5caa', CAST(N'2022-02-01T00:00:00.000' AS DateTime), CAST(N'2022-07-01T00:00:00.000' AS DateTime), N'EDITED', N'2767578b-7784-4293-92fc-1fa85ac0771c', N'c2841b14-7d4e-4b72-bdcb-1972ec8174d1', 0)
GO
INSERT [dbo].[ChuongTrinhDaoTao] ([ID], [MaCT], [TenCT], [HocPhi], [NgayBanHanh], [NoiDungCT], [QDBanHanh], [GhiChu], [TrangThai], [Xoa]) VALUES (N'30dd425d-ee2f-11db-8314-0800200c9a66', N'CTDTN', N'Đào tạo nghề', 2000000.0000, CAST(N'2021-06-12T00:00:00.000' AS DateTime), N'daotaonghe.pdf', N'quyetdinh.pdf', NULL, 0, 1)
INSERT [dbo].[ChuongTrinhDaoTao] ([ID], [MaCT], [TenCT], [HocPhi], [NgayBanHanh], [NoiDungCT], [QDBanHanh], [GhiChu], [TrangThai], [Xoa]) VALUES (N'30dd879c-ee2f-11db-8314-0800200c9a66', N'CTNH', N'Chương trình ngắn hạn', 1000000.0000, CAST(N'2021-10-11T00:00:00.000' AS DateTime), N'noidungct.pdf', N'qdbanhahnh.pdf', NULL, 0, 1)
INSERT [dbo].[ChuongTrinhDaoTao] ([ID], [MaCT], [TenCT], [HocPhi], [NgayBanHanh], [NoiDungCT], [QDBanHanh], [GhiChu], [TrangThai], [Xoa]) VALUES (N'c3911632-0553-46c8-b423-27559ef2457b', N'TEST01', N'Chương trình thử nghiệm', 100000.0000, CAST(N'2022-01-01T00:00:00.000' AS DateTime), N'Logo_Do.png', N'Logo_Do.png', NULL, 1, 1)
INSERT [dbo].[ChuongTrinhDaoTao] ([ID], [MaCT], [TenCT], [HocPhi], [NgayBanHanh], [NoiDungCT], [QDBanHanh], [GhiChu], [TrangThai], [Xoa]) VALUES (N'9f7118c4-16e5-445e-8a46-3d9e94c224cb', N'231', N'312', 31.0000, CAST(N'2022-01-08T00:00:00.000' AS DateTime), N'noidungct2.docx', N'noidungct (3).docx', NULL, 0, 1)
INSERT [dbo].[ChuongTrinhDaoTao] ([ID], [MaCT], [TenCT], [HocPhi], [NgayBanHanh], [NoiDungCT], [QDBanHanh], [GhiChu], [TrangThai], [Xoa]) VALUES (N'0f8fad5b-d9cb-469f-a165-70867728950e', N'DTCBCC', N'Đào tạo cho CBCC', 1500000.0000, CAST(N'2021-01-01T00:00:00.000' AS DateTime), N'cbcc.pdf', N'quyetidnh02.pdf', NULL, 0, 1)
INSERT [dbo].[ChuongTrinhDaoTao] ([ID], [MaCT], [TenCT], [HocPhi], [NgayBanHanh], [NoiDungCT], [QDBanHanh], [GhiChu], [TrangThai], [Xoa]) VALUES (N'3d3b4ad7-d5f1-4100-b740-903c7951acae', N'LTVQT', N'LTV Quốc tế', 1200000.0000, CAST(N'2022-01-01T00:00:00.000' AS DateTime), N'Untitled.pdf', N'Untitled.pdf', NULL, 1, 1)
INSERT [dbo].[ChuongTrinhDaoTao] ([ID], [MaCT], [TenCT], [HocPhi], [NgayBanHanh], [NoiDungCT], [QDBanHanh], [GhiChu], [TrangThai], [Xoa]) VALUES (N'c1a459fe-a82e-47ce-811f-a884074a0777', N'231', N'3122', 123232.0000, CAST(N'2022-01-14T00:00:00.000' AS DateTime), N'qdbanhanh3.docx', N'qdbanhanh (1).docx', NULL, 0, 1)
INSERT [dbo].[ChuongTrinhDaoTao] ([ID], [MaCT], [TenCT], [HocPhi], [NgayBanHanh], [NoiDungCT], [QDBanHanh], [GhiChu], [TrangThai], [Xoa]) VALUES (N'7d3539bf-bbe7-4b24-bc4e-c8339044dcd9', N'ÐTCBCC', N'Đào tạo cho CBCC', 10000000.0000, CAST(N'2022-01-01T00:00:00.000' AS DateTime), N'noidungct2.docx', N'qdbanhanh2.docx', N'0', 0, 0)
INSERT [dbo].[ChuongTrinhDaoTao] ([ID], [MaCT], [TenCT], [HocPhi], [NgayBanHanh], [NoiDungCT], [QDBanHanh], [GhiChu], [TrangThai], [Xoa]) VALUES (N'51b8d48b-101e-4965-b7a9-d46a7daaf385', N'LTVQT', N'LTV Quốc tế', 10000000.0000, CAST(N'2022-01-01T00:00:00.000' AS DateTime), N'noidungct.docx', N'qdbanhanh.docx', NULL, 0, 0)
INSERT [dbo].[ChuongTrinhDaoTao] ([ID], [MaCT], [TenCT], [HocPhi], [NgayBanHanh], [NoiDungCT], [QDBanHanh], [GhiChu], [TrangThai], [Xoa]) VALUES (N'956ee6a5-0442-4387-b3d4-eb8ed2428629', N'CTNH', N'Chương trình ngắn hạn', 2000000.0000, CAST(N'2022-01-01T00:00:00.000' AS DateTime), N'noidungct3.docx', N'qdbanhanh3.docx', NULL, 0, 0)
INSERT [dbo].[ChuongTrinhDaoTao] ([ID], [MaCT], [TenCT], [HocPhi], [NgayBanHanh], [NoiDungCT], [QDBanHanh], [GhiChu], [TrangThai], [Xoa]) VALUES (N'36955442-0bb7-4ae3-ac6b-fbe155a0be1e', N'212', N'212', 21.0000, CAST(N'2022-01-20T00:00:00.000' AS DateTime), N'noidungct2.docx', N'noidungct (7).docx', NULL, 0, 1)
GO
INSERT [dbo].[DMMonHoc] ([ID], [MonHocID], [KhungCTID], [HinhThucThi], [GhiChu], [Xoa]) VALUES (N'543e2d2d-7af6-4461-afaf-ed35c4bdfa5b', N'464ed4ad-dc1c-4535-b89e-79f506430e06', N'cbd3bdff-5839-45cf-8ec5-fcde9fe2c5ab', N'Lý thuy?t', NULL, 0)
GO
SET IDENTITY_INSERT [dbo].[FileUploaded] ON 

INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (65, N'Logo_Do.png', N'\files\ChuongTrinhDaoTao\Logo_Do.png', N'62ba2415-d8be-494d-b4fd-15c3f21dd7d3', 1, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (66, N'Logo_Do.png', N'\files\ChuongTrinhDaoTao\Logo_Do.png', N'62ba2415-d8be-494d-b4fd-15c3f21dd7d3', 2, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (67, N'noidungct.docx', N'\files\ChuongTrinhDaoTao\noidungct.docx', N'51b8d48b-101e-4965-b7a9-d46a7daaf385', 1, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (68, N'qdbanhanh.docx', N'\files\ChuongTrinhDaoTao\qdbanhanh.docx', N'51b8d48b-101e-4965-b7a9-d46a7daaf385', 2, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (69, N'noidungct.docx', N'\files\ChuongTrinhDaoTao\noidungct.docx', N'956ee6a5-0442-4387-b3d4-eb8ed2428629', 1, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (70, N'qdbanhanh.docx', N'\files\ChuongTrinhDaoTao\qdbanhanh.docx', N'956ee6a5-0442-4387-b3d4-eb8ed2428629', 2, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (71, N'Diagram DB-QuanLyDaoTao.pdf', N'\files\ChuongTrinhDaoTao\Diagram DB-QuanLyDaoTao.pdf', N'7d3539bf-bbe7-4b24-bc4e-c8339044dcd9', 1, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (72, N'Diagram DB-QuanLyDaoTao.jpg.pdf', N'\files\ChuongTrinhDaoTao\Diagram DB-QuanLyDaoTao.jpg.pdf', N'7d3539bf-bbe7-4b24-bc4e-c8339044dcd9', 2, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (73, N'Logo_Do.png', N'\files\ChuongTrinhDaoTao\Logo_Do.png', N'c3911632-0553-46c8-b423-27559ef2457b', 1, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (74, N'Logo_Do.png', N'\files\ChuongTrinhDaoTao\Logo_Do.png', N'c3911632-0553-46c8-b423-27559ef2457b', 2, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (75, N'noidungct2.docx', N'\files\ChuongTrinhDaoTao\noidungct2.docx', N'c7b50f46-8465-4424-a9e7-9f92e393e67c', 1, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (76, N'Giaodien_CongBao.docx', N'\files\ChuongTrinhDaoTao\Giaodien_CongBao.docx', N'c7b50f46-8465-4424-a9e7-9f92e393e67c', 2, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (77, N'noidungct2.docx', N'\files\ChuongTrinhDaoTao\noidungct2.docx', N'873bd146-db23-4d4c-b267-706534ca763e', 1, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (78, N'noidungct2.docx', N'\files\ChuongTrinhDaoTao\noidungct2.docx', N'873bd146-db23-4d4c-b267-706534ca763e', 2, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (79, N'noidungct2.docx', N'\files\LopHoc\noidungct2.docx', N'1eec9ead-b404-43f0-8c93-f81ccdc439fa', 1, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (80, N'noidungct (3).docx', N'\files\LopHoc\noidungct (3).docx', N'1eec9ead-b404-43f0-8c93-f81ccdc439fa', 2, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (81, N'noidungct (4).docx', N'\files\LopHoc\noidungct (4).docx', N'92ed7f94-29a5-4500-b293-e0a1e535d248', 1, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (82, N'noidungct (1).docx', N'\files\LopHoc\noidungct (1).docx', N'92ed7f94-29a5-4500-b293-e0a1e535d248', 2, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (83, N'noidungct2.docx', N'\files\ChuongTrinhDaoTao\noidungct2.docx', N'a8f5e05c-ce53-4234-8e38-e96b338a51b9', 1, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (84, N'noidungct (4).docx', N'\files\ChuongTrinhDaoTao\noidungct (4).docx', N'a8f5e05c-ce53-4234-8e38-e96b338a51b9', 2, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (85, N'noidungct (4).docx', N'\files\ChuongTrinhDaoTao\noidungct (4).docx', N'b2f2aed1-95d3-43af-a801-7792e4192684', 1, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (86, N'noidungct2.docx', N'\files\ChuongTrinhDaoTao\noidungct2.docx', N'b2f2aed1-95d3-43af-a801-7792e4192684', 2, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (87, N'noidungct2.docx', N'\files\ChuongTrinhDaoTao\noidungct2.docx', N'34869cb6-0ec6-4383-8f94-15877e777201', 1, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (88, N'noidungct (2).docx', N'\files\ChuongTrinhDaoTao\noidungct (2).docx', N'34869cb6-0ec6-4383-8f94-15877e777201', 2, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (89, N'qdbanhanh (1).docx', N'\files\ChuongTrinhDaoTao\qdbanhanh (1).docx', N'7f2fbd74-5d59-4e8a-a59f-7a6326c4c2c1', 1, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (90, N'noidungct (2).docx', N'\files\ChuongTrinhDaoTao\noidungct (2).docx', N'7f2fbd74-5d59-4e8a-a59f-7a6326c4c2c1', 2, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (91, N'qdbanhanh3.docx', N'\files\ChuongTrinhDaoTao\qdbanhanh3.docx', N'b69031cb-b180-4aff-bb7f-df87d31a3805', 1, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (92, N'noidungct (4).docx', N'\files\ChuongTrinhDaoTao\noidungct (4).docx', N'b69031cb-b180-4aff-bb7f-df87d31a3805', 2, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (93, N'noidungct2.docx', N'\files\ChuongTrinhDaoTao\noidungct2.docx', N'9f7118c4-16e5-445e-8a46-3d9e94c224cb', 1, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (94, N'noidungct (3).docx', N'\files\ChuongTrinhDaoTao\noidungct (3).docx', N'9f7118c4-16e5-445e-8a46-3d9e94c224cb', 2, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (95, N'qdbanhanh3.docx', N'\files\ChuongTrinhDaoTao\qdbanhanh3.docx', N'c1a459fe-a82e-47ce-811f-a884074a0777', 1, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (96, N'qdbanhanh (1).docx', N'\files\ChuongTrinhDaoTao\qdbanhanh (1).docx', N'c1a459fe-a82e-47ce-811f-a884074a0777', 2, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (97, N'qdbanhanh (1).docx', N'\files\LopHoc\qdbanhanh (1).docx', N'e08fdc1d-83c7-4ecc-a457-5854051d4c85', 1, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (98, N'noidungct (6).docx', N'\files\LopHoc\noidungct (6).docx', N'e08fdc1d-83c7-4ecc-a457-5854051d4c85', 2, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (99, N'noidungct (4).docx', N'\files\LopHoc\noidungct (4).docx', N'15a08525-c064-4601-b67b-d7093694aad7', 1, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (100, N'qdbanhanh2.docx', N'\files\LopHoc\qdbanhanh2.docx', N'15a08525-c064-4601-b67b-d7093694aad7', 2, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (101, N'noidungct2.docx', N'\files\ChuongTrinhDaoTao\noidungct2.docx', N'36955442-0bb7-4ae3-ac6b-fbe155a0be1e', 1, 0)
INSERT [dbo].[FileUploaded] ([ID], [TenTep], [NoiLuuTru], [DoiTuongID], [STTTep], [Xoa]) VALUES (102, N'noidungct (7).docx', N'\files\ChuongTrinhDaoTao\noidungct (7).docx', N'36955442-0bb7-4ae3-ac6b-fbe155a0be1e', 2, 0)
SET IDENTITY_INSERT [dbo].[FileUploaded] OFF
GO
INSERT [dbo].[GiangVien] ([ID], [MaGV], [HoTen], [DiaChi], [SDT], [Email], [DonViCongTac], [MaSoThue], [TrinhDo], [BangCap], [ChungChi], [Xoa]) VALUES (N'535023e9-c7b0-4dbb-9bd0-6f659aa4c854', N'202GV00001', N'Tran Van Chinh', N'100 Dang Huy Tru', N'0866666642', N'huyhbt@gmail.com', N'Truong Quoc Hoc', N'01234564789', N'Cao Dang', N'bangcap.pdf', N'chungchi.pdf', 0)
GO
INSERT [dbo].[HocVien] ([ID], [MaHV], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [SDT], [DiaChi], [Email], [HinhAnh], [TrinhDo], [NgheNghiep], [DonViCongTac], [ChucVu], [SoQDHocNghe], [SoSoBHXH], [HotenNBT], [SDTNBT], [GhiChu], [LopHocID], [Xoa]) VALUES (N'70aeaf1b-3406-440c-a6dc-33b4f109406c', N'CTPT0003', N'Nguyen Van D', N'Nam', CAST(N'1999-02-02T00:00:00.000' AS DateTime), N'VietNam', N'845612315616', N'54 Hai Ba Trung', N'a@gmail.com', N'anh.jpg', N'Dai Hoc', N'Giang Vien', N'Truong HBT', N'Chuyen Vien', N'0845612302424', N'0845612302424', N'Nguyen Van A', N'935715999', NULL, N'2767125b-7784-4293-92fc-1fa85ac0771c', 0)
INSERT [dbo].[HocVien] ([ID], [MaHV], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [SDT], [DiaChi], [Email], [HinhAnh], [TrinhDo], [NgheNghiep], [DonViCongTac], [ChucVu], [SoQDHocNghe], [SoSoBHXH], [HotenNBT], [SDTNBT], [GhiChu], [LopHocID], [Xoa]) VALUES (N'ef3b90b7-a8e0-4dbb-9823-94cdd8299b28', N'CTPT0002', N'Nguyen Van C', N'Nam', CAST(N'1999-02-02T00:00:00.000' AS DateTime), N'VietNam', N'845612315616', N'54 Hai Ba Trung', N'a@gmail.com', N'anh.jpg', N'Dai Hoc', N'Giang Vien', N'Truong HBT', N'Chuyen Vien', N'0845612302424', N'0845612302424', N'Nguyen Van A', N'935715999', NULL, N'2767125b-7784-4293-92fc-1fa85ac0771c', 0)
INSERT [dbo].[HocVien] ([ID], [MaHV], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [SDT], [DiaChi], [Email], [HinhAnh], [TrinhDo], [NgheNghiep], [DonViCongTac], [ChucVu], [SoQDHocNghe], [SoSoBHXH], [HotenNBT], [SDTNBT], [GhiChu], [LopHocID], [Xoa]) VALUES (N'1328699a-2ec6-4200-9b1f-ee1d6a637b75', N'CTPT0001', N'Nguyen Van B', N'Nam', CAST(N'1999-02-02T00:00:00.000' AS DateTime), N'VietNam', N'845612315616', N'54 Hai Ba Trung', N'a@gmail.com', N'anh.jpg', N'Dai Hoc', N'Giang Vien', N'Truong HBT', N'Chuyen Vien', N'0845612302424', N'0845612302424', N'Nguyen Van A', N'935715999', NULL, N'2767125b-7784-4293-92fc-1fa85ac0771c', 0)
GO
INSERT [dbo].[KhungCT] ([ID], [MaKhungCT], [GhiChu], [NhanVienID], [LopHocID], [Xoa]) VALUES (N'5d958657-326b-4808-bddb-a61534b6d0da', N'KCTCL002', NULL, NULL, N'2767578b-7784-4293-92fc-1fa85ac0771c', 0)
INSERT [dbo].[KhungCT] ([ID], [MaKhungCT], [GhiChu], [NhanVienID], [LopHocID], [Xoa]) VALUES (N'cbd3bdff-5839-45cf-8ec5-fcde9fe2c5ab', N'KCTCL001', NULL, NULL, N'2767125b-7784-4293-92fc-1fa85ac0771c', 0)
GO
INSERT [dbo].[KhungGioHoc] ([ID], [MaKhungGio], [GioBatDau], [GioKetThuc], [GhiChu], [DanhMucID], [HopDongID], [Xoa]) VALUES (N'9b1ef2ef-f21d-4fd6-9727-b439ad683ebd', N'Khung001', CAST(N'2021-01-01T12:00:00.000' AS DateTime), CAST(N'2021-06-01T12:00:00.000' AS DateTime), NULL, N'543e2d2d-7af6-4461-afaf-ed35c4bdfa5b', N'60d4e078-73cd-44b2-93c4-dd519948113a', 0)
GO
INSERT [dbo].[LopHoc] ([ID], [MaLop], [NgayKhaiGiang], [NgayKetThuc], [SoLuongHV], [QDMoLop], [ThoiKhoaBieu], [GhiChu], [CTDaoTaoID], [Xoa]) VALUES (N'2767125b-7784-4293-92fc-1fa85ac0771c', N'CL001', CAST(N'2021-12-15T00:00:00.000' AS DateTime), CAST(N'2021-12-16T00:00:00.000' AS DateTime), 15, N'quyetdinh.docx', N'tkb.txt', NULL, N'30dd425d-ee2f-11db-8314-0800200c9a66', 0)
INSERT [dbo].[LopHoc] ([ID], [MaLop], [NgayKhaiGiang], [NgayKetThuc], [SoLuongHV], [QDMoLop], [ThoiKhoaBieu], [GhiChu], [CTDaoTaoID], [Xoa]) VALUES (N'2767578b-7784-4293-92fc-1fa85ac0771c', N'CL002', CAST(N'2021-12-15T00:00:00.000' AS DateTime), CAST(N'2021-12-16T00:00:00.000' AS DateTime), 30, N'quyetdinh.docx', N'tkb.txt', NULL, N'0f8fad5b-d9cb-469f-a165-70867728950e', 0)
INSERT [dbo].[LopHoc] ([ID], [MaLop], [NgayKhaiGiang], [NgayKetThuc], [SoLuongHV], [QDMoLop], [ThoiKhoaBieu], [GhiChu], [CTDaoTaoID], [Xoa]) VALUES (N'e08fdc1d-83c7-4ecc-a457-5854051d4c85', N'312', CAST(N'2022-01-20T00:00:00.000' AS DateTime), CAST(N'2022-01-20T00:00:00.000' AS DateTime), 86, N'qdbanhanh (1).docx', N'noidungct (6).docx', NULL, N'7d3539bf-bbe7-4b24-bc4e-c8339044dcd9', 1)
INSERT [dbo].[LopHoc] ([ID], [MaLop], [NgayKhaiGiang], [NgayKetThuc], [SoLuongHV], [QDMoLop], [ThoiKhoaBieu], [GhiChu], [CTDaoTaoID], [Xoa]) VALUES (N'15a08525-c064-4601-b67b-d7093694aad7', N'21', CAST(N'2022-01-20T00:00:00.000' AS DateTime), CAST(N'2022-01-20T00:00:00.000' AS DateTime), 1, N'noidungct (4).docx', N'qdbanhanh2.docx', NULL, N'51b8d48b-101e-4965-b7a9-d46a7daaf385', 1)
INSERT [dbo].[LopHoc] ([ID], [MaLop], [NgayKhaiGiang], [NgayKetThuc], [SoLuongHV], [QDMoLop], [ThoiKhoaBieu], [GhiChu], [CTDaoTaoID], [Xoa]) VALUES (N'92ed7f94-29a5-4500-b293-e0a1e535d248', N'10', CAST(N'2022-01-20T00:00:00.000' AS DateTime), CAST(N'2022-01-20T00:00:00.000' AS DateTime), 10, N'noidungct (4).docx', N'noidungct (1).docx', NULL, N'7d3539bf-bbe7-4b24-bc4e-c8339044dcd9', 1)
GO
INSERT [dbo].[MonHoc] ([ID], [MaMonHoc], [TenMonHoc], [Sogio], [GhiChu], [CTDaoTaoID], [Xoa]) VALUES (N'54c867e7-79bd-475b-8319-147ade481e97', N'MH005', N'TinHoc', 120, NULL, N'3d3b4ad7-d5f1-4100-b740-903c7951acae', 1)
INSERT [dbo].[MonHoc] ([ID], [MaMonHoc], [TenMonHoc], [Sogio], [GhiChu], [CTDaoTaoID], [Xoa]) VALUES (N'44c3632a-2b18-4beb-8fea-2f689cc3fbae', N'MH001', N'TinHocDaiCuong', 10, NULL, N'30dd425d-ee2f-11db-8314-0800200c9a66', 0)
INSERT [dbo].[MonHoc] ([ID], [MaMonHoc], [TenMonHoc], [Sogio], [GhiChu], [CTDaoTaoID], [Xoa]) VALUES (N'464ed4ad-dc1c-4535-b89e-79f506430e06', N'MH002', N'PhuongPhapTinh', 120, NULL, N'0f8fad5b-d9cb-469f-a165-70867728950e', 0)
INSERT [dbo].[MonHoc] ([ID], [MaMonHoc], [TenMonHoc], [Sogio], [GhiChu], [CTDaoTaoID], [Xoa]) VALUES (N'c147707b-7aee-41b1-ac8f-af0a5203c9af', N'MH00', N'Van Hoc', 3, NULL, N'3d3b4ad7-d5f1-4100-b740-903c7951acae', 0)
INSERT [dbo].[MonHoc] ([ID], [MaMonHoc], [TenMonHoc], [Sogio], [GhiChu], [CTDaoTaoID], [Xoa]) VALUES (N'e9ce3035-4c1f-4cb6-91fd-d724fb8b22bb', N'MH003', N'KinhTeHoc', 140, NULL, N'0f8fad5b-d9cb-469f-a165-70867728950e', 0)
GO
INSERT [dbo].[PhongHoc] ([ID], [MaPhong], [TenPhong], [SoMayTinh], [Ghichu], [Xoa]) VALUES (N'f4680ce0-1c20-4222-89a0-04d950251e6c', N'PH002', N'Phong Thuc Hanh 2', 20, NULL, 0)
INSERT [dbo].[PhongHoc] ([ID], [MaPhong], [TenPhong], [SoMayTinh], [Ghichu], [Xoa]) VALUES (N'c2841b14-7d4e-4b72-bdcb-1972ec8174d1', N'PH003', N'Phong Thuc Hanh 3', 25, NULL, 0)
INSERT [dbo].[PhongHoc] ([ID], [MaPhong], [TenPhong], [SoMayTinh], [Ghichu], [Xoa]) VALUES (N'fd01c84f-c6e9-4ae4-ac32-8d0b6c67657d', N'PH001', N'Phong Thuc Hanh 1', 20, NULL, 0)
GO
INSERT [dbo].[QLChungChi] ([ID], [SoHieuCC], [TrangThai], [NgayNhan], [NhanVienID], [LopHocID], [HocVienID], [Xoa]) VALUES (N'2cb61888-42b1-4f2f-8a9b-4c34b1aaef32', N'CC0001', 0, CAST(N'2022-01-01T00:00:00.000' AS DateTime), NULL, N'2767578b-7784-4293-92fc-1fa85ac0771c', N'1328699a-2ec6-4200-9b1f-ee1d6a637b75', 0)
INSERT [dbo].[QLChungChi] ([ID], [SoHieuCC], [TrangThai], [NgayNhan], [NhanVienID], [LopHocID], [HocVienID], [Xoa]) VALUES (N'15d2d6d7-fe90-4cb7-bbf7-6ad10c5c7021', N'CC0001', 0, CAST(N'2022-01-01T00:00:00.000' AS DateTime), NULL, N'2767578b-7784-4293-92fc-1fa85ac0771c', N'ef3b90b7-a8e0-4dbb-9823-94cdd8299b28', 0)
GO
INSERT [dbo].[ThiCu] ([ID], [MaThi], [LanThi], [NgayThi], [HinhThucThi], [MaDeThi], [SLThamDu], [SLVang], [BienBan], [MaNV], [DanhMucID], [Xoa]) VALUES (N'9547b3e9-556a-4626-93d3-5a579da10a20', N'THi0004', 1, CAST(N'2020-01-01T00:00:00.000' AS DateTime), N'Thuc Hanh', N'DE001', 30, 1, N'bienbang.pdf', NULL, N'543e2d2d-7af6-4461-afaf-ed35c4bdfa5b', 0)
GO
INSERT [dbo].[ThoiKhoaBieu] ([ID], [Thu], [Ghichu], [KhungGioID], [LopHocID], [Xoa]) VALUES (N'6817bac1-223a-4f6c-9571-3aea37b0f7da', N'T', NULL, N'9b1ef2ef-f21d-4fd6-9727-b439ad683ebd', N'2767578b-7784-4293-92fc-1fa85ac0771c', 0)
GO
INSERT [dbo].[ThongTinHD] ([ID], [MaHopDong], [GiangVienID], [SoGio], [ThuLao], [NgayKy], [NgayThanhLy], [HopDongGD], [HopDongTL], [MaNVLamHD], [MaNVTLHD], [DanhMucID], [Xoa]) VALUES (N'60d4e078-73cd-44b2-93c4-dd519948113a', N'HD00001', N'535023e9-c7b0-4dbb-9bd0-6f659aa4c854', 150, 150, CAST(N'2021-01-01T00:00:00.000' AS DateTime), CAST(N'2021-01-01T00:00:00.000' AS DateTime), N'hopdong.pdf', N'hopdong.pdf', NULL, NULL, N'543e2d2d-7af6-4461-afaf-ed35c4bdfa5b', 0)
GO
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Password], [ConfirmPassword], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'be6fff83-d48e-4534-a3c9-84bb7ff2f0b3', N'Huynh Duc Quang', N'Huy', N'Abc@123', N'Abc@123', N'admin', N'ADMIN', N'huyhbt@gmail.com', N'HUYHBT@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEDluL3DEL+RifhUGQpykKsoGr/u+Q/LnsIDmSl/EmTKOVS/aGQAeWmk3k/R4GiG2hA==', N'3FPMBUG7HYGH7DDEPANY5EU5QUAIWORB', N'6574f50d-822a-4617-b510-9d0661d004fc', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Password], [ConfirmPassword], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'c39b899e-a8d4-41a3-9618-f115cfc890fc', N'A', N'Nguyen Van', N'Host@123', N'Host@123', N'host', N'HOST', N'nguyenvana@gmail.com', N'NGUYENVANA@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEFJEbNPFzNgwxxS1oAEpWpMxGEd7Ve3uFjd9eIVfdI/goTtgLCyrCmqFoNIcPZ8FCA==', N'YVOF7RE4YKYJSD32AKOOQUTH3ADFHWUY', N'aa23a863-4f3d-4588-b6c2-a86bd3a81f91', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Password], [ConfirmPassword], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'e6f8553a-f6ba-4cff-8834-4d281f7c147f', N'Nguyen Thị', N'B', N'Abc@123', N'Abc@123', N'huy@123', N'HUY@123', N'b@gmail.com', N'B@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEOleBltil4cKkuKB1TyOpUrSBH6oTiQThmd7h0m1p5hk/iYOZjo6ff7Y51QlFbASwA==', N'BP6DAPQDKS6L7EE37COXI2ZWJKXWI37M', N'576f6827-406c-4879-b631-7cb95492a9e1', NULL, 0, 0, NULL, 1, 0)
GO
ALTER TABLE [dbo].[BangDiem] ADD  CONSTRAINT [DF_BangDiem_ID]  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[BaoLuu] ADD  CONSTRAINT [DF_BaoLuu_ID]  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[BoTriPhongHoc] ADD  CONSTRAINT [DF_BoTriPhongHoc_ID]  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[DMMonHoc] ADD  CONSTRAINT [DF_DMMonHoc_ID]  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[GiangVien] ADD  CONSTRAINT [DF_GiangVien_ID]  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[HocVien] ADD  CONSTRAINT [DF_HocVien_ID]  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[KhungCT] ADD  CONSTRAINT [DF_KhungCT_ID]  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[KhungGioHoc] ADD  CONSTRAINT [DF_KhungGioHoc_ID]  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[MonHoc] ADD  CONSTRAINT [DF_MonHoc_ID]  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[PhongHoc] ADD  CONSTRAINT [DF_PhongHoc_ID]  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[QLChungChi] ADD  CONSTRAINT [DF_QLChungChi_ID]  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[ThiCu] ADD  CONSTRAINT [DF_ThiCu_ID]  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[ThoiKhoaBieu] ADD  CONSTRAINT [DF_ThoiKhoaBieu_ID]  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[ThongTinHD] ADD  CONSTRAINT [DF_ThongTinHD_ID]  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_DMMonHoc] FOREIGN KEY([DanhMucID])
REFERENCES [dbo].[DMMonHoc] ([ID])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_DMMonHoc]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_HocVien] FOREIGN KEY([HocVienID])
REFERENCES [dbo].[HocVien] ([ID])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_HocVien]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_ThiCu] FOREIGN KEY([ThiCuID])
REFERENCES [dbo].[ThiCu] ([ID])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_ThiCu]
GO
ALTER TABLE [dbo].[BaoLuu]  WITH CHECK ADD  CONSTRAINT [FK_BaoLuu_HocVien] FOREIGN KEY([HocVienID])
REFERENCES [dbo].[HocVien] ([ID])
GO
ALTER TABLE [dbo].[BaoLuu] CHECK CONSTRAINT [FK_BaoLuu_HocVien]
GO
ALTER TABLE [dbo].[BaoLuu]  WITH CHECK ADD  CONSTRAINT [FK_BaoLuu_LopHoc] FOREIGN KEY([LopHocID])
REFERENCES [dbo].[LopHoc] ([ID])
GO
ALTER TABLE [dbo].[BaoLuu] CHECK CONSTRAINT [FK_BaoLuu_LopHoc]
GO
ALTER TABLE [dbo].[BoTriPhongHoc]  WITH CHECK ADD  CONSTRAINT [FK_BoTriPhongHoc_LopHoc] FOREIGN KEY([LopHocID])
REFERENCES [dbo].[LopHoc] ([ID])
GO
ALTER TABLE [dbo].[BoTriPhongHoc] CHECK CONSTRAINT [FK_BoTriPhongHoc_LopHoc]
GO
ALTER TABLE [dbo].[BoTriPhongHoc]  WITH CHECK ADD  CONSTRAINT [FK_BoTriPhongHoc_PhongHoc] FOREIGN KEY([PhongHocID])
REFERENCES [dbo].[PhongHoc] ([ID])
GO
ALTER TABLE [dbo].[BoTriPhongHoc] CHECK CONSTRAINT [FK_BoTriPhongHoc_PhongHoc]
GO
ALTER TABLE [dbo].[DMMonHoc]  WITH CHECK ADD  CONSTRAINT [FK_DMMonHoc_KhungCT1] FOREIGN KEY([KhungCTID])
REFERENCES [dbo].[KhungCT] ([ID])
GO
ALTER TABLE [dbo].[DMMonHoc] CHECK CONSTRAINT [FK_DMMonHoc_KhungCT1]
GO
ALTER TABLE [dbo].[DMMonHoc]  WITH CHECK ADD  CONSTRAINT [FK_DMMonHoc_MonHoc1] FOREIGN KEY([MonHocID])
REFERENCES [dbo].[MonHoc] ([ID])
GO
ALTER TABLE [dbo].[DMMonHoc] CHECK CONSTRAINT [FK_DMMonHoc_MonHoc1]
GO
ALTER TABLE [dbo].[HocVien]  WITH CHECK ADD  CONSTRAINT [FK_HocVien_LopHoc] FOREIGN KEY([LopHocID])
REFERENCES [dbo].[LopHoc] ([ID])
GO
ALTER TABLE [dbo].[HocVien] CHECK CONSTRAINT [FK_HocVien_LopHoc]
GO
ALTER TABLE [dbo].[KhungCT]  WITH CHECK ADD  CONSTRAINT [FK_KhungCT_LopHoc] FOREIGN KEY([LopHocID])
REFERENCES [dbo].[LopHoc] ([ID])
GO
ALTER TABLE [dbo].[KhungCT] CHECK CONSTRAINT [FK_KhungCT_LopHoc]
GO
ALTER TABLE [dbo].[KhungGioHoc]  WITH CHECK ADD  CONSTRAINT [FK_KhungGioHoc_DMMonHoc1] FOREIGN KEY([DanhMucID])
REFERENCES [dbo].[DMMonHoc] ([ID])
GO
ALTER TABLE [dbo].[KhungGioHoc] CHECK CONSTRAINT [FK_KhungGioHoc_DMMonHoc1]
GO
ALTER TABLE [dbo].[KhungGioHoc]  WITH CHECK ADD  CONSTRAINT [FK_KhungGioHoc_ThongTinHD] FOREIGN KEY([HopDongID])
REFERENCES [dbo].[ThongTinHD] ([ID])
GO
ALTER TABLE [dbo].[KhungGioHoc] CHECK CONSTRAINT [FK_KhungGioHoc_ThongTinHD]
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD  CONSTRAINT [FK_LopHoc_ChuongTrinhDaoTao] FOREIGN KEY([CTDaoTaoID])
REFERENCES [dbo].[ChuongTrinhDaoTao] ([ID])
GO
ALTER TABLE [dbo].[LopHoc] CHECK CONSTRAINT [FK_LopHoc_ChuongTrinhDaoTao]
GO
ALTER TABLE [dbo].[MonHoc]  WITH CHECK ADD  CONSTRAINT [FK_MonHoc_ChuongTrinhDaoTao] FOREIGN KEY([CTDaoTaoID])
REFERENCES [dbo].[ChuongTrinhDaoTao] ([ID])
GO
ALTER TABLE [dbo].[MonHoc] CHECK CONSTRAINT [FK_MonHoc_ChuongTrinhDaoTao]
GO
ALTER TABLE [dbo].[QLChungChi]  WITH CHECK ADD  CONSTRAINT [FK_QLChungChi_HocVien] FOREIGN KEY([HocVienID])
REFERENCES [dbo].[HocVien] ([ID])
GO
ALTER TABLE [dbo].[QLChungChi] CHECK CONSTRAINT [FK_QLChungChi_HocVien]
GO
ALTER TABLE [dbo].[QLChungChi]  WITH CHECK ADD  CONSTRAINT [FK_QLChungChi_LopHoc] FOREIGN KEY([LopHocID])
REFERENCES [dbo].[LopHoc] ([ID])
GO
ALTER TABLE [dbo].[QLChungChi] CHECK CONSTRAINT [FK_QLChungChi_LopHoc]
GO
ALTER TABLE [dbo].[RoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_RoleClaims_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RoleClaims] CHECK CONSTRAINT [FK_RoleClaims_Roles_RoleId]
GO
ALTER TABLE [dbo].[ThiCu]  WITH CHECK ADD  CONSTRAINT [FK_ThiCu_DMMonHoc1] FOREIGN KEY([DanhMucID])
REFERENCES [dbo].[DMMonHoc] ([ID])
GO
ALTER TABLE [dbo].[ThiCu] CHECK CONSTRAINT [FK_ThiCu_DMMonHoc1]
GO
ALTER TABLE [dbo].[ThoiKhoaBieu]  WITH CHECK ADD  CONSTRAINT [FK_ThoiKhoaBieu_KhungGioHoc] FOREIGN KEY([KhungGioID])
REFERENCES [dbo].[KhungGioHoc] ([ID])
GO
ALTER TABLE [dbo].[ThoiKhoaBieu] CHECK CONSTRAINT [FK_ThoiKhoaBieu_KhungGioHoc]
GO
ALTER TABLE [dbo].[ThongTinHD]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinHD_DMMonHoc1] FOREIGN KEY([DanhMucID])
REFERENCES [dbo].[DMMonHoc] ([ID])
GO
ALTER TABLE [dbo].[ThongTinHD] CHECK CONSTRAINT [FK_ThongTinHD_DMMonHoc1]
GO
ALTER TABLE [dbo].[ThongTinHD]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinHD_GiangVien1] FOREIGN KEY([GiangVienID])
REFERENCES [dbo].[GiangVien] ([ID])
GO
ALTER TABLE [dbo].[ThongTinHD] CHECK CONSTRAINT [FK_ThongTinHD_GiangVien1]
GO
ALTER TABLE [dbo].[UserClaims]  WITH CHECK ADD  CONSTRAINT [FK_UserClaims_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserClaims] CHECK CONSTRAINT [FK_UserClaims_Users_UserId]
GO
ALTER TABLE [dbo].[UserLogins]  WITH CHECK ADD  CONSTRAINT [FK_UserLogins_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserLogins] CHECK CONSTRAINT [FK_UserLogins_Users_UserId]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Roles_RoleId]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Users_UserId]
GO
ALTER TABLE [dbo].[UserTokens]  WITH CHECK ADD  CONSTRAINT [FK_UserTokens_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserTokens] CHECK CONSTRAINT [FK_UserTokens_Users_UserId]
GO
/****** Object:  StoredProcedure [dbo].[SPBangDiem_ChinhSua]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 17.01.2022
-- Description:	Stored Procedures chỉnh sửa bảng điểm
-- =============================================
CREATE PROCEDURE [dbo].[SPBangDiem_ChinhSua]
		   @ID uniqueidentifier,
           @HocVienID uniqueidentifier,
           @ThiCuID uniqueidentifier,
           @DanhMucID uniqueidentifier,
           @DiemThi real,
           @GhiChu nvarchar(1024)

AS
BEGIN

UPDATE [dbo].[BangDiem]
   SET [ID] = @ID
      ,[HocVienID] = @HocVienID
      ,[ThiCuID] = @ThiCuID
      ,[DanhMucID] = @DanhMucID
      ,[DiemThi] = @DiemThi
      ,[GhiChu] = @GhiChu
 WHERE ID = @ID

END

--SELECT * FROM BangDiem

--EXEC SPBangDiem_ChinhSua 
--		   @ID = 'CD9E8968-906D-4182-9FFF-2F9B24C48D23',
--           @HocVienID = '70AEAF1B-3406-440C-A6DC-33B4F109406C',
--           @ThiCuID = '9547B3E9-556A-4626-93D3-5A579DA10A20',
--           @DanhMucID = '543E2D2D-7AF6-4461-AFAF-ED35C4BDFA5B',
--           @DiemThi = 10,
--           @GhiChu = NULL
GO
/****** Object:  StoredProcedure [dbo].[SPBangDiem_DanhSach]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 17.01.2022
-- Description:	Stored Procedures Danh sach Bang Diem
-- =============================================
CREATE PROCEDURE [dbo].[SPBangDiem_DanhSach]
		   @CTDaoTaoID uniqueidentifier,
		   @LopHocID uniqueidentifier,
		   @HocVienID uniqueidentifier,
		   @MonHocID uniqueidentifier

AS
BEGIN

SELECT bd.ID, ct.MaCT, lh.MaLop, hv.HoTen, mh.MaMonHoc, mh.TenMonHoc, bd.DiemThi, tc.LanThi
  FROM	BangDiem as bd, DMMonHoc as dm, MonHoc as mh, HocVien as hv,
		ThiCu as tc, ChuongTrinhDaoTao as ct, KhungCT as kct,LopHoc as lh
  WHERE bd.DanhMucID = dm.ID
  AND  dm.MonHocID = mh.ID
  and bd.ThiCuID = tc.ID
  and mh.CTDaoTaoID = ct.ID
  and dm.KhungCTID = kct.ID
  and kct.LopHocID = lh.ID
  and bd.HocVienID = hv.ID
  and bd.Xoa = 0
  and (@CTDaoTaoID IS NULL OR @CTDaoTaoID = ct.ID)
  and (@LopHocID IS NULL OR @LopHocID = lh.ID)
  and (@HocVienID IS NULL OR @HocVienID = hv.ID)
  and (@MonHocID IS NULL OR @MonHocID = mh.ID)

END

--select * from BangDiem
--select * from DMMonHoc
--select * from ThiCu
--select * from LopHoc
--EXEC [SPBangDiem_DanhSach] @CTDaoTaoID = null, @LopHocID = null, @HocVienID = null, @MonHocID = null
GO
/****** Object:  StoredProcedure [dbo].[SPBangDiem_LayID]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 17.01.2022
-- Description:	Stored Procedures lấy thông tin bảng điểm theo ID
-- =============================================
CREATE PROCEDURE [dbo].[SPBangDiem_LayID]
		   @ID uniqueidentifier

AS
BEGIN

SELECT [ID]
      ,[HocVienID]
      ,[ThiCuID]
      ,[DanhMucID]
      ,[DiemThi]
      ,[GhiChu]
  FROM [dbo].[BangDiem]
  WHERE ID = @ID AND Xoa = 0

END

--SELECT * FROM BangDiem

--EXEC SPBangDiem_LayID @ID = 'D413C205-3EAF-4F87-B003-8C2185436403'
GO
/****** Object:  StoredProcedure [dbo].[SPBangDiem_TaoMoi]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 17.01.2022
-- Description:	Stored Procedures tao moi Bang Diem
-- =============================================
CREATE PROCEDURE [dbo].[SPBangDiem_TaoMoi]
           @HocVienID uniqueidentifier,
           @ThiCuID uniqueidentifier,
           @DanhMucID uniqueidentifier,
           @DiemThi real,
           @GhiChu nvarchar(1024)
AS
BEGIN

INSERT INTO [dbo].[BangDiem]
           ([HocVienID]
           ,[ThiCuID]
           ,[DanhMucID]
           ,[DiemThi]
           ,[GhiChu]
           ,[Xoa])
     VALUES
           (@HocVienID
           ,@ThiCuID
           ,@DanhMucID
           ,@DiemThi
           ,@GhiChu
           ,0)

END

--select * from BangDiem

--select * from HocVien

--select * from ThiCu

--select * from DMMonHoc

--exec SPBangDiem_TaoMoi
--            @HocVienID = 'EF3B90B7-A8E0-4DBB-9823-94CDD8299B28'
--           ,@ThiCuID = '9547B3E9-556A-4626-93D3-5A579DA10A20'
--           ,@DanhMucID = '543E2D2D-7AF6-4461-AFAF-ED35C4BDFA5B'
--           ,@DiemThi = 7
--           ,@GhiChu = null
GO
/****** Object:  StoredProcedure [dbo].[SPBangDiem_Xoa]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures xoá Khung chương trình
-- =============================================
CREATE PROCEDURE [dbo].[SPBangDiem_Xoa]
	@ID UNIQUEIDENTIFIER
AS
BEGIN
	DECLARE @Result BIT = 0
	BEGIN TRY
		UPDATE dbo.BangDiem
		SET Xoa  = 1
		WHERE ID = @ID;
	SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result
END

--SELECT * FROM BangDiem
--EXEC SPBangDiem_Xoa @ID = 'CD9E8968-906D-4182-9FFF-2F9B24C48D23'
 
GO
/****** Object:  StoredProcedure [dbo].[SPBaoLuu_ChinhSua]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 17.01.2022
-- Description:	Stored Procedures for edit dbo.BaoLuu
-- =============================================
CREATE PROCEDURE [dbo].[SPBaoLuu_ChinhSua]
           @ID uniqueidentifier,
		   @NgayBaoLuu datetime,
           @LyDo nvarchar(1024),
           @DonBaoLuu nvarchar(400),
           @MaLopMoi varchar(1),
           @Ghichu nvarchar(1024),
           @LopHocID uniqueidentifier,
           @HocVienID uniqueidentifier
AS
BEGIN

UPDATE [dbo].[BaoLuu]
   SET [NgayBaoLuu] = @NgayBaoLuu
      ,[LyDo] = @LyDo
      ,[DonBaoLuu] = @DonBaoLuu
      ,[MaLopMoi] = @MaLopMoi
      ,[Ghichu] = @Ghichu
      ,[LopHocID] = @LopHocID
      ,[HocVienID] = @HocVienID
 WHERE ID = @ID

END

--SELECT * FROM BaoLuu

--EXEC SPBaoLuu_ChinhSua 
--		   @ID = '85C32F34-87C8-4A6C-AB4E-59E4447EF5F5',
--		   @NgayBaoLuu = '2020-01-01 00:00:00.000',
--           @LyDo = 'KHONG',
--           @DonBaoLuu = 'donbaoluuu.docx',
--           @MaLopMoi = NULL,
--           @Ghichu = NULL,
--           @LopHocID = '2767125B-7784-4293-92FC-1FA85AC0771C',
--           @HocVienID = '1328699A-2EC6-4200-9B1F-EE1D6A637B75'
GO
/****** Object:  StoredProcedure [dbo].[SPBaoLuu_DanhSach]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for Bao luu
-- =============================================
CREATE PROCEDURE [dbo].[SPBaoLuu_DanhSach]
           @ID uniqueidentifier

AS
BEGIN

SELECT bl.ID,lh.MaLop,hv.MaHV,hv.HoTen, bl.NgayBaoLuu, bl.LyDo, bl.MaLopMoi
  FROM BaoLuu as bl, LopHoc as lh, HocVien as hv
 WHERE bl.LopHocID = lh.ID
 and bl.HocVienID = hv.ID
 and bl.Xoa = 0
 and (@ID IS NULL OR @ID = bl.ID)

END

--select * from BaoLuu

--exec [SPBaoLuu_DanhSach] @ID = null
GO
/****** Object:  StoredProcedure [dbo].[SPBaoLuu_LayID]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 17.01.2022
-- Description:	Stored Procedures GET ID dbo.BaoLuu
-- =============================================
CREATE PROCEDURE [dbo].[SPBaoLuu_LayID]
           @ID uniqueidentifier

AS
BEGIN

SELECT [ID]
      ,[NgayBaoLuu]
      ,[LyDo]
      ,[DonBaoLuu]
      ,[MaLopMoi]
      ,[Ghichu]
      ,[LopHocID]
      ,[HocVienID]
  FROM [dbo].[BaoLuu]
 WHERE ID = @ID AND Xoa = 0

END

--SELECT * FROM BaoLuu

--EXEC SPBaoLuu_LayID @ID = '387F6181-856E-46A6-8070-B973FEBF243D'
GO
/****** Object:  StoredProcedure [dbo].[SPBaoLuu_TaoMoi]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures CREATE dbo.BaoLuu
-- =============================================
CREATE PROCEDURE [dbo].[SPBaoLuu_TaoMoi]
           @NgayBaoLuu datetime,
           @LyDo nvarchar(1024),
           @DonBaoLuu nvarchar(400),
           @MaLopMoi varchar(1),
           @Ghichu nvarchar(1024),
           @LopHocID uniqueidentifier,
           @HocVienID uniqueidentifier
AS
BEGIN

INSERT INTO [dbo].[BaoLuu]
           ([NgayBaoLuu]
           ,[LyDo]
           ,[DonBaoLuu]
           ,[MaLopMoi]
           ,[Ghichu]
           ,[LopHocID]
           ,[HocVienID]
		   ,Xoa)
     VALUES
           (@NgayBaoLuu
           ,@LyDo
           ,@DonBaoLuu
           ,@MaLopMoi
           ,@Ghichu
           ,@LopHocID
           ,@HocVienID
		   ,0)

END

--select * from LopHoc

--select * from HocVien

--select * from BaoLuu

--exec [SPBaoLuu_TaoMoi]
--			@NgayBaoLuu = '2020-02-01'
--           ,@LyDo = null
--           ,@DonBaoLuu = N'donbaoluuu.docx'
--           ,@MaLopMoi = null
--           ,@Ghichu = null
--           ,@LopHocID = '2767125B-7784-4293-92FC-1FA85AC0771C'
--           ,@HocVienID = 'EF3B90B7-A8E0-4DBB-9823-94CDD8299B28V'
GO
/****** Object:  StoredProcedure [dbo].[SPBaoLuu_Xoa]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures xoá Khung chương trình
-- =============================================
CREATE PROCEDURE [dbo].[SPBaoLuu_Xoa]
	@ID UNIQUEIDENTIFIER
AS
BEGIN
	DECLARE @Result BIT = 0
	BEGIN TRY
		UPDATE dbo.BaoLuu
		SET Xoa  = 1
		WHERE ID = @ID;
	SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result
END


 
GO
/****** Object:  StoredProcedure [dbo].[SPBoTriPhongHoc_ChinhSua]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for BaoLuu
-- =============================================
CREATE PROCEDURE [dbo].[SPBoTriPhongHoc_ChinhSua]
           @ID uniqueidentifier,
		   @NgayBatDau datetime,
           @NgayKetThuc datetime,
           @GhiChu nvarchar(1024),
           @LopHocID uniqueidentifier,
           @PhongHocID uniqueidentifier
AS
BEGIN

UPDATE [dbo].[BoTriPhongHoc]
   SET [NgayBatDau] = @NgayBatDau
      ,[NgayKetThuc] = @NgayKetThuc
      ,[GhiChu] = @GhiChu
      ,[LopHocID] = @LopHocID
      ,[PhongHocID] = @PhongHocID
 WHERE ID = @ID

END

--SELECT * FROM  BoTriPhongHoc

--EXEC SPBoTriPhongHoc_ChinhSua 
--		   @ID = '986CA1B2-1151-4352-84A9-696A897D5CAA',
--		   @NgayBatDau = '2022-02-01 00:00:00.000',
--           @NgayKetThuc = '2022-07-01 00:00:00.000',
--           @GhiChu = 'EDITED',
--           @LopHocID = '2767578B-7784-4293-92FC-1FA85AC0771C',
--           @PhongHocID = 'C2841B14-7D4E-4B72-BDCB-1972EC8174D1'
GO
/****** Object:  StoredProcedure [dbo].[SPBoTriPhongHoc_DanhSach]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for BaoLuu
-- =============================================
CREATE PROCEDURE [dbo].[SPBoTriPhongHoc_DanhSach]
           @ID uniqueidentifier

AS
BEGIN

SELECT btr.ID, lh.MaLop, ph.MaPhong, btr.NgayBatDau, btr.NgayKetThuc
  FROM BoTriPhongHoc as btr, LopHoc as lh, PhongHoc as ph
  where btr.LopHocID = lh.ID
  and btr.PhongHocID = ph.ID
  and btr.Xoa = 0
  and (@ID is null OR @ID = btr.ID)
END

--select * from BoTriPhongHoc

--exec [SPBoTriPhongHoc_DanhSach] @ID = null
GO
/****** Object:  StoredProcedure [dbo].[SPBoTriPhongHoc_LayID]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures GET ID dbo.BoTriPhongHoc
-- =============================================
CREATE PROCEDURE [dbo].[SPBoTriPhongHoc_LayID]
           @ID uniqueidentifier

AS
BEGIN

SELECT [ID]
      ,[NgayBatDau]
      ,[NgayKetThuc]
      ,[GhiChu]
      ,[LopHocID]
      ,[PhongHocID]
  FROM [dbo].[BoTriPhongHoc]
 WHERE ID = @ID
 and Xoa = 0

END

--SELECT * FROM BoTriPhongHoc

--EXEC SPBoTriPhongHoc_LayID @ID = '8CBD6DF1-FD43-4B31-B08B-53A35BA0E421'
GO
/****** Object:  StoredProcedure [dbo].[SPBoTriPhongHoc_TaoMoi]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for BaoLuu
-- =============================================
CREATE PROCEDURE [dbo].[SPBoTriPhongHoc_TaoMoi]
           @NgayBatDau datetime,
           @NgayKetThuc datetime,
           @GhiChu nvarchar(1024),
           @LopHocID uniqueidentifier,
           @PhongHocID uniqueidentifier
AS
BEGIN

INSERT INTO [dbo].[BoTriPhongHoc]
           ([NgayBatDau]
           ,[NgayKetThuc]
           ,[GhiChu]
           ,[LopHocID]
           ,[PhongHocID]
		   ,[Xoa])
     VALUES
           (@NgayBatDau
           ,@NgayKetThuc
           ,@GhiChu
           ,@LopHocID
           ,@PhongHocID
		   ,0)
END

--select * from dbo.BoTriPhongHoc

--select * from LopHoc

--select * from PhongHoc

--Exec [SPBoTriPhongHoc_TaoMoi]
--           @NgayBatDau= '2022-02-01',
--           @NgayKetThuc = '2022-07-01',
--           @GhiChu = null,
--           @LopHocID = '2767578B-7784-4293-92FC-1FA85AC0771C',
--           @PhongHocID = 'C2841B14-7D4E-4B72-BDCB-1972EC8174D1'
GO
/****** Object:  StoredProcedure [dbo].[SPBoTriPhongHoc_Xoa]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures xoá Khung chương trình
-- =============================================
CREATE PROCEDURE [dbo].[SPBoTriPhongHoc_Xoa]
	@ID UNIQUEIDENTIFIER
AS
BEGIN
	DECLARE @Result BIT = 0
	BEGIN TRY
		UPDATE dbo.BoTriPhongHoc
		SET Xoa  = 1
		WHERE ID = @ID;
	SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result
END


 
GO
/****** Object:  StoredProcedure [dbo].[SPChuongTrinhDaoTao_DanhSach]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 22.11.2021
-- Description:	Danh Sach Chuong Trinh Dao Tao
-- =============================================
CREATE PROCEDURE [dbo].[SPChuongTrinhDaoTao_DanhSach]
	@TrangThai INT,
	@MaCT NVARCHAR(50)
AS
BEGIN
	SELECT P.ID, ROW_NUMBER() OVER (ORDER BY NgayBanHanh DESC) AS STT, P.MaCT, P.TenCT, P.HocPhi, P.NgayBanHanh, P.NoiDungCT, P.QDBanHanh, P.GhiChu, P.TrangThai 
	FROM dbo.ChuongTrinhDaoTao AS P
	WHERE (@TrangThai = 2 OR P.TrangThai = @TrangThai) 
	AND(@MaCT IS NULL OR P.MaCT = @MaCT)
	AND Xoa = 0
	
END


--EXEC dbo.SPChuongTrinhDaoTao_DanhSach @TrangThai = 2, @MaCT = 'TS001'
--select * from ChuongTrinhDaoTao
GO
/****** Object:  StoredProcedure [dbo].[SPChuongTrinhDaoTao_LayMaCT]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.11.2021
-- Description:	Lay Ma Chuong Trinh Dao Tao
-- =============================================
CREATE PROCEDURE [dbo].[SPChuongTrinhDaoTao_LayMaCT]
	@ID UNIQUEIDENTIFIER 
AS
BEGIN

SELECT [MaCT]
      ,[TenCT]
      ,[HocPhi]
      ,[NgayBanHanh]
      ,[NoiDungCT]
      ,[QDBanHanh]
      ,[GhiChu]
      ,[TrangThai]
  FROM [dbo].[ChuongTrinhDaoTao] WHERE ID = @ID AND Xoa = 0

END

--EXEC SPChuongTrinhDaoTao_LayMaCT @ID = 'B9D47C24-2DD1-4F14-9134-0FBCFE48BB88' 

--SELECT * FROM dbo.ChuongTrinhDaoTao
 
GO
/****** Object:  StoredProcedure [dbo].[SPChuongTrinhDaoTao_Sua]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.11.2021
-- Description:	Sửa chương trình đào tạo
-- =============================================
CREATE PROCEDURE [dbo].[SPChuongTrinhDaoTao_Sua]
	@ID	UNIQUEIDENTIFIER,
	@MaCT VARCHAR(50),
	@TenCT NVARCHAR(256),
	@HocPhi MONEY,
	@NgayBanHanh DATETIME,
	@NoiDungCT NVARCHAR(400),
	@QDBanHanh NVARCHAR(400),
	@GhiChu NVARCHAR(1024),
	@TrangThai INT
AS
BEGIN

UPDATE ChuongTrinhDaoTao
   SET [MaCT] = @MaCT
	  ,[TenCT] = @TenCT
      ,[HocPhi] = @HocPhi
      ,[NgayBanHanh] = @NgayBanHanh
      ,[NoiDungCT] = @NoiDungCT
      ,[QDBanHanh] = @QDBanHanh
      ,[GhiChu] = @GhiChu
      ,[TrangThai] = @TrangThai
 WHERE ID = @ID

END
 
--EXEC dbo.SPChuongTrinhDaoTao_Sua @ID = 'B9D47C24-2DD1-4F14-9134-0FBCFE48BB99',
--									@MaCT = 'TS003',                       
--                                    @TenCT = N'Program 3',                   
--                                    @HocPhi = 10000,                   
--                                    @NgayBanHanh = '2021-11-21 10:42:24', 
--                                    @NoiDungCT = N'Testing',       
--                                    @QDBanHanh = N'Testing',    
--                                    @GhiChu = N''  ,
--									@TrangThai = 0
--SELECT * FROM dbo.ChuongTrinhDaoTao
GO
/****** Object:  StoredProcedure [dbo].[SPChuongTrinhDaoTao_TaoMoi]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SPChuongTrinhDaoTao_TaoMoi]
	@ID UNIQUEIDENTIFIER,
	@MaCT VARCHAR(50),
	@TenCT NVARCHAR(256),
	@HocPhi MONEY,
	@NgayBanHanh DATETIME,
	@NoiDungCT NVARCHAR(400),
	@QDBanHanh NVARCHAR(400),
	@GhiChu NVARCHAR(1024)
AS
BEGIN

INSERT INTO [dbo].[ChuongTrinhDaoTao]
           ([ID]
           ,[MaCT]
           ,[TenCT]
           ,[HocPhi]
           ,[NgayBanHanh]
           ,[NoiDungCT]
           ,[QDBanHanh]
           ,[GhiChu]
           ,[TrangThai]
           ,[Xoa])
     VALUES
           (@ID
           ,@MaCT
           ,@TenCT
           ,@HocPhi
           ,@NgayBanHanh
           ,@NoiDungCT
           ,@QDBanHanh
           ,@GhiChu
           ,0
           ,0)


END

--EXEC dbo.SPChuongTrinhDaoTao_TaoMoi @ID = 'B9D47C24-2DD1-4F14-9134-0FBCFE48BB99',
--									@MaCT = 'TS002',                       
--                                    @TenCT = N'Program 2',                   
--                                    @HocPhi = 10000,                   
--                                    @NgayBanHanh = '2021-11-21 10:42:24', 
--                                    @NoiDungCT = N'Testing',       
--                                    @QDBanHanh = N'Testing',    
--                                    @GhiChu = N''             
--SELECT * FROM dbo.ChuongTrinhDaoTao
GO
/****** Object:  StoredProcedure [dbo].[SPChuongTrinhDaoTao_Xoa]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SPChuongTrinhDaoTao_Xoa]
	@ID UNIQUEIDENTIFIER
AS
BEGIN
	DECLARE @Result BIT = 0
	BEGIN TRY
		UPDATE dbo.ChuongTrinhDaoTao
		SET Xoa  = 1
		WHERE ID = @ID;
	SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result
END

--SELECT * FROM ChuongTrinhDaoTao
--EXEC SPChuongTrinhDaoTao_Xoa @ID = 'B9D47C24-2DD1-4F14-9134-0FBCFE48BB88'
 
GO
/****** Object:  StoredProcedure [dbo].[SPDMMonHoc_ChinhSua]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for Danh Muc Mon Hoc
-- =============================================
CREATE PROCEDURE [dbo].[SPDMMonHoc_ChinhSua]
           @ID uniqueidentifier,
		   @MonHocID uniqueidentifier,
           @KhungCTID uniqueidentifier,
           @HinhThucThi nvarchar(128),
           @GhiChu nvarchar(1024)

AS
BEGIN

UPDATE [dbo].[DMMonHoc]
   SET [MonHocID] = @MonHocID
      ,[KhungCTID] = @KhungCTID
      ,[HinhThucThi] = @HinhThucThi
      ,[GhiChu] = @GhiChu

 WHERE ID = @ID

END

--select * from KhungCT

--select * from MonHoc

--select * from DMMonHoc

--EXEC [SPDMMonHoc_ChinhSua]
--		@ID = '543E2D2D-7AF6-4461-AFAF-ED35C4BDFA5B',
--		@MonHocID = '464ED4AD-DC1C-4535-B89E-79F506430E06' ,
--        @KhungCTID = 'CBD3BDFF-5839-45CF-8EC5-FCDE9FE2C5AB' ,
--        @HinhThucThi = 'Lý thuyết',
--        @GhiChu = NULL,
--		@Xoa = 0
GO
/****** Object:  StoredProcedure [dbo].[SPDMMonHoc_DanhSach]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for DANH MỤC MÔN HỌC
-- =============================================
CREATE PROCEDURE [dbo].[SPDMMonHoc_DanhSach]
	@ID uniqueidentifier
AS
BEGIN

select dm.ID,ct.MaCT, ct.TenCT, lh.MaLop, mh.MaMonHoc, mh.TenMonHoc, mh.Sogio, dm.HinhThucThi 
from DMMonHoc as dm, MonHoc as mh, ChuongTrinhDaoTao as ct, KhungCT as kct, LopHoc as lh
where dm.MonHocID = mh.ID
and mh.CTDaoTaoID = ct.ID
and dm.KhungCTID = kct.ID
and kct.LopHocID = lh.ID
and dm.Xoa = 0
and (@ID IS NULL OR dm.ID = @ID)

END

--select * from DMMonHoc

--select * from KhungCT
--select * from MonHoc

--exec [SPDMMonHoc_DanhSach] @ID = null
GO
/****** Object:  StoredProcedure [dbo].[SPDMMonHoc_LayID]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for Danh Muc Mon Hoc
-- =============================================
CREATE PROCEDURE [dbo].[SPDMMonHoc_LayID]
	@ID uniqueidentifier
AS
BEGIN

SELECT [ID]
      ,[MonHocID]
      ,[KhungCTID]
      ,[HinhThucThi]
      ,[GhiChu]
  FROM [dbo].[DMMonHoc]
  where ID = @ID and Xoa = 0 

END

--select * from DMMonHoc
--EXEC [SPDMMonHoc_LayID] @id = '543E2D2D-7AF6-4461-AFAF-ED35C4BDFA5B'
GO
/****** Object:  StoredProcedure [dbo].[SPDMMonHoc_TaoMoi]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for Danh Muc Mon Hoc
-- =============================================
CREATE PROCEDURE [dbo].[SPDMMonHoc_TaoMoi]
           @MonHocID uniqueidentifier,
           @KhungCTID uniqueidentifier,
           @HinhThucThi nvarchar(128),
           @GhiChu nvarchar(1024)
AS
BEGIN

INSERT INTO [dbo].[DMMonHoc]
           ([MonHocID]
           ,[KhungCTID]
           ,[HinhThucThi]
           ,[GhiChu]
		   ,[Xoa])
     VALUES
           (@MonHocID
           ,@KhungCTID
           ,@HinhThucThi
           ,@GhiChu,
		   0)

END

--select * from KhungCT

--select * from MonHoc

--select * from DMMonHoc

--EXEC [SPDMMonHoc_TaoMoi]
--			@MonHocID = '464ED4AD-DC1C-4535-B89E-79F506430E06' ,
--           @KhungCTID = 'CBD3BDFF-5839-45CF-8EC5-FCDE9FE2C5AB' ,
--           @HinhThucThi = 'Thực hành',
--           @GhiChu = NULL
GO
/****** Object:  StoredProcedure [dbo].[SPDMMonHoc_Xoa]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures xoá Khung chương trình
-- =============================================
CREATE PROCEDURE [dbo].[SPDMMonHoc_Xoa]
	@ID UNIQUEIDENTIFIER
AS
BEGIN
	DECLARE @Result BIT = 0
	BEGIN TRY
		UPDATE dbo.DMMonHoc
		SET Xoa  = 1
		WHERE ID = @ID;
	SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result
END


 
GO
/****** Object:  StoredProcedure [dbo].[SPFileUploaded_ChinhSua]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 10.12.2021
-- Description:	UploadFile
-- =============================================
CREATE PROCEDURE [dbo].[SPFileUploaded_ChinhSua]
	@ID INT,
	@TenTep NVARCHAR(200),
	@NoiLuuTru NVARCHAR(500),
	@DoiTuongID UNIQUEIDENTIFIER,
	@STTTep INT
AS
BEGIN


UPDATE [dbo].[FileUploaded]
   SET [TenTep] = @TenTep
      ,[NoiLuuTru] = @NoiLuuTru
      ,[DoiTuongID] = @DoiTuongID
	  , [STTTep] = @STTTep
 WHERE ID = @ID

END

--EXEC [SPFileUploaded_ChinhSua]	@ID = 10,
--								@TenTep = 'document2.txt', 
--								@NoiLuuTru = '/path/document2.txt', 
--								@DoiTuongID = 'b9d47c24-2dd1-4f14-9134-0fbcfe48bb88', 
--								@STTTep = 1

--SELECT * From FileUploaded
GO
/****** Object:  StoredProcedure [dbo].[SPFileUploaded_LayTheoDoiTuongID]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 10.12.2021
-- Description:	UploadFile Xoa
-- =============================================
CREATE PROCEDURE [dbo].[SPFileUploaded_LayTheoDoiTuongID]
	@DoiTuongID UNIQUEIDENTIFIER
AS
BEGIN

SELECT [ID]
      ,[TenTep]
      ,[NoiLuuTru]
      ,[DoiTuongID]
	  ,[STTTep]
      ,[Xoa]
  FROM [dbo].[FileUploaded]
  WHERE Xoa = 0 AND DoiTuongID = @DoiTuongID

END

--SELECT * FROM FileUploaded
--EXEC SPFileUploaded_LayTheoDoiTuongID @DoiTuongID = 'B9D47C24-2DD1-4F14-9134-0FBCFE48BB88'
 
GO
/****** Object:  StoredProcedure [dbo].[SPFileUploaded_TaoMoi]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 10.12.2021
-- Description:	UploadFile
-- =============================================
CREATE PROCEDURE [dbo].[SPFileUploaded_TaoMoi]
	@TenTep NVARCHAR(200),
	@NoiLuuTru NVARCHAR(500),
	@DoiTuongID UNIQUEIDENTIFIER,
	@STTTep INT
AS
BEGIN

INSERT INTO [dbo].[FileUploaded]
           ([TenTep]
           ,[NoiLuuTru]
           ,[DoiTuongID]
		   ,[STTTep]
           ,[Xoa])
     VALUES
           (@TenTep
           ,@NoiLuuTru
           ,@DoiTuongID
		   ,@STTTep
           ,0)

END

--EXEC [SPFileUploaded_TaoMoi]	@TenTep = 'document6.txt', 
--								@NoiLuuTru = '/path/document4.txt', 
--								@DoiTuongID = 'b9d47c24-2dd1-4f14-9134-0fbcfe48bb88', 
--								@STTTep = 1
--SELECT * FROM FileUploaded
GO
/****** Object:  StoredProcedure [dbo].[SPFileUploaded_Xoa]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 10.12.2021
-- Description:	UploadFile Xoa
-- =============================================
CREATE PROCEDURE [dbo].[SPFileUploaded_Xoa]
	@DoiTuongID UNIQUEIDENTIFIER,
	@TenTep NVARCHAR(200)
AS
BEGIN
	DECLARE @Result BIT = 0
	BEGIN TRY
		UPDATE FileUploaded
		SET Xoa = 1
		WHERE DoiTuongID = @DoiTuongID AND TenTep = @TenTep;
	SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result

END

--SELECT * FROM FileUploaded
--EXEC SPFileUploaded_Xoa  @DoiTuongID='B9D47C24-2DD1-4F14-9134-0FBCFE48BB88' , @TenTep = 'document4.txt'
 
GO
/****** Object:  StoredProcedure [dbo].[SPGiangVien_ChinhSua]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for BaoLuu
-- =============================================
CREATE PROCEDURE [dbo].[SPGiangVien_ChinhSua]
           @ID uniqueidentifier,
		   @MaGV varchar(32),
           @HoTen nvarchar(128),
           @DiaChi nvarchar(256),
           @SDT varchar(16),
           @Email varchar(64),
           @DonViCongTac nvarchar(256),
           @MaSoThue varchar(16),
           @TrinhDo nvarchar(128),
           @BangCap nvarchar(400),
           @ChungChi nvarchar(400)

AS
BEGIN

UPDATE [dbo].[GiangVien]
   SET [MaGV] = @MaGV
      ,[HoTen] = @HoTen
      ,[DiaChi] = @DiaChi
      ,[SDT] = @SDT
      ,[Email] = @Email
      ,[DonViCongTac] = @DonViCongTac
      ,[MaSoThue] = @MaSoThue
      ,[TrinhDo] = @TrinhDo
      ,[BangCap] = @BangCap
      ,[ChungChi] = @ChungChi
 WHERE ID = @ID

END
GO
/****** Object:  StoredProcedure [dbo].[SPGiangVien_DanhSach]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for BaoLuu
-- =============================================
CREATE PROCEDURE [dbo].[SPGiangVien_DanhSach]
		@ID uniqueidentifier
AS
BEGIN

SELECT [ID]
      ,[MaGV]
      ,[HoTen]
      ,[SDT]
      ,[Email]
      ,[DonViCongTac]
      ,[MaSoThue]
  FROM [dbo].[GiangVien]
  where (@ID is null or @ID = ID) and Xoa = 0

END

--select * from GiangVien
--exec [SPGiangVien_DanhSach] @ID = null
GO
/****** Object:  StoredProcedure [dbo].[SPGiangVien_LayID]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for BaoLuu
-- =============================================
CREATE PROCEDURE [dbo].[SPGiangVien_LayID]
		@ID uniqueidentifier
AS
BEGIN

SELECT [ID]
      ,[MaGV]
      ,[HoTen]
      ,[DiaChi]
      ,[SDT]
      ,[Email]
      ,[DonViCongTac]
      ,[MaSoThue]
      ,[TrinhDo]
      ,[BangCap]
      ,[ChungChi]
  FROM [dbo].[GiangVien]
  where id = @ID

END
GO
/****** Object:  StoredProcedure [dbo].[SPGiangVien_TaoMoi]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for BaoLuu
-- =============================================
CREATE PROCEDURE [dbo].[SPGiangVien_TaoMoi]
           @MaGV varchar(32),
           @HoTen nvarchar(128),
           @DiaChi nvarchar(256),
           @SDT varchar(16),
           @Email varchar(64),
           @DonViCongTac nvarchar(256),
           @MaSoThue varchar(16),
           @TrinhDo nvarchar(128),
           @BangCap nvarchar(400),
           @ChungChi nvarchar(400)
AS
BEGIN

INSERT INTO [dbo].[GiangVien]
           ([MaGV]
           ,[HoTen]
           ,[DiaChi]
           ,[SDT]
           ,[Email]
           ,[DonViCongTac]
           ,[MaSoThue]
           ,[TrinhDo]
           ,[BangCap]
           ,[ChungChi]
		   ,[Xoa])
     VALUES
           (@MaGV
           ,@HoTen
           ,@DiaChi
           ,@SDT
           ,@Email
           ,@DonViCongTac
           ,@MaSoThue
           ,@TrinhDo
           ,@BangCap
           ,@ChungChi,
		   0)

END
GO
/****** Object:  StoredProcedure [dbo].[SPGiangVien_Xoa]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures xoá Khung chương trình
-- =============================================
CREATE PROCEDURE [dbo].[SPGiangVien_Xoa]
	@ID UNIQUEIDENTIFIER
AS
BEGIN
	DECLARE @Result BIT = 0
	BEGIN TRY
		UPDATE dbo.GiangVien
		SET Xoa  = 1
		WHERE ID = @ID;
	SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result
END


 
GO
/****** Object:  StoredProcedure [dbo].[SPHocVien_ChinhSua]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures chỉnh sửa thông tin học viên
-- =============================================
CREATE PROCEDURE [dbo].[SPHocVien_ChinhSua]
           @ID uniqueidentifier,
		   @MaHV varchar(32),
           @HoTen nvarchar(128),
           @GioiTinh nvarchar(12),
           @NgaySinh datetime,
           @NoiSinh nvarchar(128),
           @SDT varchar(16),
           @DiaChi nvarchar(256),
           @Email varchar(64),
           @HinhAnh nvarchar(400),
           @TrinhDo nvarchar(64),
           @NgheNghiep nvarchar(128),
           @DonViCongTac nvarchar(256),
           @ChucVu nvarchar(128),
           @SoQDHocNghe varchar(64),
           @SoSoBHXH varchar(32),
           @HotenNBT nvarchar(128),
           @SDTNBT varchar(16),
           @GhiChu nvarchar(1024),
           @LopHocID uniqueidentifier

AS
BEGIN

UPDATE [dbo].[HocVien]
   SET [ID] = @ID
      ,[MaHV] = @MaHV
      ,[HoTen] = @HoTen
      ,[GioiTinh] = @GioiTinh
      ,[NgaySinh] = @NgaySinh
      ,[NoiSinh] = @NoiSinh
      ,[SDT] = @SDT
      ,[DiaChi] = @DiaChi
      ,[Email] = @Email
      ,[HinhAnh] = @HinhAnh
      ,[TrinhDo] = @TrinhDo
      ,[NgheNghiep] = @NgheNghiep
      ,[DonViCongTac] = @DonViCongTac
      ,[ChucVu] = @ChucVu
      ,[SoQDHocNghe] = @SoQDHocNghe
      ,[SoSoBHXH] = @SoSoBHXH
      ,[HotenNBT] = @HotenNBT
      ,[SDTNBT] = @SDTNBT
      ,[GhiChu] = @GhiChu
      ,[LopHocID] = @LopHocID

 WHERE ID = @ID

END

GO
/****** Object:  StoredProcedure [dbo].[SPHocVien_DanhSach]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for HocVien
-- =============================================
CREATE PROCEDURE [dbo].[SPHocVien_DanhSach]
	@ID uniqueidentifier
AS
BEGIN

select hv.ID ,lh.MaLop,hv.HoTen, hv.GioiTinh, hv.NgaySinh, hv.NoiSinh, hv.SDT, hv.Email
from HocVien as hv, LopHoc as lh
where hv.LopHocID = lh.ID
and hv.Xoa = 0
and (@ID is null or @ID = hv.ID)
END

--exec [SPHocVien_DanhSach] @ID = null
GO
/****** Object:  StoredProcedure [dbo].[SPHocVien_LayID]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures lấy thông tin học viên
-- =============================================
CREATE PROCEDURE [dbo].[SPHocVien_LayID]
	@ID uniqueidentifier
AS
BEGIN

SELECT [ID]
      ,[MaHV]
      ,[HoTen]
      ,[GioiTinh]
      ,[NgaySinh]
      ,[NoiSinh]
      ,[SDT]
      ,[DiaChi]
      ,[Email]
      ,[HinhAnh]
      ,[TrinhDo]
      ,[NgheNghiep]
      ,[DonViCongTac]
      ,[ChucVu]
      ,[SoQDHocNghe]
      ,[SoSoBHXH]
      ,[HotenNBT]
      ,[SDTNBT]
      ,[GhiChu]
      ,[LopHocID]

  FROM [dbo].[HocVien]
  wHERE ID = @ID and Xoa = 0 

END

GO
/****** Object:  StoredProcedure [dbo].[SPHocVien_TaoMoi]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for BaoLuu
-- =============================================
CREATE PROCEDURE [dbo].[SPHocVien_TaoMoi]
           @MaHV varchar(32),
           @HoTen nvarchar(128),
           @GioiTinh nvarchar(12),
           @NgaySinh datetime,
           @NoiSinh nvarchar(128),
           @SDT varchar(16),
           @DiaChi nvarchar(256),
           @Email varchar(64),
           @HinhAnh nvarchar(400),
           @TrinhDo nvarchar(64),
           @NgheNghiep nvarchar(128),
           @DonViCongTac nvarchar(256),
           @ChucVu nvarchar(128),
           @SoQDHocNghe varchar(64),
           @SoSoBHXH varchar(32),
           @HotenNBT nvarchar(128),
           @SDTNBT varchar(16),
           @GhiChu nvarchar(1024),
           @LopHocID uniqueidentifier
AS
BEGIN


INSERT INTO [dbo].[HocVien]
           ([MaHV]
           ,[HoTen]
           ,[GioiTinh]
           ,[NgaySinh]
           ,[NoiSinh]
           ,[SDT]
           ,[DiaChi]
           ,[Email]
           ,[HinhAnh]
           ,[TrinhDo]
           ,[NgheNghiep]
           ,[DonViCongTac]
           ,[ChucVu]
           ,[SoQDHocNghe]
           ,[SoSoBHXH]
           ,[HotenNBT]
           ,[SDTNBT]
           ,[GhiChu]
           ,[LopHocID]
		   ,[Xoa])
     VALUES
           (@MaHV
           ,@HoTen
           ,@GioiTinh
           ,@NgaySinh
           ,@NoiSinh
           ,@SDT
           ,@DiaChi
           ,@Email
           ,@HinhAnh
           ,@TrinhDo
           ,@NgheNghiep
           ,@DonViCongTac
           ,@ChucVu
           ,@SoQDHocNghe
           ,@SoSoBHXH
           ,@HotenNBT
           ,@SDTNBT
           ,@GhiChu
           ,@LopHocID
		   ,0)

END

--SELECT * FROM LopHoc

--select * from HocVien

--Exec [SPHocVien_TaoMoi]
--			@MaHV = 'CTPT0003'
--           ,@HoTen = 'Nguyen Van D'
--           ,@GioiTinh = 'Nam'
--           ,@NgaySinh = '1999-02-02'
--           ,@NoiSinh = 'VietNam'
--           ,@SDT = '845612315616'
--           ,@DiaChi = '54 Hai Ba Trung'
--           ,@Email = 'a@gmail.com'
--           ,@HinhAnh = 'anh.jpg'
--           ,@TrinhDo = 'Dai Hoc'
--           ,@NgheNghiep = 'Giang Vien'
--           ,@DonViCongTac = 'Truong HBT'
--           ,@ChucVu = 'Chuyen Vien'
--           ,@SoQDHocNghe = '0845612302424'
--           ,@SoSoBHXH = '0845612302424'
--           ,@HotenNBT = 'Nguyen Van A'
--           ,@SDTNBT = 0935715999
--           ,@GhiChu = null
--           ,@LopHocID = '2767125B-7784-4293-92FC-1FA85AC0771C'
GO
/****** Object:  StoredProcedure [dbo].[SPHocVien_Xoa]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures xoá Khung chương trình
-- =============================================
CREATE PROCEDURE [dbo].[SPHocVien_Xoa]
	@ID UNIQUEIDENTIFIER
AS
BEGIN
	DECLARE @Result BIT = 0
	BEGIN TRY
		UPDATE dbo.HocVien
		SET Xoa  = 1
		WHERE ID = @ID;
	SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result
END


 
GO
/****** Object:  StoredProcedure [dbo].[SPKhungCT_ChinhSua]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for KhungCT
-- =============================================
CREATE PROCEDURE [dbo].[SPKhungCT_ChinhSua]
		   @ID uniqueidentifier,
           @MaKhungCT varchar(32),
           @GhiChu nvarchar(1024),
           @NhanVienID uniqueidentifier,
           @LopHocID uniqueidentifier

AS
BEGIN


UPDATE [dbo].[KhungCT]
   SET [MaKhungCT] = @MaKhungCT
      ,[GhiChu] = @GhiChu
      ,[NhanVienID] = @NhanVienID
      ,[LopHocID] = @LopHocID

 WHERE ID = @ID 

END

GO
/****** Object:  StoredProcedure [dbo].[SPKhungCT_DanhSach]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for Khung Chuong Trinh
-- =============================================
CREATE PROCEDURE [dbo].[SPKhungCT_DanhSach]
	@ID uniqueidentifier
AS
BEGIN

select k.ID, ct.MaCT, lh.MaLop, k.MaKhungCT, k.GhiChu, k.NhanVienID
	from KhungCT as k, LopHoc as lh, ChuongTrinhDaoTao as ct
	where k.LopHocID = lh.ID
	and lh.CTDaoTaoID = ct.ID
	and k.Xoa = 0
	and (@ID is null OR k.ID = @ID) 


END

--select * from ChuongTrinhDaoTao
--select * from LopHoc
--select * from KhungCT
--exec [SPKhungCT_DanhSach] @ID = null
GO
/****** Object:  StoredProcedure [dbo].[SPKhungCT_LayID]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for Khung Chuong Trinh
-- =============================================
CREATE PROCEDURE [dbo].[SPKhungCT_LayID]
	@ID uniqueidentifier
AS
BEGIN


SELECT [ID]
      ,[MaKhungCT]
      ,[GhiChu]
      ,[NhanVienID]
      ,[LopHocID]
  FROM [dbo].[KhungCT]
  wHERE ID = @ID and Xoa = 0 

END


GO
/****** Object:  StoredProcedure [dbo].[SPKhungCT_TaoMoi]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for KhungCT
-- =============================================
CREATE PROCEDURE [dbo].[SPKhungCT_TaoMoi]
           @MaKhungCT varchar(32),
           @GhiChu nvarchar(1024),
           @NhanVienID uniqueidentifier,
           @LopHocID uniqueidentifier
AS
BEGIN


INSERT INTO [dbo].[KhungCT]
           ([MaKhungCT]
           ,[GhiChu]
           ,[NhanVienID]
           ,[LopHocID]
		   ,Xoa)
     VALUES
           (@MaKhungCT
           ,@GhiChu
           ,@NhanVienID
           ,@LopHocID
		   ,0)

END

--SELECT * FROM KhungCT

--SELECT * FROM LopHoc

--EXEC SPKhungCT_TaoMoi 
--			@MaKhungCT = 'KCTCL002',
--           @GhiChu =null,
--           @NhanVienID = null,
--           @LopHocID = '2767578B-7784-4293-92FC-1FA85AC0771C'
GO
/****** Object:  StoredProcedure [dbo].[SPKhungCT_Xoa]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures xoá Khung chương trình
-- =============================================
CREATE PROCEDURE [dbo].[SPKhungCT_Xoa]
	@ID UNIQUEIDENTIFIER
AS
BEGIN
	DECLARE @Result BIT = 0
	BEGIN TRY
		UPDATE dbo.KhungCT
		SET Xoa  = 1
		WHERE ID = @ID;
	SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result
END


 
GO
/****** Object:  StoredProcedure [dbo].[SPKhungGioHoc_ChinhSua]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for [[KhungGioHoc]]
-- =============================================
CREATE PROCEDURE [dbo].[SPKhungGioHoc_ChinhSua]
           @ID uniqueidentifier,
		   @MaKhungGio varchar(32),
           @GioBatDau datetime,
           @GioKetThuc datetime,
           @GhiChu nvarchar(1024),
           @DanhMucID uniqueidentifier,
           @HopDongID uniqueidentifier

AS
BEGIN

UPDATE [dbo].[KhungGioHoc]
   SET [MaKhungGio] = @MaKhungGio
      ,[GioBatDau] = @GioBatDau
      ,[GioKetThuc] = @GioKetThuc
      ,[GhiChu] = @GhiChu
      ,[DanhMucID] = @DanhMucID
      ,[HopDongID] = @HopDongID
 WHERE ID = @ID

END

GO
/****** Object:  StoredProcedure [dbo].[SPKhungGioHoc_DanhSach]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for [[KhungGioHoc]]
-- =============================================
CREATE PROCEDURE [dbo].[SPKhungGioHoc_DanhSach]
           @ID uniqueidentifier

AS
BEGIN

SELECT khh.ID, lh.MaLop, mh.TenMonHoc, gv.HoTen, khh.MaKhungGio, khh.GioBatDau, khh.GioKetThuc

  FROM KhungGioHoc as khh,ThongTinHD as hd, GiangVien as gv, DMMonHoc as dm, MonHoc as mh, KhungCT as kct, LopHoc as lh
 WHERE khh.HopDongID = hd.ID
 and hd.GiangVienID = gv.ID
 and khh.DanhMucID = dm.ID
 and dm.MonHocID = mh.ID
 and dm.KhungCTID = kct.ID
 and kct.LopHocID = lh.ID
 and khh.Xoa = 0 
 and (@ID is null or @ID = khh.ID)

END
GO
/****** Object:  StoredProcedure [dbo].[SPKhungGioHoc_LayID]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for [[KhungGioHoc]]
-- =============================================
CREATE PROCEDURE [dbo].[SPKhungGioHoc_LayID]
           @ID uniqueidentifier

AS
BEGIN

SELECT [ID]
      ,[MaKhungGio]
      ,[GioBatDau]
      ,[GioKetThuc]
      ,[GhiChu]
      ,[DanhMucID]
      ,[HopDongID]

  FROM [dbo].[KhungGioHoc]
 WHERE ID = @ID and Xoa = 0

END

--exec [SPKhungGioHoc_LayID] @ID = null

GO
/****** Object:  StoredProcedure [dbo].[SPKhungGioHoc_TaoMoi]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for [[KhungGioHoc]]
-- =============================================
create PROCEDURE [dbo].[SPKhungGioHoc_TaoMoi]
           @MaKhungGio varchar(32),
           @GioBatDau datetime,
           @GioKetThuc datetime,
           @GhiChu nvarchar(1024),
           @DanhMucID uniqueidentifier,
           @HopDongID uniqueidentifier
AS
BEGIN

INSERT INTO [dbo].[KhungGioHoc]
           ([MaKhungGio]
           ,[GioBatDau]
           ,[GioKetThuc]
           ,[GhiChu]
           ,[DanhMucID]
           ,[HopDongID]
           ,[Xoa])
     VALUES
           (@MaKhungGio
           ,@GioBatDau
           ,@GioKetThuc
           ,@GhiChu
           ,@DanhMucID
           ,@HopDongID
           ,0)

END

GO
/****** Object:  StoredProcedure [dbo].[SPKhungGioHoc_Xoa]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures xoá Khung chương trình
-- =============================================
CREATE PROCEDURE [dbo].[SPKhungGioHoc_Xoa]
	@ID UNIQUEIDENTIFIER
AS
BEGIN
	DECLARE @Result BIT = 0
	BEGIN TRY
		UPDATE dbo.KhungGioHoc
		SET Xoa  = 1
		WHERE ID = @ID;
	SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result
END


 
GO
/****** Object:  StoredProcedure [dbo].[SPLopHoc_ChinhSua]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 30.11.2021
-- Description: Chỉnh sửa  lớp học
-- =============================================
CREATE PROCEDURE [dbo].[SPLopHoc_ChinhSua]
		@ID UNIQUEIDENTIFIER,
		@MaLop varchar(50),
		@NgayKhaiGiang DATETIME,
		@NgayKetThuc DATETIME,
		@SoLuongHV INT,
		@QDMoLop nvarchar(400),
		@ThoiKhoaBieu nvarchar(400),
		@GhiChu nvarchar(1024),
		@CTDaoTaoID UNIQUEIDENTIFIER
AS
BEGIN

UPDATE [dbo].[LopHoc]
   SET [ID] = @ID
      ,[MaLop] = @MaLop
      ,[NgayKhaiGiang] = @NgayKhaiGiang
      ,[NgayKetThuc] = @NgayKetThuc
      ,[SoLuongHV] = @SoLuongHV
      ,[QDMoLop] = @QDMoLop
      ,[ThoiKhoaBieu] = @ThoiKhoaBieu
      ,[GhiChu] = @GhiChu
      ,[Xoa] = 0
      ,[CTDaoTaoID] = @CTDaoTaoID
	WHERE ID = @ID

END

--SELECT * FROM LopHoc
--EXEC [SPLopHoc_ChinhSua]	@ID = '2767125B-7784-4293-92FC-1FA85AC0771C' ,
--							@MaLop = 'CL002', 
--							@NgayKhaiGiang = '2021-12-15', 
--							@NgayKetThuc =  '2021-12-16', 
--							@SoLuongHV = 15, 
--							@QDMoLop = 'quyetdinhhh.docx',
--							@ThoiKhoaBieu = 'tkb.txt', 
--							@GhiChu = null,
--							@CTDaoTaoID = 'E5C4608D-E984-4652-B823-899B1AF2C683'
GO
/****** Object:  StoredProcedure [dbo].[SPLopHoc_DanhSach]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 30.11.2021
-- Description:	 danh sách
-- =============================================
CREATE PROCEDURE [dbo].[SPLopHoc_DanhSach]
		@ID UNIQUEIDENTIFIER,
		@CTDaoTaoID UNIQUEIDENTIFIER
AS
BEGIN
	SELECT	C.ID, c.CTDaoTaoID, ROW_NUMBER() OVER (ORDER BY C.ID DESC) AS STT, C.MaLop, P.MaCT, C.NgayKhaiGiang, C.NgayKetThuc, C.SoLuongHV, C.QDMoLop, C.ThoiKhoaBieu, C.GhiChu
	FROM dbo.LopHoc AS C, dbo.ChuongTrinhDaoTao AS P
	WHERE (@ID is null OR C.ID = @ID)
	AND (@CTDaoTaoID is null OR C.CTDaoTaoID = @CTDaoTaoID)
	AND C.CTDaoTaoID = P.ID
	AND C.Xoa = 0
END

-- EXEC [SPLopHoc_DanhSach] @CTDaoTaoID = null , @ID = null
-- EXEC [SPLopHoc_DanhSach] @CTDaoTaoID = '3D3B4AD7-D5F1-4100-B740-903C7951ACAE' , @ID = null
-- EXEC [SPLopHoc_DanhSach] @CTDaoTaoID = null , @ID = '3D3B4AD7-D5F1-4100-B740-903C7951ACA1'

 
GO
/****** Object:  StoredProcedure [dbo].[SPLopHoc_LayID]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 30.11.2021
-- Description:	 Lay ID danh sach
-- =============================================
CREATE PROCEDURE [dbo].[SPLopHoc_LayID]
		@ID UNIQUEIDENTIFIER
AS
BEGIN
SELECT LH.[ID]
	  ,LH.[CTDaoTaoID]
      ,LH.[MaLop]
	  ,DT.MaCT
      ,LH.[NgayKhaiGiang]
      ,LH.[NgayKetThuc]
      ,LH.[SoLuongHV]
      ,LH.[QDMoLop]
      ,LH.[ThoiKhoaBieu]
      ,LH.[GhiChu]
  FROM [dbo].[LopHoc] as LH, dbo.ChuongTrinhDaoTao AS DT
  WHERE LH.Xoa = 0 AND LH.ID = @ID AND LH.CTDaoTaoID = DT.ID
END

--SELECT * FROM LopHoc
--EXEC dbo.SPLopHoc_LayID @ID = '2767125B-7784-4293-92FC-1FA85AC0771C'
 
GO
/****** Object:  StoredProcedure [dbo].[SPLopHoc_TaoMoi]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 30.11.2021
-- Description:	Tạo mới lớp học
-- =============================================
CREATE PROCEDURE [dbo].[SPLopHoc_TaoMoi]
		@ID UNIQUEIDENTIFIER,
		@MaLop varchar(50),
		@NgayKhaiGiang DATETIME,
		@NgayKetThuc DATETIME,
		@SoLuongHV INT,
		@QDMoLop nvarchar(400),
		@ThoiKhoaBieu nvarchar(400),
		@GhiChu nvarchar(1024),
		@CTDaoTaoID UNIQUEIDENTIFIER
AS
BEGIN

INSERT INTO [dbo].[LopHoc]
           ([ID]
		   ,[MaLop]
           ,[NgayKhaiGiang]
           ,[NgayKetThuc]
           ,[SoLuongHV]
           ,[QDMoLop]
           ,[ThoiKhoaBieu]
           ,[GhiChu]
           ,[Xoa]
           ,[CTDaoTaoID])
     VALUES
           (@ID
		   ,@MaLop
           ,@NgayKhaiGiang
           ,@NgayKetThuc
           ,@SoLuongHV
           ,@QDMoLop
           ,@ThoiKhoaBieu
           ,@GhiChu
           ,0
           ,@CTDaoTaoID)

END

--SELECT * FROM LopHoc
--SELECT * FROM ChuongTrinhDaoTao

--EXEC SPLopHoc_TaoMoi	@ID = '2767578B-7784-4293-92FC-1FA85AC0771C' ,
--						@MaLop = 'CL002', 
--						@NgayKhaiGiang = '2021-12-15', 
--						@NgayKetThuc =  '2021-12-16', 
--						@SoLuongHV = 30, 
--						@QDMoLop = 'quyetdinh.docx',
--						@ThoiKhoaBieu = 'tkb.txt', 
--						@GhiChu = null,
--						@CTDaoTaoID = '0F8FAD5B-D9CB-469F-A165-70867728950E'


GO
/****** Object:  StoredProcedure [dbo].[SPLopHoc_Xoa]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 30.11.2021
-- Description:	Xóa lớp học
-- =============================================
CREATE PROCEDURE [dbo].[SPLopHoc_Xoa]
	@ID UNIQUEIDENTIFIER
AS
BEGIN
	DECLARE @Result BIT = 0
	BEGIN TRY
		UPDATE dbo.LopHoc
		SET Xoa  = 1
		WHERE ID = @ID;
	SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result
END

--SELECT * FROM LopHoc
--EXEC [SPLopHoc_Xoa] @ID = '2767125B-7787-4293-919C-1FA85AC0771C'
 
GO
/****** Object:  StoredProcedure [dbo].[SPMonHoc_ChinhSua]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for Mon Hoc
-- =============================================
CREATE PROCEDURE [dbo].[SPMonHoc_ChinhSua]
		   @ID uniqueidentifier,
           @MaMonHoc varchar(32),
           @TenMonHoc nvarchar(256),
           @Sogio int,
           @GhiChu nvarchar(1024),
           @CTDaoTaoID uniqueidentifier


AS
BEGIN

UPDATE [dbo].[MonHoc]
   SET [MaMonHoc] = @MaMonHoc
      ,[TenMonHoc] = @TenMonHoc
      ,[Sogio] = @Sogio
      ,[GhiChu] = @GhiChu
      ,[CTDaoTaoID] = @CTDaoTaoID

 WHERE ID = @ID


END

--select * from ChuongTrinhDaoTao
--select * from MonHoc
--exec [SPMonHoc_ChinhSua]   @MaMonHoc = 'MH005',
--					   @TenMonHoc = N'TinHoc',
--					   @Sogio= 3,
--					   @GhiChu = null,
--					   @CTDaoTaoID= '3D3B4AD7-D5F1-4100-B740-903C7951ACAE'
GO
/****** Object:  StoredProcedure [dbo].[SPMonHoc_DanhSach]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for Mon Hoc
-- =============================================
CREATE PROCEDURE [dbo].[SPMonHoc_DanhSach]
	@ID uniqueidentifier,
	@CTDaoTaoID uniqueidentifier
AS
BEGIN

SELECT mh.id, ct.MaCT, ct.TenCT, mh.MaMonHoc, mh.TenMonHoc, mh.Sogio
	from MonHoc as mh, ChuongTrinhDaoTao as ct
  	where mh.CTDaoTaoID = ct.ID
	and mh.Xoa = 0
	and (@ID is null OR mh.ID = @ID) 
	and (@CTDaoTaoID is null OR mh.CTDaoTaoID = @CTDaoTaoID) 

END

--select * from MonHoc

--exec [SPMonHoc_DanhSach] @ID = null, @CTDaoTaoID = null
GO
/****** Object:  StoredProcedure [dbo].[SPMonHoc_LayID]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for Mon Hoc
-- =============================================
CREATE PROCEDURE [dbo].[SPMonHoc_LayID]
	@ID uniqueidentifier
AS
BEGIN


SELECT [ID]
      ,[MaMonHoc]
      ,[TenMonHoc]
      ,[Sogio]
      ,[GhiChu]
      ,[CTDaoTaoID]
  FROM [dbo].[MonHoc]
  WHERE ID = @ID and Xoa = 0

END

--select * from MonHoc
--exec SPMonHoc_LayID @ID = 'E9CE3035-4C1F-4CB6-91FD-D724FB8B22BB'
GO
/****** Object:  StoredProcedure [dbo].[SPMonHoc_TaoMoi]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for Mon Hoc
-- =============================================
CREATE PROCEDURE [dbo].[SPMonHoc_TaoMoi]
           @MaMonHoc varchar(32),
           @TenMonHoc nvarchar(256),
           @Sogio int,
           @GhiChu nvarchar(1024),
           @CTDaoTaoID uniqueidentifier

AS
BEGIN

INSERT INTO [dbo].[MonHoc]
           ([MaMonHoc]
           ,[TenMonHoc]
           ,[Sogio]
           ,[GhiChu]
           ,[CTDaoTaoID]
           ,[Xoa])
     VALUES
           (@MaMonHoc
           ,@TenMonHoc
           ,@Sogio
           ,@GhiChu
           ,@CTDaoTaoID
           ,0)

END

--select * from ChuongTrinhDaoTao
--select * from MonHoc
--exec SPMonHoc_TaoMoi   @MaMonHoc = 'MH005',
--					   @TenMonHoc = N'TinHoc',
--					   @Sogio= 3,
--					   @GhiChu = null,
--					   @CTDaoTaoID= '3D3B4AD7-D5F1-4100-B740-903C7951ACAE'
GO
/****** Object:  StoredProcedure [dbo].[SPMonHoc_Xoa]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for Mon Hoc
-- =============================================
create PROCEDURE [dbo].[SPMonHoc_Xoa]
	@ID UNIQUEIDENTIFIER
AS
BEGIN
	DECLARE @Result BIT = 0
	BEGIN TRY
		UPDATE dbo.MonHoc
		SET Xoa  = 1
		WHERE ID = @ID;
	SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result
END

--SELECT * FROM LopHoc
--EXEC [SPLopHoc_Xoa] @ID = '2767125B-7787-4293-919C-1FA85AC0771C'
 
GO
/****** Object:  StoredProcedure [dbo].[SPPhongHoc_ChinhSua]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for PhongHoc
-- =============================================
CREATE PROCEDURE [dbo].[SPPhongHoc_ChinhSua]
           @ID uniqueidentifier,
		   @MaPhong varchar(32),
           @TenPhong nvarchar(256),
           @SoMayTinh int,
           @Ghichu nvarchar(1024)
AS
BEGIN

UPDATE [dbo].[PhongHoc]
   SET [MaPhong] = @MaPhong
      ,[TenPhong] = @TenPhong
      ,[SoMayTinh] = @SoMayTinh
      ,[Ghichu] = @Ghichu
 WHERE ID = @ID

END

GO
/****** Object:  StoredProcedure [dbo].[SPPhongHoc_DanhSach]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for PhongHoc
-- =============================================
CREATE PROCEDURE [dbo].[SPPhongHoc_DanhSach]
           @ID uniqueidentifier

AS
BEGIN

SELECT [ID]
      ,[MaPhong]
      ,[TenPhong]
      ,[SoMayTinh]
      ,[Ghichu]
  FROM [dbo].[PhongHoc]
 WHERE (@ID is null or @ID = ID)
 and Xoa = 0

END

GO
/****** Object:  StoredProcedure [dbo].[SPPhongHoc_LayID]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for PhongHoc
-- =============================================
CREATE PROCEDURE [dbo].[SPPhongHoc_LayID]
           @ID uniqueidentifier

AS
BEGIN

SELECT [ID]
      ,[MaPhong]
      ,[TenPhong]
      ,[SoMayTinh]
      ,[Ghichu]
  FROM [dbo].[PhongHoc]
 WHERE ID = @ID and Xoa = 0

END

GO
/****** Object:  StoredProcedure [dbo].[SPPhongHoc_TaoMoi]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for PhongHoc
-- =============================================
CREATE PROCEDURE [dbo].[SPPhongHoc_TaoMoi]
           @MaPhong varchar(32),
           @TenPhong nvarchar(256),
           @SoMayTinh int,
           @Ghichu nvarchar(1024)
AS
BEGIN


INSERT INTO [dbo].[PhongHoc]
           ([MaPhong]
           ,[TenPhong]
           ,[SoMayTinh]
           ,[Ghichu]
		   ,[Xoa])
     VALUES
           (@MaPhong
           ,@TenPhong
           ,@SoMayTinh
           ,@Ghichu
		   ,0)
END

--select * from PhongHoc

--exec [SPPhongHoc_TaoMoi]
--           @MaPhong = 'PH003',
--           @TenPhong = N'Phong Thuc Hanh 3',
--           @SoMayTinh = 25,
--           @Ghichu = null
GO
/****** Object:  StoredProcedure [dbo].[SPPhongHoc_Xoa]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures xoá Khung chương trình
-- =============================================
CREATE PROCEDURE [dbo].[SPPhongHoc_Xoa]
	@ID UNIQUEIDENTIFIER
AS
BEGIN
	DECLARE @Result BIT = 0
	BEGIN TRY
		UPDATE dbo.PhongHoc
		SET Xoa  = 1
		WHERE ID = @ID;
	SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result
END


 
GO
/****** Object:  StoredProcedure [dbo].[SPQLChungChi_ChinhSua]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for PhongHoc
-- =============================================
CREATE PROCEDURE [dbo].[SPQLChungChi_ChinhSua]
           @ID uniqueidentifier,
		   @SoHieuCC varchar(32),
           @TrangThai bit,
           @NgayNhan datetime,
           @NhanVienID uniqueidentifier,
           @LopHocID uniqueidentifier,
           @HocVienID uniqueidentifier

AS
BEGIN

UPDATE [dbo].[QLChungChi]
   SET [SoHieuCC] = @SoHieuCC
      ,[TrangThai] = @TrangThai
      ,[NgayNhan] = @NgayNhan
      ,[NhanVienID] = @NhanVienID
      ,[LopHocID] = @LopHocID
      ,[HocVienID] = @HocVienID

 WHERE ID = @ID

END
GO
/****** Object:  StoredProcedure [dbo].[SPQLChungChi_DanhSach]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for PhongHoc
-- =============================================
CREATE PROCEDURE [dbo].[SPQLChungChi_DanhSach]
           @ID uniqueidentifier

AS
BEGIN

SELECT cc.ID, cc.SoHieuCC, lh.MaLop,hv.HoTen, cc.NgayNhan, cc.TrangThai
FROM QLChungChi AS cc, LopHoc as lh, HocVien as hv
 WHERE cc.LopHocID =  lh.ID
 and cc.HocVienID = hv.ID
 and cc.LopHocID = lh.ID
 and cc.Xoa = 0
 and (@ID is null or @ID = cc.ID)

END

--select * from QLChungChi
--exec [SPQLChungChi_DanhSach] @ID = null
GO
/****** Object:  StoredProcedure [dbo].[SPQLChungChi_LayID]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for PhongHoc
-- =============================================
CREATE PROCEDURE [dbo].[SPQLChungChi_LayID]
           @ID uniqueidentifier

AS
BEGIN

SELECT [ID]
      ,[SoHieuCC]
      ,[TrangThai]
      ,[NgayNhan]
      ,[NhanVienID]
      ,[LopHocID]
      ,[HocVienID]
  FROM [dbo].[QLChungChi]
 WHERE ID = @ID and Xoa = 0

END
GO
/****** Object:  StoredProcedure [dbo].[SPQLChungChi_TaoMoi]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for PhongHoc
-- =============================================
CREATE PROCEDURE [dbo].[SPQLChungChi_TaoMoi]
           @SoHieuCC varchar(32),
           @TrangThai bit,
           @NgayNhan datetime,
           @NhanVienID uniqueidentifier,
           @LopHocID uniqueidentifier,
           @HocVienID uniqueidentifier
AS
BEGIN


INSERT INTO [dbo].[QLChungChi]
           ([SoHieuCC]
           ,[TrangThai]
           ,[NgayNhan]
           ,[NhanVienID]
           ,[LopHocID]
           ,[HocVienID]
		   ,[Xoa])
     VALUES
           (@SoHieuCC
           ,@TrangThai
           ,@NgayNhan
           ,@NhanVienID
           ,@LopHocID
           ,@HocVienID
		   ,0)

END

--select * from LopHoc

--select * from HocVien

--select * from QLChungChi

--exec [SPQLChungChi_TaoMoi]
--           @SoHieuCC = 'CC0001'
--           ,@TrangThai = 0
--           ,@NgayNhan = '2022-01-01'
--           ,@NhanVienID = null
--           ,@LopHocID = '2767578B-7784-4293-92FC-1FA85AC0771C'
--           ,@HocVienID = '1328699A-2EC6-4200-9B1F-EE1D6A637B75'
GO
/****** Object:  StoredProcedure [dbo].[SPQLChungChi_Xoa]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures xoá Khung chương trình
-- =============================================
CREATE PROCEDURE [dbo].[SPQLChungChi_Xoa]
	@ID UNIQUEIDENTIFIER
AS
BEGIN
	DECLARE @Result BIT = 0
	BEGIN TRY
		UPDATE dbo.QLChungChi
		SET Xoa  = 1
		WHERE ID = @ID;
	SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result
END


 
GO
/****** Object:  StoredProcedure [dbo].[SPThiCu_ChinhSua]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for PhongHoc
-- =============================================
CREATE PROCEDURE [dbo].[SPThiCu_ChinhSua]
           @ID uniqueidentifier,
		   @MaThi varchar(32),
           @LanThi int,
           @NgayThi datetime,
           @HinhThucThi nvarchar(128),
           @MaDeThi varchar(32),
           @SLThamDu int,
           @SLVang int,
           @BienBan nvarchar(400),
           @MaNV varchar(32),
           @DanhMucID uniqueidentifier

AS
BEGIN

UPDATE [dbo].[ThiCu]
   SET [MaThi] = @MaThi
      ,[LanThi] = @LanThi
      ,[NgayThi] = @NgayThi
      ,[HinhThucThi] = @HinhThucThi
      ,[MaDeThi] = @MaDeThi
      ,[SLThamDu] = @SLThamDu
      ,[SLVang] = @SLVang
      ,[BienBan] = @BienBan
      ,[MaNV] = @MaNV
      ,[DanhMucID] = @DanhMucID

 WHERE ID = @ID

END
GO
/****** Object:  StoredProcedure [dbo].[SPThiCu_DanhSach]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for PhongHoc
-- =============================================
CREATE PROCEDURE [dbo].[SPThiCu_DanhSach]
           @ID uniqueidentifier
AS
BEGIN

select tc.ID,lh.MaLop, mh.TenMonHoc, tc.HinhThucThi, tc.NgayThi, tc.MaDeThi ,tc.SLThamDu, tc.SLVang, tc.MaNV
from ThiCu as tc, DMMonHoc as dm, MonHoc as mh, KhungCT as kct, LopHoc as lh
where tc.DanhMucID = dm.ID
and dm.MonHocID = mh.ID
and dm.KhungCTID = kct.ID
and kct.LopHocID = lh.ID
and tc.Xoa = 0
and (@ID is null or @ID = tc.ID)

END

--select * from ThiCu

--exec [SPThiCu_DanhSach] @ID = null
GO
/****** Object:  StoredProcedure [dbo].[SPThiCu_LayID]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for PhongHoc
-- =============================================
CREATE PROCEDURE [dbo].[SPThiCu_LayID]
           @ID uniqueidentifier
AS
BEGIN

SELECT [ID]
      ,[MaThi]
      ,[LanThi]
      ,[NgayThi]
      ,[HinhThucThi]
      ,[MaDeThi]
      ,[SLThamDu]
      ,[SLVang]
      ,[BienBan]
      ,[MaNV]
      ,[DanhMucID]
  FROM [dbo].[ThiCu]
 WHERE ID = @ID and Xoa = 0

END
GO
/****** Object:  StoredProcedure [dbo].[SPThiCu_TaoMoi]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for PhongHoc
-- =============================================
CREATE PROCEDURE [dbo].[SPThiCu_TaoMoi]
           @MaThi varchar(32),
           @LanThi int,
           @NgayThi datetime,
           @HinhThucThi nvarchar(128),
           @MaDeThi varchar(32),
           @SLThamDu int,
           @SLVang int,
           @BienBan nvarchar(400),
           @MaNV varchar(32),
           @DanhMucID uniqueidentifier
AS
BEGIN


INSERT INTO [dbo].[ThiCu]
           ([MaThi]
           ,[LanThi]
           ,[NgayThi]
           ,[HinhThucThi]
           ,[MaDeThi]
           ,[SLThamDu]
           ,[SLVang]
           ,[BienBan]
           ,[MaNV]
           ,[DanhMucID]
           ,[Xoa])
     VALUES
           (@MaThi
           ,@LanThi
           ,@NgayThi
           ,@HinhThucThi
           ,@MaDeThi
           ,@SLThamDu
           ,@SLVang
           ,@BienBan
           ,@MaNV
           ,@DanhMucID
           ,0)



END

--select * from DMMonHoc

--select * from ThiCu

--exec SPThiCu_TaoMoi
--            @MaThi = 'THi0004'
--           ,@LanThi = 1
--           ,@NgayThi = '2020-01-01'
--           ,@HinhThucThi = 'Thuc Hanh'
--           ,@MaDeThi = 'DE001'
--           ,@SLThamDu = 30
--           ,@SLVang = 1
--           ,@BienBan = 'bienbang.pdf'
--           ,@MaNV = null
--           ,@DanhMucID = '543E2D2D-7AF6-4461-AFAF-ED35C4BDFA5B'
GO
/****** Object:  StoredProcedure [dbo].[SPThiCu_Xoa]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures xoá Khung chương trình
-- =============================================
CREATE PROCEDURE [dbo].[SPThiCu_Xoa]
	@ID UNIQUEIDENTIFIER
AS
BEGIN
	DECLARE @Result BIT = 0
	BEGIN TRY
		UPDATE dbo.ThiCu
		SET Xoa  = 1
		WHERE ID = @ID;
	SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result
END


 
GO
/****** Object:  StoredProcedure [dbo].[SPThoiKhoaBieu_ChinhSua]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for [ThoiKhoaBieu]
-- =============================================
CREATE PROCEDURE [dbo].[SPThoiKhoaBieu_ChinhSua]
           @ID uniqueidentifier,
		   @Thu nvarchar(64),
           @Ghichu nvarchar(1024),
           @KhungGioID uniqueidentifier,
           @LopHocID uniqueidentifier

AS
BEGIN

UPDATE [dbo].[ThoiKhoaBieu]
   SET [Thu] = @Thu
      ,[Ghichu] = @Ghichu
      ,[KhungGioID] = @KhungGioID
      ,[LopHocID] = @LopHocID
 WHERE ID = @ID

END
GO
/****** Object:  StoredProcedure [dbo].[SPThoiKhoaBieu_LayID]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for [ThoiKhoaBieu]
-- =============================================
CREATE PROCEDURE [dbo].[SPThoiKhoaBieu_LayID]
           @ID uniqueidentifier

AS
BEGIN

SELECT [ID]
      ,[Thu]
      ,[Ghichu]
      ,[KhungGioID]
      ,[LopHocID]
  FROM [dbo].[ThoiKhoaBieu]
 WHERE ID = @ID and Xoa = 0

END
GO
/****** Object:  StoredProcedure [dbo].[SPThoiKhoaBieu_TaoMoi]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for [ThoiKhoaBieu]
-- =============================================
CREATE PROCEDURE [dbo].[SPThoiKhoaBieu_TaoMoi]
           @Thu nvarchar(64),
           @Ghichu nvarchar(1024),
           @KhungGioID uniqueidentifier,
           @LopHocID uniqueidentifier
AS
BEGIN


INSERT INTO [dbo].[ThoiKhoaBieu]
           ([Thu]
           ,[Ghichu]
           ,[KhungGioID]
           ,[LopHocID]
		   ,[Xoa])
     VALUES
           (@Thu
           ,@Ghichu
           ,@KhungGioID
           ,@LopHocID
		   ,0)

END
GO
/****** Object:  StoredProcedure [dbo].[SPThoiKhoaBieu_Xoa]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures xoá Khung chương trình
-- =============================================
CREATE PROCEDURE [dbo].[SPThoiKhoaBieu_Xoa]
	@ID UNIQUEIDENTIFIER
AS
BEGIN
	DECLARE @Result BIT = 0
	BEGIN TRY
		UPDATE dbo.ThoiKhoaBieu
		SET Xoa  = 1
		WHERE ID = @ID;
	SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result
END


 
GO
/****** Object:  StoredProcedure [dbo].[SPThongTinHD_ChinhSua]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for [ThongTinHD]
-- =============================================
CREATE PROCEDURE [dbo].[SPThongTinHD_ChinhSua]
           @ID uniqueidentifier,
		   @MaHopDong varchar(32),
           @GiangVienID uniqueidentifier,
           @SoGio int,
           @ThuLao int,
           @NgayKy datetime,
           @NgayThanhLy datetime,
           @HopDongGD nvarchar(400),
           @HopDongTL nvarchar(400),
           @MaNVLamHD varchar(1),
           @MaNVTLHD varchar(1),
           @DanhMucID uniqueidentifier

AS
BEGIN

UPDATE [dbo].[ThongTinHD]
   SET [MaHopDong] = @MaHopDong
      ,[GiangVienID] = @GiangVienID
      ,[SoGio] = @SoGio
      ,[ThuLao] = @ThuLao
      ,[NgayKy] = @NgayKy
      ,[NgayThanhLy] = @NgayThanhLy
      ,[HopDongGD] = @HopDongGD
      ,[HopDongTL] = @HopDongTL
      ,[MaNVLamHD] = @MaNVLamHD
      ,[MaNVTLHD] = @MaNVTLHD
      ,[DanhMucID] = @DanhMucID
 WHERE ID = @ID

END
GO
/****** Object:  StoredProcedure [dbo].[SPThongTinHD_DanhSach]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for [ThongTinHD]
-- =============================================
CREATE PROCEDURE [dbo].[SPThongTinHD_DanhSach]
           @ID uniqueidentifier

AS
BEGIN

SELECT tt.ID, tt.MaHopDong, gv.HoTen, lh.MaLop, mh.TenMonHoc,tt.ThuLao, tt.SoGio, tt.NgayKy, tt. NgayThanhLy
  FROM ThongTinHD as tt, GiangVien as gv, DMMonHoc as dm, MonHoc as mh,KhungCT as kct, LopHoc as lh
 WHERE tt.GiangVienID = gv.ID
 and tt.DanhMucID = dm.ID
 and dm.MonHocID = mh.ID
 and dm.KhungCTID = kct.ID
 and kct.LopHocID = lh.ID
 and tt.Xoa = 0
 and (@ID is null or @ID = tt.ID)

END

--EXEC [SPThongTinHD_DanhSach] @ID = null
GO
/****** Object:  StoredProcedure [dbo].[SPThongTinHD_LayID]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for [ThongTinHD]
-- =============================================
CREATE PROCEDURE [dbo].[SPThongTinHD_LayID]
           @ID uniqueidentifier

AS
BEGIN

SELECT [ID]
      ,[MaHopDong]
      ,[GiangVienID]
      ,[SoGio]
      ,[ThuLao]
      ,[NgayKy]
      ,[NgayThanhLy]
      ,[HopDongGD]
      ,[HopDongTL]
      ,[MaNVLamHD]
      ,[MaNVTLHD]
      ,[DanhMucID]
  FROM [dbo].[ThongTinHD]
 WHERE ID = @ID and Xoa = 0

END
GO
/****** Object:  StoredProcedure [dbo].[SPThongTinHD_TaoMoi]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures for [ThongTinHD]
-- =============================================
CREATE PROCEDURE [dbo].[SPThongTinHD_TaoMoi]
           @MaHopDong varchar(32),
           @GiangVienID uniqueidentifier,
           @SoGio int,
           @ThuLao int,
           @NgayKy datetime,
           @NgayThanhLy datetime,
           @HopDongGD nvarchar(400),
           @HopDongTL nvarchar(400),
           @MaNVLamHD varchar(1),
           @MaNVTLHD varchar(1),
           @DanhMucID uniqueidentifier

AS
BEGIN


INSERT INTO [dbo].[ThongTinHD]
           ([MaHopDong]
           ,[GiangVienID]
           ,[SoGio]
           ,[ThuLao]
           ,[NgayKy]
           ,[NgayThanhLy]
           ,[HopDongGD]
           ,[HopDongTL]
           ,[MaNVLamHD]
           ,[MaNVTLHD]
           ,[DanhMucID]
           ,[Xoa])
     VALUES
           (@MaHopDong
           ,@GiangVienID
           ,@SoGio
           ,@ThuLao
           ,@NgayKy
           ,@NgayThanhLy
           ,@HopDongGD
           ,@HopDongTL
           ,@MaNVLamHD
           ,@MaNVTLHD
           ,@DanhMucID
           ,0)


END
GO
/****** Object:  StoredProcedure [dbo].[SPThongTinHD_Xoa]    Script Date: 1/21/2022 8:08:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 16.01.2022
-- Description:	Stored Procedures xoá Khung chương trình
-- =============================================
CREATE PROCEDURE [dbo].[SPThongTinHD_Xoa]
	@ID UNIQUEIDENTIFIER
AS
BEGIN
	DECLARE @Result BIT = 0
	BEGIN TRY
		UPDATE dbo.ThongTinHD
		SET Xoa  = 1
		WHERE ID = @ID;
	SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result
END


 
GO
