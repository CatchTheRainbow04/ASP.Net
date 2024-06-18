USE [TDTDK22CNT2LESSON09DB]
GO
/****** Object:  Table [dbo].[tdtdKhoa]    Script Date: 18/06/2024 05:00:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tdtdKhoa](
	[TdtdMaKH] [nchar](10) NOT NULL,
	[TdtdTenKH] [nvarchar](50) NULL,
	[TdtdTrangThai] [bit] NULL,
 CONSTRAINT [PK_tdtdKhoa] PRIMARY KEY CLUSTERED 
(
	[TdtdMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tdtdSinhVien]    Script Date: 18/06/2024 05:00:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tdtdSinhVien](
	[TdtdMaSV] [nvarchar](50) NOT NULL,
	[TdtdHoSV] [nvarchar](50) NULL,
	[TdtdTenSV] [nvarchar](50) NULL,
	[TdtdNgaySinh] [date] NULL,
	[TdtdGioiTinh] [bit] NULL,
	[TdtdPhone] [nchar](10) NULL,
	[TdtdEmail] [nvarchar](50) NULL,
	[TdtdMaKH] [nchar](10) NULL,
 CONSTRAINT [PK_tdtdSinhVien] PRIMARY KEY CLUSTERED 
(
	[TdtdMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tdtdKhoa] ([TdtdMaKH], [TdtdTenKH], [TdtdTrangThai]) VALUES (N'CNTT      ', N'Công Nghệ Thông Tin', 1)
INSERT [dbo].[tdtdKhoa] ([TdtdMaKH], [TdtdTenKH], [TdtdTrangThai]) VALUES (N'K22CNT2   ', N'K22CNT2', 1)
INSERT [dbo].[tdtdKhoa] ([TdtdMaKH], [TdtdTenKH], [TdtdTrangThai]) VALUES (N'NN        ', N'Ngôn ngữ Nhật', 1)
GO
INSERT [dbo].[tdtdSinhVien] ([TdtdMaSV], [TdtdHoSV], [TdtdTenSV], [TdtdNgaySinh], [TdtdGioiTinh], [TdtdPhone], [TdtdEmail], [TdtdMaKH]) VALUES (N'K22CNT2', N'Tạ Đình Thành', N'Doanh', CAST(N'2004-04-21' AS Date), 1, N'0967055032', N'doanhdoe@gmail.com', N'K22CNT2   ')
GO
ALTER TABLE [dbo].[tdtdSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_tdtdSinhVien_tdtdKhoa] FOREIGN KEY([TdtdMaKH])
REFERENCES [dbo].[tdtdKhoa] ([TdtdMaKH])
GO
ALTER TABLE [dbo].[tdtdSinhVien] CHECK CONSTRAINT [FK_tdtdSinhVien_tdtdKhoa]
GO
