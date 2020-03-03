
CREATE DATABASE [ASP.NET_Exercise]
GO

USE [ASP.NET_Exercise]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 3/3/2020 2:45:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Emp_Name] [varchar](20) NULL,
	[Emp_Age] [int] NULL,
	[Emp_Password] [varchar](20) NULL,
	[Emp_Email] [varchar](20) NULL,
	[Emp_Salary] [money] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Employee] ([Emp_Name], [Emp_Age], [Emp_Password], [Emp_Email], [Emp_Salary]) VALUES (N'Arpit', 22, N'ad', N'ad@gmail.com', 15100.0000)
GO
INSERT [dbo].[Employee] ([Emp_Name], [Emp_Age], [Emp_Password], [Emp_Email], [Emp_Salary]) VALUES (N'Azeem', 24, N'ma', N'ma@gmail.com', 15100.0000)
GO
INSERT [dbo].[Employee] ([Emp_Name], [Emp_Age], [Emp_Password], [Emp_Email], [Emp_Salary]) VALUES (N'Neha', 25, N'ng', N'ng@gmail.com', 14900.0000)
GO
INSERT [dbo].[Employee] ([Emp_Name], [Emp_Age], [Emp_Password], [Emp_Email], [Emp_Salary]) VALUES (N'Abhishek', 22, N'as', N'as@gmail.com', 13900.0000)
GO
INSERT [dbo].[Employee] ([Emp_Name], [Emp_Age], [Emp_Password], [Emp_Email], [Emp_Salary]) VALUES (N'Sonal', 21, N'sj', N'sj@gmail.com', 14000.0000)
GO
INSERT [dbo].[Employee] ([Emp_Name], [Emp_Age], [Emp_Password], [Emp_Email], [Emp_Salary]) VALUES (N'Vishesh', 22, N'vk', N'vk@gmail.com', 12500.0000)
GO
INSERT [dbo].[Employee] ([Emp_Name], [Emp_Age], [Emp_Password], [Emp_Email], [Emp_Salary]) VALUES (N'Punita', 24, N'py', N'py@gmail.com', 13500.0000)
GO
INSERT [dbo].[Employee] ([Emp_Name], [Emp_Age], [Emp_Password], [Emp_Email], [Emp_Salary]) VALUES (N'Shagun', 23, N'sg', N'sg@gmail.com', 14200.0000)
GO
INSERT [dbo].[Employee] ([Emp_Name], [Emp_Age], [Emp_Password], [Emp_Email], [Emp_Salary]) VALUES (N'Vijay', 26, N'vk', N'vk1@gmail.com', 15000.0000)
GO
INSERT [dbo].[Employee] ([Emp_Name], [Emp_Age], [Emp_Password], [Emp_Email], [Emp_Salary]) VALUES (N'Latika', 24, N'lm', N'lm@gmail.com', 14900.0000)
GO
