create database [DB_Data]
GO
USE [DB_Data]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 3/21/2020 2:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Customer_Id] [int] NOT NULL,
	[FirstName] [varchar](20) NULL,
	[LastName] [varchar](20) NULL,
	[Address] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Customer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 3/21/2020 2:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Order_Id] [int] NOT NULL,
	[Customer_Id] [int] NOT NULL,
	[Product_Id] [int] NOT NULL,
	[Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Order_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 3/21/2020 2:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Product_Id] [int] NOT NULL,
	[Product_Name] [varchar](20) NULL,
	[MRP] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[Product_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Customer] ([Customer_Id], [FirstName], [LastName], [Address]) VALUES (1, N'Arpit', N'Deora', N'Noida')
GO
INSERT [dbo].[Customer] ([Customer_Id], [FirstName], [LastName], [Address]) VALUES (2, N'Sonal', N'Jha', N'Banaras')
GO
INSERT [dbo].[Customer] ([Customer_Id], [FirstName], [LastName], [Address]) VALUES (3, N'Neha', N'Goel', N'Delhi')
GO
INSERT [dbo].[Customer] ([Customer_Id], [FirstName], [LastName], [Address]) VALUES (4, N'Vishesh', N'Kapoor', N'Ghaziabad')
GO
INSERT [dbo].[Customer] ([Customer_Id], [FirstName], [LastName], [Address]) VALUES (5, N'Azeem', N'Faisal', N'Delhi')
GO
INSERT [dbo].[Orders] ([Order_Id], [Customer_Id], [Product_Id], [Quantity]) VALUES (1001, 2, 101, 4)
GO
INSERT [dbo].[Orders] ([Order_Id], [Customer_Id], [Product_Id], [Quantity]) VALUES (1002, 4, 103, 1)
GO
INSERT [dbo].[Orders] ([Order_Id], [Customer_Id], [Product_Id], [Quantity]) VALUES (1003, 1, 101, 2)
GO
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [MRP]) VALUES (101, N'Shampoo', 150.0000)
GO
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [MRP]) VALUES (102, N'Soap', 50.0000)
GO
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [MRP]) VALUES (103, N'Facewash', 85.0000)
GO
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [MRP]) VALUES (104, N'ToothPaste', 150.0000)
GO
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [MRP]) VALUES (105, N'Detergent', 75.0000)
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([Customer_Id])
REFERENCES [dbo].[Customer] ([Customer_Id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([Product_Id])
REFERENCES [dbo].[Products] ([Product_Id])
GO

