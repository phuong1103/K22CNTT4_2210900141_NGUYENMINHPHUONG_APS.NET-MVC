USE [NguyenMinhPhuong_2210900141]
GO
/****** Object:  Table [dbo].[NMP_SACH]    Script Date: 12/07/2024 2:26:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NMP_SACH](
	[Nmp_MaSach] [nchar](10) NOT NULL,
	[Nmp_TenSach] [nvarchar](150) NULL,
	[Nmp_SoTrang] [int] NULL,
	[Nmp_NamXB] [int] NULL,
	[Nmp_MaTG] [nchar](10) NULL,
	[Nmp_TrangThai] [bit] NULL,
 CONSTRAINT [PK_NMP_SACH] PRIMARY KEY CLUSTERED 
(
	[Nmp_MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NMP_TACGIA]    Script Date: 12/07/2024 2:26:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NMP_TACGIA](
	[Nmp_MaTG] [nchar](10) NOT NULL,
	[NmpTenTacGia] [nvarchar](50) NULL,
 CONSTRAINT [PK_NMP_TACGIA] PRIMARY KEY CLUSTERED 
(
	[Nmp_MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NMP_SACH] ([Nmp_MaSach], [Nmp_TenSach], [Nmp_SoTrang], [Nmp_NamXB], [Nmp_MaTG], [Nmp_TrangThai]) VALUES (N'2210900128', N'Dế Mèn Phiêu Lưu Kí', 200, 2022, N'TG003     ', 1)
INSERT [dbo].[NMP_SACH] ([Nmp_MaSach], [Nmp_TenSach], [Nmp_SoTrang], [Nmp_NamXB], [Nmp_MaTG], [Nmp_TrangThai]) VALUES (N'2210900132', N'Truyện kiều', 1800, 1987, N'TG002     ', 0)
INSERT [dbo].[NMP_SACH] ([Nmp_MaSach], [Nmp_TenSach], [Nmp_SoTrang], [Nmp_NamXB], [Nmp_MaTG], [Nmp_TrangThai]) VALUES (N'2210900141', N'Nguyễn Minh Phương', 80, 2004, N'TG001     ', 1)
GO
INSERT [dbo].[NMP_TACGIA] ([Nmp_MaTG], [NmpTenTacGia]) VALUES (N'TG001     ', N'Nguyễn Minh Phương')
INSERT [dbo].[NMP_TACGIA] ([Nmp_MaTG], [NmpTenTacGia]) VALUES (N'TG002     ', N'Tô Hoài')
INSERT [dbo].[NMP_TACGIA] ([Nmp_MaTG], [NmpTenTacGia]) VALUES (N'TG003     ', N'Nguyễn Du')
GO
ALTER TABLE [dbo].[NMP_SACH]  WITH CHECK ADD  CONSTRAINT [FK_NMP_SACH_NMP_TACGIA] FOREIGN KEY([Nmp_MaTG])
REFERENCES [dbo].[NMP_TACGIA] ([Nmp_MaTG])
GO
ALTER TABLE [dbo].[NMP_SACH] CHECK CONSTRAINT [FK_NMP_SACH_NMP_TACGIA]
GO
