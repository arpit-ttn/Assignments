create database[Token]
GO
USE [Token]
GO
/****** Object:  Table [dbo].[Login_Details]    Script Date: 3/17/2020 9:23:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login_Details](
	[Username] [varchar](20) NOT NULL,
	[Userpassword] [varchar](20) NULL,
	[Roles] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Login_Details] ([Username], [Userpassword], [Roles]) VALUES (N'Arpit', N'arp', N'Admin')
GO

