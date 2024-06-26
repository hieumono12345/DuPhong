USE [SimulationDevelopment]
GO
/****** Object:  Table [dbo].[DigitalMap]    Script Date: 11/03/2024 07:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DigitalMap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenBanDo] [nvarchar](255) NULL,
	[MoTa] [nvarchar](max) NULL,
	[FilePath] [varchar](100) NULL,
	[ToaDo] [varchar](50) NULL,
	[KichThuoc] [varchar](50) NULL,
	[FilePathImg] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[History]    Script Date: 11/03/2024 07:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[History](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDMap] [int] NULL,
	[IDNguoiLinh] [int] NULL,
	[IDTranChien] [int] NULL,
	[IDTrangThai] [int] NULL,
	[KinhDo] [float] NULL,
	[ViDo] [float] NULL,
	[ThoiDiem] [int] NULL,
	[IDTeam] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DigitalMap] ON 

INSERT [dbo].[DigitalMap] ([ID], [TenBanDo], [MoTa], [FilePath], [ToaDo], [KichThuoc], [FilePathImg]) VALUES (1, N'bản đồ 1', N'Mô tả 1', N'FilePath1', N'21.0278-105.8342', N'1000-2000', N'..\..\..\SimulationDevelopment\Img\PreviewMap\MTA2.jpg')
INSERT [dbo].[DigitalMap] ([ID], [TenBanDo], [MoTa], [FilePath], [ToaDo], [KichThuoc], [FilePathImg]) VALUES (2, N'bản đồ 2', N'Mô tả 2', N'FilePath2', N'Toa do 2', N'1000-2000', N'..\..\..\SimulationDevelopment\Img\PreviewMap\MTA1.jpg')
INSERT [dbo].[DigitalMap] ([ID], [TenBanDo], [MoTa], [FilePath], [ToaDo], [KichThuoc], [FilePathImg]) VALUES (3, N'bản đồ 3', N'Mô tả 3', N'FilePath3', N'Toa do 3', N'1000-2000', N'..\..\..\SimulationDevelopment\Img\PreviewMap\MTA3.jpg')
INSERT [dbo].[DigitalMap] ([ID], [TenBanDo], [MoTa], [FilePath], [ToaDo], [KichThuoc], [FilePathImg]) VALUES (4, N'bản đồ 4', N'Mô tả 4', N'FilePath4', N'Toa do 4', N'1000-3000', N'..\..\..\SimulationDevelopment\Img\PreviewMap\MTA2.jpg')
INSERT [dbo].[DigitalMap] ([ID], [TenBanDo], [MoTa], [FilePath], [ToaDo], [KichThuoc], [FilePathImg]) VALUES (5, N'bản đồ 5', N'Mô tả 5', N'FilePath5', N'Toa do 5', N'2000-3000', N'..\..\..\SimulationDevelopment\Img\PreviewMap\MTA1.jpg')
SET IDENTITY_INSERT [dbo].[DigitalMap] OFF
GO
SET IDENTITY_INSERT [dbo].[History] ON 

INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (1, 1, 1, 1, 1, 21.02781, 105.83421, 1, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (2, 1, 2, 1, 1, 21.02791, 105.83431, 1, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (3, 1, 3, 1, 1, 21.02881, 105.83441, 1, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (4, 1, 4, 1, 1, 21.02871, 105.83451, 1, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (5, 1, 1, 1, 1, 21.02782, 105.83422, 2, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (6, 1, 2, 1, 2, 21.02792, 105.83432, 2, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (7, 1, 3, 1, 2, 21.02882, 105.83442, 2, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (8, 1, 4, 1, 1, 21.02872, 105.83452, 2, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (9, 1, 1, 1, 2, 21.02783, 105.83423, 3, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (10, 1, 2, 1, 2, 21.02793, 105.83433, 3, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (11, 1, 3, 1, 2, 21.02883, 105.83443, 3, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (12, 1, 4, 1, 1, 21.02873, 105.83453, 3, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (13, 1, 1, 1, 2, 21.02784, 105.83424, 4, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (14, 1, 2, 1, 2, 21.02794, 105.83434, 4, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (15, 1, 3, 1, 2, 21.02884, 105.83444, 4, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (16, 1, 4, 1, 1, 21.02874, 105.83454, 4, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (17, 1, 1, 1, 2, 21.02785, 105.83423, 5, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (18, 1, 2, 1, 2, 21.02795, 105.83433, 5, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (19, 1, 3, 1, 2, 21.02885, 105.83443, 5, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (20, 1, 4, 1, 1, 21.02875, 105.83453, 5, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (21, 1, 1, 1, 2, 21.02786, 105.83424, 6, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (22, 1, 2, 1, 2, 21.02796, 105.83434, 6, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (23, 1, 3, 1, 2, 21.02886, 105.83444, 6, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (24, 1, 4, 1, 2, 21.02876, 105.83454, 6, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (25, 1, 1, 1, 2, 21.02781, 105.83421, 7, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (26, 1, 2, 1, 2, 21.02791, 105.83431, 7, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (27, 1, 3, 1, 2, 21.02881, 105.83441, 7, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (28, 1, 4, 1, 2, 21.02871, 105.83451, 7, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (29, 1, 1, 1, 2, 21.02782, 105.83422, 8, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (30, 1, 2, 1, 2, 21.02792, 105.83432, 8, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (31, 1, 3, 1, 2, 21.02882, 105.83442, 8, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (32, 1, 4, 1, 2, 21.02872, 105.83452, 8, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (33, 1, 1, 1, 2, 21.02783, 105.83423, 9, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (34, 1, 2, 1, 2, 21.02793, 105.83433, 9, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (35, 1, 3, 1, 2, 21.02883, 105.83443, 9, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (36, 1, 4, 1, 2, 21.02873, 105.83453, 9, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (37, 1, 1, 1, 2, 21.02784, 105.83424, 10, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (38, 1, 2, 1, 2, 21.02794, 105.83434, 10, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (39, 1, 3, 1, 2, 21.02884, 105.83444, 10, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (40, 1, 4, 1, 2, 21.02874, 105.83454, 10, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (41, 1, 1, 1, 2, 21.02785, 105.83423, 11, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (42, 1, 2, 1, 2, 21.02795, 105.83433, 11, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (43, 1, 3, 1, 2, 21.02885, 105.83443, 11, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (44, 1, 4, 1, 2, 21.02875, 105.83453, 11, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (45, 1, 1, 1, 2, 21.02786, 105.83424, 12, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (46, 1, 2, 1, 2, 21.02796, 105.83434, 12, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (47, 1, 3, 1, 2, 21.02886, 105.83444, 12, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (48, 1, 4, 1, 2, 21.02876, 105.83454, 12, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (49, 1, 1, 1, 2, 21.02785, 105.83423, 13, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (50, 1, 2, 1, 2, 21.02795, 105.83433, 13, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (51, 1, 3, 1, 2, 21.02885, 105.83443, 13, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (52, 1, 4, 1, 2, 21.02875, 105.83453, 13, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (53, 1, 1, 1, 2, 21.02781, 105.83421, 14, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (54, 1, 2, 1, 2, 21.02791, 105.83431, 14, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (55, 1, 3, 1, 2, 21.02881, 105.83441, 14, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (56, 1, 4, 1, 2, 21.02871, 105.83451, 14, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (57, 1, 1, 1, 2, 21.02782, 105.83422, 15, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (58, 1, 2, 1, 2, 21.02792, 105.83432, 15, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (59, 1, 3, 1, 2, 21.02882, 105.83442, 15, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (60, 1, 4, 1, 2, 21.02872, 105.83452, 15, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (61, 1, 1, 1, 2, 21.02783, 105.83423, 16, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (62, 1, 2, 1, 2, 21.02793, 105.83433, 16, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (63, 1, 3, 1, 2, 21.02883, 105.83443, 16, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (64, 1, 4, 1, 2, 21.02873, 105.83453, 16, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (65, 1, 1, 1, 2, 21.02784, 105.83424, 17, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (66, 1, 2, 1, 2, 21.02794, 105.83434, 17, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (67, 1, 3, 1, 2, 21.02884, 105.83444, 17, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (68, 1, 4, 1, 2, 21.02874, 105.83454, 17, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (69, 1, 1, 1, 2, 21.02785, 105.83423, 18, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (70, 1, 2, 1, 2, 21.02795, 105.83433, 18, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (71, 1, 3, 1, 2, 21.02885, 105.83443, 18, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (72, 1, 4, 1, 2, 21.02875, 105.83453, 18, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (73, 1, 1, 1, 3, 21.02786, 105.83424, 19, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (74, 1, 2, 1, 2, 21.02796, 105.83434, 19, 1)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (75, 1, 3, 1, 3, 21.02886, 105.83444, 19, 2)
INSERT [dbo].[History] ([ID], [IDMap], [IDNguoiLinh], [IDTranChien], [IDTrangThai], [KinhDo], [ViDo], [ThoiDiem], [IDTeam]) VALUES (77, 1, 4, 1, 3, 21.02876, 105.83454, 19, 2)
SET IDENTITY_INSERT [dbo].[History] OFF
GO
