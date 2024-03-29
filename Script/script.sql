USE [Sub-Task]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 18.07.2022 16:18:40 ******/
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
/****** Object:  Table [dbo].[Lists]    Script Date: 18.07.2022 16:18:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lists](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Lists] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tasks]    Script Date: 18.07.2022 16:18:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tasks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ParentId] [int] NULL,
	[ListId] [int] NOT NULL,
	[Text] [ntext] NULL,
	[IsCompleted] [bit] NOT NULL,
 CONSTRAINT [PK_Tasks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220715213539_initial', N'3.1.27')
GO
SET IDENTITY_INSERT [dbo].[Lists] ON 

INSERT [dbo].[Lists] ([Id], [Name]) VALUES (1, N'Alışveriş')
INSERT [dbo].[Lists] ([Id], [Name]) VALUES (2, N'İş')
INSERT [dbo].[Lists] ([Id], [Name]) VALUES (3, N'Okul')
SET IDENTITY_INSERT [dbo].[Lists] OFF
GO
SET IDENTITY_INSERT [dbo].[Tasks] ON 

INSERT [dbo].[Tasks] ([Id], [ParentId], [ListId], [Text], [IsCompleted]) VALUES (1, NULL, 1, N'sabah yemek listesi', 0)
INSERT [dbo].[Tasks] ([Id], [ParentId], [ListId], [Text], [IsCompleted]) VALUES (2, 1, 1, N'Peynir', 0)
INSERT [dbo].[Tasks] ([Id], [ParentId], [ListId], [Text], [IsCompleted]) VALUES (28, 1, 1, N'Yumurta', 1)
INSERT [dbo].[Tasks] ([Id], [ParentId], [ListId], [Text], [IsCompleted]) VALUES (29, 1, 1, N'Zeytin', 0)
INSERT [dbo].[Tasks] ([Id], [ParentId], [ListId], [Text], [IsCompleted]) VALUES (30, 1, 1, N'Tereyağ', 1)
INSERT [dbo].[Tasks] ([Id], [ParentId], [ListId], [Text], [IsCompleted]) VALUES (32, NULL, 3, N'Sınava Hazırlık', 0)
INSERT [dbo].[Tasks] ([Id], [ParentId], [ListId], [Text], [IsCompleted]) VALUES (33, 32, 3, N'Dersler izlenecek', 0)
INSERT [dbo].[Tasks] ([Id], [ParentId], [ListId], [Text], [IsCompleted]) VALUES (34, 32, 3, N'Ödevler Yapılacak', 0)
INSERT [dbo].[Tasks] ([Id], [ParentId], [ListId], [Text], [IsCompleted]) VALUES (35, NULL, 2, N'Yeni Aldığım Proje', 0)
INSERT [dbo].[Tasks] ([Id], [ParentId], [ListId], [Text], [IsCompleted]) VALUES (36, 35, 2, N'veri tabanı tasarlanacak', 0)
INSERT [dbo].[Tasks] ([Id], [ParentId], [ListId], [Text], [IsCompleted]) VALUES (37, 35, 2, N'Kurgu düşün', 0)
INSERT [dbo].[Tasks] ([Id], [ParentId], [ListId], [Text], [IsCompleted]) VALUES (38, 35, 2, N'Yapı oluşturma', 0)
SET IDENTITY_INSERT [dbo].[Tasks] OFF
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tasks_Lists_ListId] FOREIGN KEY([ListId])
REFERENCES [dbo].[Lists] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_Tasks_Lists_ListId]
GO
