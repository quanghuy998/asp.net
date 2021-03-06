USE [CSDL Tuong_LeHoi]
GO
/****** Object:  Table [dbo].[ChucNangMenu]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucNangMenu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ChucNangMenu] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChucNangMenu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KieuDuLieu]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KieuDuLieu](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[TenKieuDuLieu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KieuDuLieu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiTuLieu]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTuLieu](
	[ID] [uniqueidentifier] NOT NULL,
	[MaLoaiCapCha] [uniqueidentifier] NULL,
	[TenLoaiTuLieu] [nvarchar](200) NULL,
	[MoTa] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoaiTuLieu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LuocDoDuLieu]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LuocDoDuLieu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaThuocTinh] [int] NULL,
	[BatBuoc] [bit] NULL,
	[LapLai] [bit] NULL,
	[ThuTu] [smallint] NULL,
	[DoDai] [int] NULL,
	[MaLoaiTuLieu] [uniqueidentifier] NULL,
 CONSTRAINT [PK_LDDuLieu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomTaiKhoan]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomTaiKhoan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNhomTaiKhoan] [nvarchar](50) NULL,
	[MoTa] [nvarchar](100) NULL,
 CONSTRAINT [PK_NhomTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomTaiKhoan_TaiKhoan]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomTaiKhoan_TaiKhoan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDNhomTaiKhoan] [int] NOT NULL,
	[IDTaiKhoan] [int] NOT NULL,
 CONSTRAINT [PK_NhomTaiKhoan_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomThuocTinh]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomThuocTinh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNhom] [nvarchar](100) NOT NULL,
	[MoTa] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_GD_NhomThuocTinh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomTK_CN]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomTK_CN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDNhomTaiKhoan] [int] NOT NULL,
	[IDNhomChucNang] [int] NOT NULL,
 CONSTRAINT [PK_NhomTK_CN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [nchar](20) NULL,
	[MatKhau] [nchar](20) NULL,
	[Email] [nvarchar](100) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TepKemTheo]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TepKemTheo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaTuLieu] [uniqueidentifier] NOT NULL,
	[TenTep] [nvarchar](100) NOT NULL,
	[MoTa] [nvarchar](100) NULL,
	[ViTriLuuTru] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TepKemTheo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongTinMoTa]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinMoTa](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaTuLieu] [uniqueidentifier] NOT NULL,
	[MaThuocTinh] [int] NOT NULL,
	[GiaTri] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TTMoTa] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThuocTinh]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuocTinh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaNhom] [int] NULL,
	[TenThuocTinh] [nvarchar](100) NOT NULL,
	[MoTa] [nvarchar](max) NULL,
	[KieuDuLieu] [tinyint] NULL,
 CONSTRAINT [PK_GD_ThuocTinh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TuLieu]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuLieu](
	[ID] [uniqueidentifier] NOT NULL,
	[MaLoaiTuLieu] [uniqueidentifier] NOT NULL,
	[TenTuLieu] [nvarchar](500) NOT NULL,
	[HinhAnh] [nvarchar](max) NULL,
	[MoTa] [nvarchar](max) NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgayCapNhatCuoi] [datetime] NOT NULL,
	[NguoiTao] [int] NULL,
	[NguoiCapNhatCuoi] [int] NULL,
 CONSTRAINT [PK_TL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[KieuDuLieu] ON 

INSERT [dbo].[KieuDuLieu] ([ID], [TenKieuDuLieu]) VALUES (8, N'Tiểu luận')
INSERT [dbo].[KieuDuLieu] ([ID], [TenKieuDuLieu]) VALUES (9, N'Hình ảnh')
INSERT [dbo].[KieuDuLieu] ([ID], [TenKieuDuLieu]) VALUES (11, N'Tập tin')
INSERT [dbo].[KieuDuLieu] ([ID], [TenKieuDuLieu]) VALUES (15, N'Luận lý')
SET IDENTITY_INSERT [dbo].[KieuDuLieu] OFF
GO
INSERT [dbo].[LoaiTuLieu] ([ID], [MaLoaiCapCha], [TenLoaiTuLieu], [MoTa]) VALUES (N'98187c1c-b9b1-4071-8d6e-403cd1f1da22', NULL, N'Vũ đạo tuồng', N'Lorem ipsum dolor sit amet,
consectetur adipiscing elit.')
INSERT [dbo].[LoaiTuLieu] ([ID], [MaLoaiCapCha], [TenLoaiTuLieu], [MoTa]) VALUES (N'9accdadd-29ff-436d-b631-455cfce6a78a', NULL, N'Mặt nạ tuồng', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.')
INSERT [dbo].[LoaiTuLieu] ([ID], [MaLoaiCapCha], [TenLoaiTuLieu], [MoTa]) VALUES (N'7db0d3e7-6164-4237-89cd-4923aba5253e', NULL, N'Hát tuồng', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.')
INSERT [dbo].[LoaiTuLieu] ([ID], [MaLoaiCapCha], [TenLoaiTuLieu], [MoTa]) VALUES (N'4f696550-1299-4b22-9823-6531a7a839ca', NULL, N'Phục trang tuồng', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.')
INSERT [dbo].[LoaiTuLieu] ([ID], [MaLoaiCapCha], [TenLoaiTuLieu], [MoTa]) VALUES (N'b6db8cf9-e46c-4a9d-bda8-69dbe224eb96', NULL, N'Âm nhạc tuồng', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.')
INSERT [dbo].[LoaiTuLieu] ([ID], [MaLoaiCapCha], [TenLoaiTuLieu], [MoTa]) VALUES (N'752f0f25-2f29-41c8-8e94-898a4e39a8a8', NULL, N'Trích đoạn tuồng', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.')
INSERT [dbo].[LoaiTuLieu] ([ID], [MaLoaiCapCha], [TenLoaiTuLieu], [MoTa]) VALUES (N'3618da7f-7207-40c3-be81-c52beff9c05d', NULL, N'Đạo cụ tuồng', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.')
INSERT [dbo].[LoaiTuLieu] ([ID], [MaLoaiCapCha], [TenLoaiTuLieu], [MoTa]) VALUES (N'd6516a8e-7e9b-4bc5-ba4f-f43836eb70ea', NULL, N'Kịch bản tuồng', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.')
GO
SET IDENTITY_INSERT [dbo].[LuocDoDuLieu] ON 

INSERT [dbo].[LuocDoDuLieu] ([ID], [MaThuocTinh], [BatBuoc], [LapLai], [ThuTu], [DoDai], [MaLoaiTuLieu]) VALUES (2, 1, 0, 0, 1, 0, N'b6db8cf9-e46c-4a9d-bda8-69dbe224eb96')
INSERT [dbo].[LuocDoDuLieu] ([ID], [MaThuocTinh], [BatBuoc], [LapLai], [ThuTu], [DoDai], [MaLoaiTuLieu]) VALUES (3, 3, 0, 0, 2, 0, N'b6db8cf9-e46c-4a9d-bda8-69dbe224eb96')
INSERT [dbo].[LuocDoDuLieu] ([ID], [MaThuocTinh], [BatBuoc], [LapLai], [ThuTu], [DoDai], [MaLoaiTuLieu]) VALUES (4, 5, 0, 0, 3, 0, N'b6db8cf9-e46c-4a9d-bda8-69dbe224eb96')
INSERT [dbo].[LuocDoDuLieu] ([ID], [MaThuocTinh], [BatBuoc], [LapLai], [ThuTu], [DoDai], [MaLoaiTuLieu]) VALUES (6, 6, 0, 0, 4, 0, N'b6db8cf9-e46c-4a9d-bda8-69dbe224eb96')
INSERT [dbo].[LuocDoDuLieu] ([ID], [MaThuocTinh], [BatBuoc], [LapLai], [ThuTu], [DoDai], [MaLoaiTuLieu]) VALUES (7, 16, 0, 0, 5, 0, N'b6db8cf9-e46c-4a9d-bda8-69dbe224eb96')
INSERT [dbo].[LuocDoDuLieu] ([ID], [MaThuocTinh], [BatBuoc], [LapLai], [ThuTu], [DoDai], [MaLoaiTuLieu]) VALUES (8, 8, 0, 0, 6, 0, N'b6db8cf9-e46c-4a9d-bda8-69dbe224eb96')
INSERT [dbo].[LuocDoDuLieu] ([ID], [MaThuocTinh], [BatBuoc], [LapLai], [ThuTu], [DoDai], [MaLoaiTuLieu]) VALUES (9, 3, 0, 0, 1, 0, N'98187c1c-b9b1-4071-8d6e-403cd1f1da22')
SET IDENTITY_INSERT [dbo].[LuocDoDuLieu] OFF
GO
SET IDENTITY_INSERT [dbo].[NhomThuocTinh] ON 

INSERT [dbo].[NhomThuocTinh] ([ID], [TenNhom], [MoTa]) VALUES (1, N'Thuộc tính chung', N'Nhóm thuộc tính chung')
INSERT [dbo].[NhomThuocTinh] ([ID], [TenNhom], [MoTa]) VALUES (3, N'Âm nhạc tuồng', N'Nhóm âm nhạc tuồng')
INSERT [dbo].[NhomThuocTinh] ([ID], [TenNhom], [MoTa]) VALUES (4, N'Nhóm Đạo cụ sân khấu', N'Nhóm đạo cụ sân khấu')
INSERT [dbo].[NhomThuocTinh] ([ID], [TenNhom], [MoTa]) VALUES (8, N'Nhóm Hát tuồng', N'Nhóm hát tuồng')
INSERT [dbo].[NhomThuocTinh] ([ID], [TenNhom], [MoTa]) VALUES (10, N'Nhóm Kịch bản tuồng', N'Nhóm kịch bản tuồng')
INSERT [dbo].[NhomThuocTinh] ([ID], [TenNhom], [MoTa]) VALUES (12, N'Nhóm Phục trang tuồng', N'Nhóm phục trang tuồng')
INSERT [dbo].[NhomThuocTinh] ([ID], [TenNhom], [MoTa]) VALUES (13, N'Nhóm Từ ngữ tuồng', N'Nhóm từ ngữ tuồng')
INSERT [dbo].[NhomThuocTinh] ([ID], [TenNhom], [MoTa]) VALUES (14, N'Nhóm Vũ đạo tuồng', N'Nhóm vũ đạo tuồng')
SET IDENTITY_INSERT [dbo].[NhomThuocTinh] OFF
GO
SET IDENTITY_INSERT [dbo].[ThongTinMoTa] ON 

INSERT [dbo].[ThongTinMoTa] ([ID], [MaTuLieu], [MaThuocTinh], [GiaTri]) VALUES (21, N'2b14c2c7-66b5-dc74-9711-c9e7f3951ac8', 3, N'2')
INSERT [dbo].[ThongTinMoTa] ([ID], [MaTuLieu], [MaThuocTinh], [GiaTri]) VALUES (22, N'2b14c2c7-66b5-dc74-9711-c9e7f3951ac8', 1, N'1')
INSERT [dbo].[ThongTinMoTa] ([ID], [MaTuLieu], [MaThuocTinh], [GiaTri]) VALUES (23, N'2b14c2c7-66b5-dc74-9711-c9e7f3951ac8', 5, N'3')
INSERT [dbo].[ThongTinMoTa] ([ID], [MaTuLieu], [MaThuocTinh], [GiaTri]) VALUES (24, N'2b14c2c7-66b5-dc74-9711-c9e7f3951ac8', 16, N'5')
INSERT [dbo].[ThongTinMoTa] ([ID], [MaTuLieu], [MaThuocTinh], [GiaTri]) VALUES (25, N'2b14c2c7-66b5-dc74-9711-c9e7f3951ac8', 6, N'4')
INSERT [dbo].[ThongTinMoTa] ([ID], [MaTuLieu], [MaThuocTinh], [GiaTri]) VALUES (26, N'2b14c2c7-66b5-dc74-9711-c9e7f3951ac8', 8, N'6')
INSERT [dbo].[ThongTinMoTa] ([ID], [MaTuLieu], [MaThuocTinh], [GiaTri]) VALUES (27, N'8320fee4-39db-c6b4-fc63-e8ff1dacbcbb', 3, N'3122131')
INSERT [dbo].[ThongTinMoTa] ([ID], [MaTuLieu], [MaThuocTinh], [GiaTri]) VALUES (28, N'e2ef7919-bae1-08a2-b6ac-4652eb1407c7', 1, N'3123')
INSERT [dbo].[ThongTinMoTa] ([ID], [MaTuLieu], [MaThuocTinh], [GiaTri]) VALUES (29, N'e2ef7919-bae1-08a2-b6ac-4652eb1407c7', 3, N'12312')
INSERT [dbo].[ThongTinMoTa] ([ID], [MaTuLieu], [MaThuocTinh], [GiaTri]) VALUES (30, N'e2ef7919-bae1-08a2-b6ac-4652eb1407c7', 5, N'31')
INSERT [dbo].[ThongTinMoTa] ([ID], [MaTuLieu], [MaThuocTinh], [GiaTri]) VALUES (31, N'e2ef7919-bae1-08a2-b6ac-4652eb1407c7', 8, N'2')
INSERT [dbo].[ThongTinMoTa] ([ID], [MaTuLieu], [MaThuocTinh], [GiaTri]) VALUES (32, N'e2ef7919-bae1-08a2-b6ac-4652eb1407c7', 6, N'3')
INSERT [dbo].[ThongTinMoTa] ([ID], [MaTuLieu], [MaThuocTinh], [GiaTri]) VALUES (33, N'e2ef7919-bae1-08a2-b6ac-4652eb1407c7', 16, N'3')
SET IDENTITY_INSERT [dbo].[ThongTinMoTa] OFF
GO
SET IDENTITY_INSERT [dbo].[ThuocTinh] ON 

INSERT [dbo].[ThuocTinh] ([ID], [MaNhom], [TenThuocTinh], [MoTa], [KieuDuLieu]) VALUES (1, 3, N'Thể loại', NULL, 8)
INSERT [dbo].[ThuocTinh] ([ID], [MaNhom], [TenThuocTinh], [MoTa], [KieuDuLieu]) VALUES (3, 1, N'Hình thức trình diễn', NULL, 11)
INSERT [dbo].[ThuocTinh] ([ID], [MaNhom], [TenThuocTinh], [MoTa], [KieuDuLieu]) VALUES (5, 1, N'Nội dung của tư liệu', NULL, 15)
INSERT [dbo].[ThuocTinh] ([ID], [MaNhom], [TenThuocTinh], [MoTa], [KieuDuLieu]) VALUES (6, 3, N'Lời bản nhạc', NULL, 8)
INSERT [dbo].[ThuocTinh] ([ID], [MaNhom], [TenThuocTinh], [MoTa], [KieuDuLieu]) VALUES (8, 3, N'Ký âm theo tân nhạc', N'Chèn hình ảnh chụp tổng phổ ký âm theo tân nhạc', 9)
INSERT [dbo].[ThuocTinh] ([ID], [MaNhom], [TenThuocTinh], [MoTa], [KieuDuLieu]) VALUES (10, 1, N'Phân tích nghệ thuật', NULL, 15)
INSERT [dbo].[ThuocTinh] ([ID], [MaNhom], [TenThuocTinh], [MoTa], [KieuDuLieu]) VALUES (11, 1, N'Mô tả tư liệu', NULL, 15)
INSERT [dbo].[ThuocTinh] ([ID], [MaNhom], [TenThuocTinh], [MoTa], [KieuDuLieu]) VALUES (13, 1, N'Tư liệu dị bản', N'Liệt kê số thứ tự của các tư liệu được xem là dị bản của tư liệu này', 8)
INSERT [dbo].[ThuocTinh] ([ID], [MaNhom], [TenThuocTinh], [MoTa], [KieuDuLieu]) VALUES (14, 1, N'Các bài viết về tư liệu', NULL, 15)
INSERT [dbo].[ThuocTinh] ([ID], [MaNhom], [TenThuocTinh], [MoTa], [KieuDuLieu]) VALUES (15, 1, N'Trình Diễn', N'Chèn tập tin âm thanh trình diễn', 11)
INSERT [dbo].[ThuocTinh] ([ID], [MaNhom], [TenThuocTinh], [MoTa], [KieuDuLieu]) VALUES (16, 3, N'Ký âm theo cổ nhạc', N'Chèn hình ảnh chụp tổng phổ ký âm theo cổ nhạc', 9)
INSERT [dbo].[ThuocTinh] ([ID], [MaNhom], [TenThuocTinh], [MoTa], [KieuDuLieu]) VALUES (17, 4, N'Bối cảnh sử dụng', NULL, 8)
INSERT [dbo].[ThuocTinh] ([ID], [MaNhom], [TenThuocTinh], [MoTa], [KieuDuLieu]) VALUES (18, 4, N'Đối tượng sử dụng', NULL, 8)
INSERT [dbo].[ThuocTinh] ([ID], [MaNhom], [TenThuocTinh], [MoTa], [KieuDuLieu]) VALUES (19, 1, N'Vẽ tư liệu', NULL, 9)
INSERT [dbo].[ThuocTinh] ([ID], [MaNhom], [TenThuocTinh], [MoTa], [KieuDuLieu]) VALUES (20, 4, N'Nghệ nhân - nghệ sỹ từng thể hiện', NULL, 8)
SET IDENTITY_INSERT [dbo].[ThuocTinh] OFF
GO
INSERT [dbo].[TuLieu] ([ID], [MaLoaiTuLieu], [TenTuLieu], [HinhAnh], [MoTa], [NgayTao], [NgayCapNhatCuoi], [NguoiTao], [NguoiCapNhatCuoi]) VALUES (N'9fac472a-be01-4dde-bbb9-1a45bafb2b00', N'b6db8cf9-e46c-4a9d-bda8-69dbe224eb96', N'Giữ gìn giá trị đặc sắc của tuồng cung đình Huế', N'hinhand.jpg', N'motaa', CAST(N'2022-02-08T17:00:31.430' AS DateTime), CAST(N'2022-02-10T08:31:43.187' AS DateTime), 0, 0)
INSERT [dbo].[TuLieu] ([ID], [MaLoaiTuLieu], [TenTuLieu], [HinhAnh], [MoTa], [NgayTao], [NgayCapNhatCuoi], [NguoiTao], [NguoiCapNhatCuoi]) VALUES (N'e2ef7919-bae1-08a2-b6ac-4652eb1407c7', N'b6db8cf9-e46c-4a9d-bda8-69dbe224eb96', N'312', NULL, NULL, CAST(N'2022-02-10T16:54:35.790' AS DateTime), CAST(N'2022-02-10T16:54:35.790' AS DateTime), 0, 0)
INSERT [dbo].[TuLieu] ([ID], [MaLoaiTuLieu], [TenTuLieu], [HinhAnh], [MoTa], [NgayTao], [NgayCapNhatCuoi], [NguoiTao], [NguoiCapNhatCuoi]) VALUES (N'2b14c2c7-66b5-dc74-9711-c9e7f3951ac8', N'b6db8cf9-e46c-4a9d-bda8-69dbe224eb96', N'Nhã nhạc cung đình Huế', NULL, NULL, CAST(N'2022-02-10T16:52:15.323' AS DateTime), CAST(N'2022-02-10T16:52:15.323' AS DateTime), 0, 0)
INSERT [dbo].[TuLieu] ([ID], [MaLoaiTuLieu], [TenTuLieu], [HinhAnh], [MoTa], [NgayTao], [NgayCapNhatCuoi], [NguoiTao], [NguoiCapNhatCuoi]) VALUES (N'8320fee4-39db-c6b4-fc63-e8ff1dacbcbb', N'98187c1c-b9b1-4071-8d6e-403cd1f1da22', N'123', NULL, NULL, CAST(N'2022-02-10T16:52:44.080' AS DateTime), CAST(N'2022-02-10T16:52:44.080' AS DateTime), 0, 0)
GO
ALTER TABLE [dbo].[LoaiTuLieu] ADD  CONSTRAINT [DF_LoaiTuLieu_ID]  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[ThuocTinh] ADD  CONSTRAINT [DF_GD_ThuocTinh_KieuDuLieu]  DEFAULT ((0)) FOR [KieuDuLieu]
GO
ALTER TABLE [dbo].[TuLieu] ADD  CONSTRAINT [DF_TuLieu_ID]  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[LuocDoDuLieu]  WITH CHECK ADD  CONSTRAINT [FK_LuocDoDuLieu_LoaiTuLieu] FOREIGN KEY([MaLoaiTuLieu])
REFERENCES [dbo].[LoaiTuLieu] ([ID])
GO
ALTER TABLE [dbo].[LuocDoDuLieu] CHECK CONSTRAINT [FK_LuocDoDuLieu_LoaiTuLieu]
GO
ALTER TABLE [dbo].[LuocDoDuLieu]  WITH CHECK ADD  CONSTRAINT [FK_LuocDoDuLieu_ThuocTinh] FOREIGN KEY([MaThuocTinh])
REFERENCES [dbo].[ThuocTinh] ([ID])
GO
ALTER TABLE [dbo].[LuocDoDuLieu] CHECK CONSTRAINT [FK_LuocDoDuLieu_ThuocTinh]
GO
ALTER TABLE [dbo].[TepKemTheo]  WITH CHECK ADD  CONSTRAINT [FK_TepKemTheo_TuLieu] FOREIGN KEY([MaTuLieu])
REFERENCES [dbo].[TuLieu] ([ID])
GO
ALTER TABLE [dbo].[TepKemTheo] CHECK CONSTRAINT [FK_TepKemTheo_TuLieu]
GO
ALTER TABLE [dbo].[ThongTinMoTa]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinMoTa_ThuocTinh] FOREIGN KEY([MaThuocTinh])
REFERENCES [dbo].[ThuocTinh] ([ID])
GO
ALTER TABLE [dbo].[ThongTinMoTa] CHECK CONSTRAINT [FK_ThongTinMoTa_ThuocTinh]
GO
ALTER TABLE [dbo].[ThongTinMoTa]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinMoTa_TuLieu] FOREIGN KEY([MaTuLieu])
REFERENCES [dbo].[TuLieu] ([ID])
GO
ALTER TABLE [dbo].[ThongTinMoTa] CHECK CONSTRAINT [FK_ThongTinMoTa_TuLieu]
GO
ALTER TABLE [dbo].[ThuocTinh]  WITH CHECK ADD  CONSTRAINT [FK_ThuocTinh_KieuDuLieu] FOREIGN KEY([KieuDuLieu])
REFERENCES [dbo].[KieuDuLieu] ([ID])
GO
ALTER TABLE [dbo].[ThuocTinh] CHECK CONSTRAINT [FK_ThuocTinh_KieuDuLieu]
GO
ALTER TABLE [dbo].[ThuocTinh]  WITH CHECK ADD  CONSTRAINT [FK_ThuocTinh_NhomThuocTinh1] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NhomThuocTinh] ([ID])
GO
ALTER TABLE [dbo].[ThuocTinh] CHECK CONSTRAINT [FK_ThuocTinh_NhomThuocTinh1]
GO
ALTER TABLE [dbo].[TuLieu]  WITH CHECK ADD  CONSTRAINT [FK_TuLieu_LoaiTuLieu] FOREIGN KEY([MaLoaiTuLieu])
REFERENCES [dbo].[LoaiTuLieu] ([ID])
GO
ALTER TABLE [dbo].[TuLieu] CHECK CONSTRAINT [FK_TuLieu_LoaiTuLieu]
GO
/****** Object:  StoredProcedure [dbo].[SPKieuDuLieu_ChinhSua]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Chinh sua kieu du lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPKieuDuLieu_ChinhSua]
		@ID tinyint,
		@TenKieuDuLieu nvarchar(50)
AS
BEGIN
	
	DECLARE @Result nvarchar(100) = 'Failure'
	BEGIN TRY
		UPDATE [dbo].[KieuDuLieu]
			SET [TenKieuDuLieu] = @TenKieuDuLieu
			WHERE ID = @ID
			SET @Result = 'Success'
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result

END

--SELECT * FROM KieuDuLieu
----EXEC SPKieuTuLieu_ChinhSua @ID = 10, @TenKieuDuLieu = 'mo taa'
GO
/****** Object:  StoredProcedure [dbo].[SPKieuDuLieu_DanhSach]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Danh sach kieu du lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPKieuDuLieu_DanhSach]

AS
BEGIN

SELECT [ID]
      ,[TenKieuDuLieu]
  FROM [dbo].[KieuDuLieu]

END

--EXEC SPKieuTuLieu_DanhSach
GO
/****** Object:  StoredProcedure [dbo].[SPKieuDuLieu_LayID]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Lay ID kieu du lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPKieuDuLieu_LayID]
		@ID tinyint
AS
BEGIN

SELECT [ID]
      ,[TenKieuDuLieu]
  FROM [dbo].[KieuDuLieu]
  WHERE ID = @ID
END

--EXEC SPKieuTuLieu_DanhSach
GO
/****** Object:  StoredProcedure [dbo].[SPKieuDuLieu_TaoMoi]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Tao moi kieu du lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPKieuDuLieu_TaoMoi]
		@TenKieuDuLieu nvarchar(50)
AS
BEGIN


DECLARE @Result nvarchar(100) = 'Failure'
	BEGIN TRY
		INSERT INTO [dbo].[KieuDuLieu]
					([TenKieuDuLieu])
			VALUES	(@TenKieuDuLieu)
			SET @Result = 'Success'
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result


END

--SELECT * FROM KieuDuLieu
----EXEC SPKieuTuLieu_TaoMoi @TenKieuDuLieu = 'dacta'
GO
/****** Object:  StoredProcedure [dbo].[SPKieuDuLieu_XoaBo]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Xoa bo kieu du lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPKieuDuLieu_XoaBo]
		@ID tinyint
AS
BEGIN

DECLARE @Result BIT = 0
	BEGIN TRY
			DELETE FROM [dbo].[KieuDuLieu]
				WHERE ID = @ID
				SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result

END

--SELECT * FROM KieuDuLieu
----EXEC SPKieuTuLieu_XoaBo @ID = 10
GO
/****** Object:  StoredProcedure [dbo].[SPLoaiTuLieu_ChinhSua]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Chinh sua loai tu lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPLoaiTuLieu_ChinhSua]
		@ID UNIQUEIDENTIFIER,
		@TenLoaiTuLieu NVARCHAR(200),
		@MoTa NVARCHAR(MAX)
AS
BEGIN

DECLARE @Result nvarchar(100) = 'Failure'
	BEGIN TRY
		UPDATE [dbo].[LoaiTuLieu]
		   SET [MaLoaiCapCha] = null
			  ,[TenLoaiTuLieu] = @TenLoaiTuLieu
			  ,[MoTa] = @MoTa
		 WHERE ID = @ID
		 SET @Result = 'Success'
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result

END


--SELECT * FROM LoaiTuLieu
--EXEC SPLoaiTuLieu_ChinhSua @ID = '6DF2D1BC-1B41-4B0F-98E0-12A74A563F42', @TenLoaiTuLieu = 'Dao cu san khau', @MoTa = 'editeddd'
GO
/****** Object:  StoredProcedure [dbo].[SPLoaiTuLieu_DanhSach]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Danh sach loai tu lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPLoaiTuLieu_DanhSach]

AS
BEGIN

SELECT [ID]
      ,[TenLoaiTuLieu]
      ,[MoTa]
  FROM [dbo].[LoaiTuLieu]

END

--EXEC SPLoaiTuLieu_DanhSach
GO
/****** Object:  StoredProcedure [dbo].[SPLoaiTuLieu_LayID]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Lay ID loai tu lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPLoaiTuLieu_LayID]
		@ID UNIQUEIDENTIFIER
AS
BEGIN
	SELECT	[ID]
			,[TenLoaiTuLieu]
			,[MoTa]
		FROM [dbo].[LoaiTuLieu]
		WHERE ID = @ID
END


--SELECT * FROM LoaiTuLieu
--EXEC SPLoaiTuLieu_LayID @ID = '838C530D-4F46-4B58-9658-D4D364E8142F'
GO
/****** Object:  StoredProcedure [dbo].[SPLoaiTuLieu_TaoMoi]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Tao moi loai tu lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPLoaiTuLieu_TaoMoi]
		@TenLoaiTuLieu NVARCHAR(200),
		@MoTa NVARCHAR(MAX)
AS
BEGIN

DECLARE @Result nvarchar(100) = 'Failure'
	BEGIN TRY
		INSERT INTO [dbo].[LoaiTuLieu]
				   ([MaLoaiCapCha]
				   ,[TenLoaiTuLieu]
				   ,[MoTa])
			 VALUES
				   (null
				   ,@TenLoaiTuLieu
				   ,@MoTa)
			SET @Result = 'Success'
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result
END


--SELECT * FROM LoaiTuLieu
--EXEC SPLoaiTuLieu_TaoMoi @TenLoaiTuLieu = 'Tu ngu tuong', @MoTa = '1'
GO
/****** Object:  StoredProcedure [dbo].[SPLoaiTuLieu_XoaBo]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Xoa bo loai tu lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPLoaiTuLieu_XoaBo]
		@ID UNIQUEIDENTIFIER
AS
BEGIN

DECLARE @Result BIT = 0
	BEGIN TRY
		DELETE FROM [dbo].[LoaiTuLieu]
			  WHERE ID = @ID
			  SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result
END


--SELECT * FROM LoaiTuLieu
--EXEC SPLoaiTuLieu_XoaBo @ID = '6DF2D1BC-1B41-4B0F-98E0-12A74A563F42'
GO
/****** Object:  StoredProcedure [dbo].[SPLuocDoDuLieu_ChinhSua]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Chinh sua luoc do du lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPLuocDoDuLieu_ChinhSua]
		@ID int,
		@MaThuocTinh int,
		@BatBuoc bit,
		@LapLai bit,
		@ThuTu smallint,
		@DoDai int,
		@MaLoaiTuLieu uniqueidentifier
AS
BEGIN

	DECLARE @Result nvarchar(100) = 'Failure'
	BEGIN TRY

		UPDATE [dbo].[LuocDoDuLieu]
		   SET [MaThuocTinh] = @MaThuocTinh
			  ,[BatBuoc] = @BatBuoc
			  ,[LapLai] = @LapLai
			  ,[ThuTu] = @ThuTu
			  ,[DoDai] = @DoDai
			  ,[MaLoaiTuLieu] = @MaLoaiTuLieu
		 WHERE ID = @ID
		 SET @Result = 'Success'
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result

END


--SELECT * FROM LoaiTuLieu
--SELECT * FROM ThuocTinh
--SELECT * FROM LuocDoDuLieu
--EXEC SPLuocDoDuLieu_ChinhSua @ID = 1, @MaThuocTinh = 3, @BatBuoc = false , @LapLai = false, @ThuTu = 9, @DoDai = 100000, @MaLoaiTuLieu = '7DB0D3E7-6164-4237-89CD-4923ABA5253E'

GO
/****** Object:  StoredProcedure [dbo].[SPLuocDoDuLieu_DanhSach]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Danh sach luoc do du lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPLuocDoDuLieu_DanhSach]

AS
BEGIN
	SELECT lddl.ID, ltl.TenLoaiTuLieu, tt.TenThuocTinh, lddl.BatBuoc, lddl.LapLai, lddl.ThuTu 
	FROM LuocDoDuLieu AS lddl, ThuocTinh AS tt, LoaiTuLieu AS ltl
	WHERE lddl.MaLoaiTuLieu = ltl.ID
	AND lddl.MaThuocTinh = tt.ID
END

--EXEC SPLuocDoDuLieu_DanhSach
GO
/****** Object:  StoredProcedure [dbo].[SPLuocDoDuLieu_LayID]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Lay ID luoc do du lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPLuocDoDuLieu_LayID]
		@ID int
AS
BEGIN
	SELECT lddl.ID, lddl.MaThuocTinh, lddl.BatBuoc, lddl.LapLai, lddl.ThuTu, lddl.DoDai, lddl.MaLoaiTuLieu, tt.MaNhom 
	FROM LuocDoDuLieu AS lddl, ThuocTinh AS tt
	WHERE lddl.MaThuocTinh = tt.ID
	AND lddl.ID = @ID

END

--EXEC SPLuocDoDuLieu_LayID @ID = 2
GO
/****** Object:  StoredProcedure [dbo].[SPLuocDoDuLieu_TaoMoi]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Tao moi luoc do du lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPLuocDoDuLieu_TaoMoi]
		@MaThuocTinh int,
		@BatBuoc bit,
		@LapLai bit,
		@ThuTu smallint,
		@DoDai int,
		@MaLoaiTuLieu uniqueidentifier
AS
BEGIN

	DECLARE @Result nvarchar(100) = 'Failure'
	BEGIN TRY

		INSERT INTO [dbo].[LuocDoDuLieu]
				   ([MaThuocTinh]
				   ,[BatBuoc]
				   ,[LapLai]
				   ,[ThuTu]
				   ,[DoDai]
				   ,[MaLoaiTuLieu])
			 VALUES
				   (@MaThuocTinh
				   ,@BatBuoc
				   ,@LapLai
				   ,@ThuTu
				   ,@DoDai
				   ,@MaLoaiTuLieu)
			   SET @Result = 'Success'

	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result

END


--SELECT * FROM LoaiTuLieu
--SELECT * FROM ThuocTinh
--SELECT * FROM LuocDoDuLieu
--EXEC SPLuocDoDuLieu_TaoMoi @MaThuocTinh = 3, @BatBuoc = false , @LapLai = false, @ThuTu = 9, @DoDai = 100, @MaLoaiTuLieu = '7DB0D3E7-6164-4237-89CD-4923ABA5253E'
GO
/****** Object:  StoredProcedure [dbo].[SPLuocDoDuLieu_XoaBo]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Xoa bo luoc do du lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPLuocDoDuLieu_XoaBo]
		@ID int

AS
BEGIN

	DECLARE @Result BIT = 0
	BEGIN TRY

		DELETE FROM [dbo].[LuocDoDuLieu]
			  WHERE ID = @ID
			  SET @Result = 1

	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result

END


--SELECT * FROM LuocDoDuLieu
--EXEC SPLuocDoDuLieu_XoaBo @ID = 1
GO
/****** Object:  StoredProcedure [dbo].[SPNhomThuocTinh_ChinhSua]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Chinh sua nhom thuoc tinh
-- =============================================
CREATE PROCEDURE [dbo].[SPNhomThuocTinh_ChinhSua]
		@ID int,
		@TenNhom nvarchar(100),
		@MoTa nvarchar(max)
AS
BEGIN

DECLARE @Result nvarchar(100) = 'Failure'
	BEGIN TRY
		UPDATE [dbo].[NhomThuocTinh]
		   SET [TenNhom] = @TenNhom
			  ,[MoTa] = @MoTa
		 WHERE ID = @ID
 		 SET @Result = 'Success'
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result

END

--SELECT * FROM NhomThuocTinh
--EXEC SPNhomThuocTinh_ChinhSua @ID = '2212', @TenNhom = 'edited', @MoTa = '32131'



	
GO
/****** Object:  StoredProcedure [dbo].[SPNhomThuocTinh_DanhSach]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Danh sach nhom thuoc tinh
-- =============================================
CREATE PROCEDURE [dbo].[SPNhomThuocTinh_DanhSach]

AS
BEGIN

SELECT [ID]
      ,[TenNhom]
      ,[MoTa]
  FROM [dbo].[NhomThuocTinh]

END

--EXEC SPNhomThuocTinh_DanhSach 
GO
/****** Object:  StoredProcedure [dbo].[SPNhomThuocTinh_LayID]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Lay ID nhom thuoc tinh
-- =============================================
CREATE PROCEDURE [dbo].[SPNhomThuocTinh_LayID]
		@ID INT

AS
BEGIN

SELECT [ID]
      ,[TenNhom]
      ,[MoTa]
  FROM [dbo].[NhomThuocTinh]
  WHERE ID = @ID

END

--EXEC SPNhomThuocTinh_LayID @ID = 2
GO
/****** Object:  StoredProcedure [dbo].[SPNhomThuocTinh_TaoMoi]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Tao moi nhom thuoc tinh
-- =============================================
CREATE PROCEDURE [dbo].[SPNhomThuocTinh_TaoMoi]
		@TenNhom nvarchar(100),
		@MoTa nvarchar(max)

AS
BEGIN

	DECLARE @Result nvarchar(100) = 'Failure'
	BEGIN TRY
		INSERT INTO [dbo].[NhomThuocTinh]
				   ([TenNhom]
				   ,[MoTa])
			 VALUES
				   (@TenNhom
				   ,@MoTa)
			   SET @Result = 'Success'
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result

END

--EXEC SPNhomThuocTinh_TaoMoi @TenNhom = 'nhom01', @MoTa = 'mota'
GO
/****** Object:  StoredProcedure [dbo].[SPNhomThuocTinh_XoaBo]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Xoa bo nhom thuoc tinh
-- =============================================
CREATE PROCEDURE [dbo].[SPNhomThuocTinh_XoaBo]
		@ID INT

AS
BEGIN
	DECLARE @Result BIT = 0
	BEGIN TRY
		DELETE FROM [dbo].[NhomThuocTinh]
			  WHERE ID = @ID
		SET @Result = 1
	 END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result
END

--SELECT * FROM NhomThuocTinh
--SPNhomThuocTinh_XoaBo @ID = 2

GO
/****** Object:  StoredProcedure [dbo].[SPThongTinMoTa_ChinhSua]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Chinh sua thong tin mo ta
-- =============================================
CREATE PROCEDURE [dbo].[SPThongTinMoTa_ChinhSua]
		@ID int,
		@MaTuLieu uniqueidentifier,
		@MaThuocTinh int,
		@GiaTri nvarchar(max)
AS
BEGIN

DECLARE @Result nvarchar(100) = 'Failure'
	BEGIN TRY
		UPDATE [dbo].[ThongTinMoTa]
		   SET [MaTuLieu] = @MaTuLieu
			  ,[MaThuocTinh] = @MaThuocTinh
			  ,[GiaTri] = @GiaTri
		 WHERE ID = @ID
 		 SET @Result = 'Success'
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result

END

--SELECT * FROM TuLieu
--SELECT * FROM ThuocTinh
--SELECT * FROM ThongTinMoTa
--EXEC SPThongTinMoTa_ChinhSua @ID = 1, @MaTuLieu = '9FAC472A-BE01-4DDE-BBB9-1A45BAFB2B00', @MaThuocTinh = 2, @GiaTri = 'edited'



	
GO
/****** Object:  StoredProcedure [dbo].[SPThongTinMoTa_DanhSach]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Danh sach thong tin mo ta
-- =============================================
CREATE PROCEDURE [dbo].[SPThongTinMoTa_DanhSach]

AS
BEGIN
	SELECT ttmt.ID, tl.TenTuLieu, tt.TenThuocTinh, ttmt.GiaTri 
	FROM ThongTinMoTa AS ttmt, TuLieu as tl, ThuocTinh as tt 
	WHERE ttmt.MaThuocTinh = tt.ID 
	AND ttmt.MaTuLieu = tl.ID


END

--SELECT * FROM TuLieu
--SELECT * FROM ThuocTinh
--SELECT * FROM ThongTinMoTa
--EXEC SPThongTinMoTa_DanhSach
GO
/****** Object:  StoredProcedure [dbo].[SPThongTinMoTa_LayID]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Danh sach thong tin mo ta
-- =============================================
CREATE PROCEDURE [dbo].[SPThongTinMoTa_LayID]
		@ID int
AS
BEGIN

	SELECT [ID]
		  ,[MaTuLieu]
		  ,[MaThuocTinh]
		  ,[GiaTri]
	  FROM [dbo].[ThongTinMoTa]
	  WHERE ID = @ID
END

--EXEC SPThongTinMoTa_LayID @ID = 2
GO
/****** Object:  StoredProcedure [dbo].[SPThongTinMoTa_TaoMoi]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Tao moi thong tin mo ta
-- =============================================
CREATE PROCEDURE [dbo].[SPThongTinMoTa_TaoMoi]
		@MaTuLieu uniqueidentifier,
		@MaThuocTinh int,
		@GiaTri nvarchar(max)
AS
BEGIN

DECLARE @Result nvarchar(100) = 'Failure'
	BEGIN TRY

		INSERT INTO [dbo].[ThongTinMoTa]
				   ([MaTuLieu]
				   ,[MaThuocTinh]
				   ,[GiaTri])
			 VALUES
				   (@MaTuLieu
				   ,@MaThuocTinh
				   ,@GiaTri)
 		 SET @Result = 'Success'
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result

END

--SELECT * FROM TuLieu
--SELECT * FROM ThuocTinh
--SELECT * FROM ThongTinMoTa
--EXEC SPThongTinMoTa_TaoMoi @MaTuLieu = '9FAC472A-BE01-4DDE-BBB9-1A45BAFB2B00', @MaThuocTinh = 3, @GiaTri = 'SqweDFD'




	
GO
/****** Object:  StoredProcedure [dbo].[SPThongTinMoTa_XoaBo]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Xoa bo thong tin mo ta
-- =============================================
CREATE PROCEDURE [dbo].[SPThongTinMoTa_XoaBo]
		@ID int

AS
BEGIN

DECLARE @Result BIT = 0
	BEGIN TRY
		DELETE FROM [dbo].[ThongTinMoTa]
			  WHERE ID = @ID
 		 SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result

END

--SELECT * FROM TuLieu
--SELECT * FROM ThuocTinh
--SELECT * FROM ThongTinMoTa
--EXEC SPThongTinMoTa_TaoMoi @MaTuLieu = '9FAC472A-BE01-4DDE-BBB9-1A45BAFB2B00', @MaThuocTinh = 3, @GiaTri = 'SqweDFD'




	
GO
/****** Object:  StoredProcedure [dbo].[SPThongTinTuLieu_LayID]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 10.01.2022
-- Description:	Lay ID thong tin tu lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPThongTinTuLieu_LayID]
		@ID uniqueidentifier
AS
BEGIN

	SELECT tl.ID, ltl.TenLoaiTuLieu, tl.TenTuLieu, lddl.MaThuocTinh, tt.TenThuocTinh, ttmt.GiaTri
	FROM TuLieu AS tl, LoaiTuLieu as ltl, LuocDoDuLieu AS lddl, ThuocTinh AS tt, ThongTinMoTa AS ttmt
	WHERE tl.MaLoaiTuLieu = ltl.ID
	AND lddl.MaLoaiTuLieu = ltl.ID
	AND lddl.MaThuocTinh = tt.ID
	AND ttmt.MaTuLieu = tl.ID
	AND ttmt.MaThuocTinh = tt.ID
	AND tl.ID = @ID

END

-- SPThongTinTuLieu_LayID @ID = '9FAC472A-BE01-4DDE-BBB9-1A45BAFB2B00'
GO
/****** Object:  StoredProcedure [dbo].[SPThongTinTuLieu_ThuocTinh]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Lay theo loai tu lieu luoc do du lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPThongTinTuLieu_ThuocTinh]
		@MaLoaiTuLieu uniqueidentifier
AS
BEGIN
	SELECT  ltl.TenLoaiTuLieu, lddl.MaThuocTinh, tt.TenThuocTinh, kdl.TenKieuDuLieu, lddl.BatBuoc, lddl.LapLai, lddl.ThuTu, lddl.DoDai
	FROM LuocDoDuLieu AS lddl, ThuocTinh AS tt, KieuDuLieu AS kdl, LoaiTuLieu as ltl
	WHERE lddl.MaThuocTinh = tt.ID
	AND tt.KieuDuLieu = kdl.ID
	AND lddl.MaLoaiTuLieu = ltl.ID
	AND lddl.MaLoaiTuLieu = @MaLoaiTuLieu

END

--SELECT * FROM LuocDoDuLieu
--EXEC SPThongTinTuLieu_LayTheoLoaiTuLieu @MaLoaiTuLieu = 'B6DB8CF9-E46C-4A9D-BDA8-69DBE224EB96'
GO
/****** Object:  StoredProcedure [dbo].[SPThuocTinh_ChinhSua]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Tao moi thuoc tinh
-- =============================================
CREATE PROCEDURE [dbo].[SPThuocTinh_ChinhSua]
		@ID int,
		@MaNhom int,
		@TenThuocTinh nvarchar(100),
		@MoTa nvarchar(max),
		@KieuDuLieu tinyint

AS
BEGIN

	DECLARE @Result nvarchar(100) = 'Failure'
	BEGIN TRY

		UPDATE [dbo].[ThuocTinh]
		   SET [MaNhom] = @MaNhom
			  ,[TenThuocTinh] = @TenThuocTinh
			  ,[MoTa] = @MoTa
			  ,[KieuDuLieu] = @KieuDuLieu
		 WHERE ID = @ID	
			SET @Result = 'Success'

	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result

END

--SELECT * FROM NhomThuocTinh
--SELECT * FROM KieuDuLieu
--SELECT * FROM ThuocTinh
--EXEC SPThuocTinh_ChinhSua @ID = 3, @MaNhom = '1', @TenThuocTinh = '43131232312', @MoTa = 'edited', @KieuDuLieu = '12'
GO
/****** Object:  StoredProcedure [dbo].[SPThuocTinh_DanhSach]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Danh sach thuoc tinh
-- =============================================
CREATE PROCEDURE [dbo].[SPThuocTinh_DanhSach]
	@MaNhom int
AS
BEGIN
	SELECT tt.ID, ntt.TenNhom, tt.TenThuocTinh, kdl.TenKieuDuLieu, tt.MoTa, tt.MaNhom
	FROM KieuDuLieu AS kdl, NhomThuocTinh AS ntt, ThuocTinh AS tt
	WHERE tt.MaNhom = ntt.ID
	AND tt.KieuDuLieu = kdl.ID
	AND (@MaNhom IS NULL OR @MaNhom = tt.MaNhom)
	ORDER BY ntt.TenNhom ASC;


END

--SELECT * FROM NhomThuocTinh
--SELECT * FROM KieuDuLieu
--SELECT * FROM ThuocTinh
--EXEC SPThuocTinh_DanhSach
GO
/****** Object:  StoredProcedure [dbo].[SPThuocTinh_LayID]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Lay ID thuoc tinh
-- =============================================
CREATE PROCEDURE [dbo].[SPThuocTinh_LayID]
		@ID INT

AS
BEGIN

SELECT [ID]
      ,[MaNhom]
      ,[TenThuocTinh]
      ,[MoTa]
      ,[KieuDuLieu]
  FROM [dbo].[ThuocTinh]
  WHERE ID = @ID

END

--EXEC SPThuocTinh_LayID @ID = 1
GO
/****** Object:  StoredProcedure [dbo].[SPThuocTinh_TaoMoi]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Tao moi thuoc tinh
-- =============================================
CREATE PROCEDURE [dbo].[SPThuocTinh_TaoMoi]
		@MaNhom int,
		@TenThuocTinh nvarchar(100),
		@MoTa nvarchar(max),
		@KieuDuLieu tinyint

AS
BEGIN

	DECLARE @Result nvarchar(100) = 'Failure'
	BEGIN TRY

		INSERT INTO [dbo].[ThuocTinh]
				   ([MaNhom]
				   ,[TenThuocTinh]
				   ,[MoTa]
				   ,[KieuDuLieu])
			 VALUES
				   (@MaNhom
				   ,@TenThuocTinh
				   ,@MoTa
				   ,@KieuDuLieu)
			   SET @Result = 'Success'

	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result

END


--SELECT * FROM KieuDuLieu
--SELECT * FROM NhomThuocTinh
--SELECT * FROM ThuocTinh
--EXEC SPThuocTinh_TaoMoi @MaNhom = '1', @TenThuocTinh = '43131232312', @MoTa = 'mota', @KieuDuLieu = '9'
GO
/****** Object:  StoredProcedure [dbo].[SPThuocTinh_XoaBo]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Xoa bo thuoc tinh
-- =============================================
CREATE PROCEDURE [dbo].[SPThuocTinh_XoaBo]
		@ID int

AS
BEGIN

	DECLARE @Result BIT = 0
	BEGIN TRY

		DELETE FROM [dbo].[ThuocTinh]
			  WHERE ID = @ID
			SET @Result = 1

	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result

END

--SELECT * FROM ThuocTinh
--EXEC SPThuocTinh_XoaBo @ID = 2
GO
/****** Object:  StoredProcedure [dbo].[SPTuLieu_ChinhSua]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Chinh sua tu lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPTuLieu_ChinhSua]
		@ID uniqueidentifier,
		@MaLoaiTuLieu uniqueidentifier,
		@TenTuLieu nvarchar(500),
		@HinhAnh nvarchar(max),
		@MoTa nvarchar(max),
		@NguoiTao int,
		@NguoiCapNhatCuoi int
AS
BEGIN

DECLARE @Result nvarchar(100) = 'Failure'
	BEGIN TRY
		UPDATE [dbo].[TuLieu]
		   SET [MaLoaiTuLieu] = @MaLoaiTuLieu
			  ,[TenTuLieu] = @TenTuLieu
			  ,[HinhAnh] = @HinhAnh
			  ,[MoTa] = @MoTa
			  ,[NgayCapNhatCuoi] = GETDATE()
			  ,[NguoiTao] = @NguoiTao
			  ,[NguoiCapNhatCuoi] = @NguoiCapNhatCuoi
		 WHERE ID = @ID
 		 SET @Result = 'Success'
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result

END

--SELECT * FROM LoaiTuLieu
--SELECT * FROM TuLieu
--EXEC SPTuLieu_ChinhSua @ID = 'F31D909C-BB4A-45D1-B310-E674A5B3B4BB', @MaLoaiTuLieu = '3618DA7F-7207-40C3-BE81-C52BEFF9C05D', 
--@TenTuLieu = 'edited', @HinhAnh = 'hinhand.jpg', @MoTa = 'mota', @NguoiTao = null,  @NguoiCapNhatCuoi = null



	
GO
/****** Object:  StoredProcedure [dbo].[SPTuLieu_DanhSach]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Danh sach tu lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPTuLieu_DanhSach]
	@ID uniqueidentifier
AS
BEGIN

	SELECT tl.ID, ltl.TenLoaiTuLieu, tl.TenTuLieu, tl.HinhAnh, tl.MoTa, tl.NgayTao, tl.NgayCapNhatCuoi, tl.NguoiTao, tl.NguoiCapNhatCuoi 
	FROM TuLieu AS tl, LoaiTuLieu AS ltl 
	WHERE tl.MaLoaiTuLieu = ltl.ID
	AND (@ID = '00000000-0000-0000-0000-000000000000' OR tl.ID = @ID)

END

--EXEC SPTuLieu_DanhSach @ID = null
GO
/****** Object:  StoredProcedure [dbo].[SPTuLieu_LayID]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Lay ID tu lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPTuLieu_LayID]
		@ID uniqueidentifier
AS
BEGIN

	SELECT [ID]
		  ,[MaLoaiTuLieu]
		  ,[TenTuLieu]
		  ,[HinhAnh]
		  ,[MoTa]
		  ,[NgayTao]
		  ,[NgayCapNhatCuoi]
		  ,[NguoiTao]
		  ,[NguoiCapNhatCuoi]
	  FROM [dbo].[TuLieu]
	  WHERE ID = @ID

END

--EXEC SPTuLieu_LayID
GO
/****** Object:  StoredProcedure [dbo].[SPTuLieu_TaoMoi]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Tao moi tu lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPTuLieu_TaoMoi]
		@ID uniqueidentifier,
		@MaLoaiTuLieu uniqueidentifier,
		@TenTuLieu nvarchar(500),
		@HinhAnh nvarchar(max),
		@MoTa nvarchar(max),
		@NguoiTao int,
		@NguoiCapNhatCuoi int
AS
BEGIN

DECLARE @Result nvarchar(100) = 'Failure'
	BEGIN TRY
		INSERT INTO [dbo].[TuLieu]
				   ([ID]
				   ,[MaLoaiTuLieu]
				   ,[TenTuLieu]
				   ,[HinhAnh]
				   ,[MoTa]
				   ,[NgayTao]
				   ,[NgayCapNhatCuoi]
				   ,[NguoiTao]
				   ,[NguoiCapNhatCuoi])
			 VALUES
				   (@ID
				   ,@MaLoaiTuLieu
				   ,@TenTuLieu
				   ,@HinhAnh
				   ,@MoTa
				   ,getdate()
				   ,getdate()
				   ,@NguoiTao
				   ,@NguoiCapNhatCuoi)
 		 SET @Result = 'Success'
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result

END


--SELECT * FROM LoaiTuLieu
--SELECT * FROM TuLieu
--EXEC SPTuLieu_TaoMoi @MaLoaiTuLieu = '3618DA7F-7207-40C3-BE81-C52BEFF9C05D', @TenTuLieu = '32131', @HinhAnh = 'hinhand.jpg', @MoTa = 'mota', @NguoiTao = null,  @NguoiCapNhatCuoi = null





	
GO
/****** Object:  StoredProcedure [dbo].[SPTuLieu_XoaBo]    Script Date: 2/14/2022 2:20:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huynh Duc Quang Huy
-- Create date: 08.01.2022
-- Description:	Xoa bo tu lieu
-- =============================================
CREATE PROCEDURE [dbo].[SPTuLieu_XoaBo]
		@ID uniqueidentifier

AS
BEGIN

DECLARE @Result BIT = 0
	BEGIN TRY
		DELETE FROM [dbo].[TuLieu]
			  WHERE ID = @ID
 		 SET @Result = 1
	END TRY
	BEGIN CATCH
	END CATCH
	SELECT @Result AS Result

END

--SELECT * FROM NhomThuocTinh
--EXEC SPNhomThuocTinh_ChinhSua @ID = '2212', @TenNhom = 'edited', @MoTa = '32131'



	
GO
