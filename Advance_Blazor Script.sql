Create database [Student]
GO
USE [Student]
GO
/****** Object:  Table [dbo].[sidebar]    Script Date: 4/19/2020 10:17:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sidebar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LinkName] [varchar](20) NULL,
	[LinkAddress] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student]    Script Date: 4/19/2020 10:17:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [varchar](20) NULL,
	[StudentCourse] [varchar](20) NULL,
	[StudentAddress] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_Details]    Script Date: 4/19/2020 10:17:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Details](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](20) NULL,
	[Password] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[sidebar] ON 
GO
INSERT [dbo].[sidebar] ([Id], [LinkName], [LinkAddress]) VALUES (3, N'counter', N'counter')
GO
INSERT [dbo].[sidebar] ([Id], [LinkName], [LinkAddress]) VALUES (4, N'Student', N'Student')
GO
SET IDENTITY_INSERT [dbo].[sidebar] OFF
GO
SET IDENTITY_INSERT [dbo].[student] ON 
GO
INSERT [dbo].[student] ([StudentId], [StudentName], [StudentCourse], [StudentAddress]) VALUES (1, N'Arpit', N'commerce', N'Noida')
GO
INSERT [dbo].[student] ([StudentId], [StudentName], [StudentCourse], [StudentAddress]) VALUES (2, N'Neha', N'Science', N'Delhi')
GO
SET IDENTITY_INSERT [dbo].[student] OFF
GO
SET IDENTITY_INSERT [dbo].[User_Details] ON 
GO
INSERT [dbo].[User_Details] ([Id], [UserName], [Password]) VALUES (1, N'Arpit', N'12345')
GO
SET IDENTITY_INSERT [dbo].[User_Details] OFF
GO

