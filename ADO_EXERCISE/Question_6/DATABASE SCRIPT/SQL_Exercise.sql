CREATE DATABASE [SQL_Exercise]
GO

USE [SQL_Exercise]
GO
/****** Object:  UserDefinedFunction [dbo].[udf_Function_S]    Script Date: 3/4/2020 1:05:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[udf_Function_S] (@age int)
returns varchar(20)
as
begin
    return(select Name from Sample_Program where age=@age)
end
GO
/****** Object:  UserDefinedFunction [dbo].[udf_Function1]    Script Date: 3/4/2020 1:05:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[udf_Function1] (@city varchar)
returns varchar(20)
as
begin
    return (select name from Sample_Program where city=@city)
end
GO
/****** Object:  Table [dbo].[Sample_Program]    Script Date: 3/4/2020 1:05:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sample_Program](
	[Emp_id] [int] NULL,
	[Name] [varchar](20) NULL,
	[age] [int] NULL,
	[city] [varchar](20) NULL,
	[DOB] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Sample_View]    Script Date: 3/4/2020 1:05:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Sample_View] as
select name
from sample_program
GO
/****** Object:  UserDefinedFunction [dbo].[Function3]    Script Date: 3/4/2020 1:05:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create function [dbo].[Function3](@age int)
returns table
as
return (Select Name,city from Sample_Program where age=@age )
GO
/****** Object:  UserDefinedFunction [dbo].[Function2]    Script Date: 3/4/2020 1:05:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[Function2](@city varchar)
returns table
as
return (Select Name,age,DOB from Sample_Program where city=@city )
GO
/****** Object:  UserDefinedFunction [dbo].[Function_Example]    Script Date: 3/4/2020 1:05:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[Function_Example](@age int)
returns table
as
return (Select*from Sample_Program where age=@age )
GO
/****** Object:  UserDefinedFunction [dbo].[Function_Sample]    Script Date: 3/4/2020 1:05:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[Function_Sample](@age int)
returns table
as
return (Select Name,city,DOB from Sample_Program where age=@age )
GO
/****** Object:  Table [dbo].[Emp]    Script Date: 3/4/2020 1:05:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emp](
	[Emp_id] [int] IDENTITY(100,1) NOT NULL,
	[Emp_name] [varchar](20) NULL,
	[Mobile_No] [varchar](20) NULL,
	[DOB] [date] NULL,
	[Emp_address] [varchar](20) NULL,
	[Salary] [money] NULL,
	[ZIP_code] [int] NULL,
	[Is_Active] [bit] NULL,
	[Created_date] [datetime] NULL,
	[Modified_date] [datetime2](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Emp_Salaries]    Script Date: 3/4/2020 1:05:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emp_Salaries](
	[Emp_id] [int] NULL,
	[Months] [varchar](20) NULL,
	[Salaries] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Emp_Salary]    Script Date: 3/4/2020 1:05:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emp_Salary](
	[Emp_ID] [int] NULL,
	[Salaries] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 3/4/2020 1:05:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Emp_ID] [int] IDENTITY(100,1) NOT NULL,
	[Salary] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[Emp_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees_Salary]    Script Date: 3/4/2020 1:05:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees_Salary](
	[Emp_ID] [int] NULL,
	[Salary] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sample_Program1]    Script Date: 3/4/2020 1:05:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sample_Program1](
	[Emp_id] [int] NULL,
	[Name] [varchar](20) NULL,
	[age] [int] NULL,
	[city] [varchar](20) NULL,
	[DOB] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sample_Program2]    Script Date: 3/4/2020 1:05:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sample_Program2](
	[Emp_id] [int] NULL,
	[Name] [varchar](20) NULL,
	[age] [int] NULL,
	[city] [varchar](20) NULL,
	[DOB] [date] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Emp] ON 
GO
INSERT [dbo].[Emp] ([Emp_id], [Emp_name], [Mobile_No], [DOB], [Emp_address], [Salary], [ZIP_code], [Is_Active], [Created_date], [Modified_date]) VALUES (100, N'Arpit', N'7599242609', CAST(N'1998-01-22' AS Date), N'NOIDA', 42000.0000, 201301, 1, CAST(N'2020-02-26T18:52:16.230' AS DateTime), NULL)
GO
INSERT [dbo].[Emp] ([Emp_id], [Emp_name], [Mobile_No], [DOB], [Emp_address], [Salary], [ZIP_code], [Is_Active], [Created_date], [Modified_date]) VALUES (101, N'Azeem', N'7588242609', CAST(N'1996-01-15' AS Date), N'Delhi', 40400.0000, 201308, 1, CAST(N'2020-02-26T20:15:31.640' AS DateTime), NULL)
GO
INSERT [dbo].[Emp] ([Emp_id], [Emp_name], [Mobile_No], [DOB], [Emp_address], [Salary], [ZIP_code], [Is_Active], [Created_date], [Modified_date]) VALUES (102, N'Abhishek', N'9588252609', CAST(N'1998-10-04' AS Date), N'Allahbad', 43000.0000, 246701, 1, CAST(N'2020-02-26T22:55:58.467' AS DateTime), NULL)
GO
INSERT [dbo].[Emp] ([Emp_id], [Emp_name], [Mobile_No], [DOB], [Emp_address], [Salary], [ZIP_code], [Is_Active], [Created_date], [Modified_date]) VALUES (103, N'Vishesh', N'7598242789', CAST(N'1998-08-22' AS Date), N'Ghaziabad', 41300.0000, 210390, 1, CAST(N'2020-02-26T22:55:58.473' AS DateTime), NULL)
GO
INSERT [dbo].[Emp] ([Emp_id], [Emp_name], [Mobile_No], [DOB], [Emp_address], [Salary], [ZIP_code], [Is_Active], [Created_date], [Modified_date]) VALUES (104, N'Neha', N'7578642659', CAST(N'1995-03-07' AS Date), N'Delhi', 43100.0000, 241301, 1, CAST(N'2020-02-26T22:55:58.477' AS DateTime), NULL)
GO
INSERT [dbo].[Emp] ([Emp_id], [Emp_name], [Mobile_No], [DOB], [Emp_address], [Salary], [ZIP_code], [Is_Active], [Created_date], [Modified_date]) VALUES (105, N'Vijay', N'8588252607', CAST(N'1994-07-24' AS Date), N'Banaras', 40200.0000, 246308, 1, CAST(N'2020-02-26T22:55:58.480' AS DateTime), NULL)
GO
INSERT [dbo].[Emp] ([Emp_id], [Emp_name], [Mobile_No], [DOB], [Emp_address], [Salary], [ZIP_code], [Is_Active], [Created_date], [Modified_date]) VALUES (106, N'Shagun', N'8886242609', CAST(N'1997-04-20' AS Date), N'Faridabad', 44900.0000, 193308, 1, CAST(N'2020-02-26T22:55:58.480' AS DateTime), NULL)
GO
INSERT [dbo].[Emp] ([Emp_id], [Emp_name], [Mobile_No], [DOB], [Emp_address], [Salary], [ZIP_code], [Is_Active], [Created_date], [Modified_date]) VALUES (107, N'Sonal', N'7590242609', CAST(N'1998-09-12' AS Date), N'Aligarh', 42100.0000, 202398, 1, CAST(N'2020-02-26T22:55:58.480' AS DateTime), NULL)
GO
INSERT [dbo].[Emp] ([Emp_id], [Emp_name], [Mobile_No], [DOB], [Emp_address], [Salary], [ZIP_code], [Is_Active], [Created_date], [Modified_date]) VALUES (108, N'Punita', N'7562242609', CAST(N'1997-01-25' AS Date), N'Haryana', 41100.0000, 201366, 1, CAST(N'2020-02-26T22:55:58.483' AS DateTime), NULL)
GO
INSERT [dbo].[Emp] ([Emp_id], [Emp_name], [Mobile_No], [DOB], [Emp_address], [Salary], [ZIP_code], [Is_Active], [Created_date], [Modified_date]) VALUES (109, N'Latika', N'7554242609', CAST(N'1996-07-05' AS Date), N'Gurgaon', 40100.0000, 210310, 1, CAST(N'2020-02-26T22:55:58.483' AS DateTime), NULL)
GO
SET IDENTITY_INSERT [dbo].[Emp] OFF
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (100, N'January', 15000.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (100, N'February', 12700.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (100, N'March', 14300.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (101, N'January', 15100.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (101, N'February', 13000.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (101, N'March', 12300.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (102, N'January', 14000.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (102, N'February', 15100.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (102, N'March', 13900.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (103, N'January', 12700.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (103, N'February', 14300.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (103, N'March', 14300.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (104, N'January', 13200.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (104, N'February', 14800.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (104, N'March', 15100.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (105, N'January', 13400.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (105, N'February', 12500.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (105, N'March', 14300.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (106, N'January', 15100.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (106, N'February', 14000.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (106, N'March', 14100.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (107, N'January', 14000.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (107, N'February', 15200.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (107, N'March', 12900.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (108, N'January', 12600.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (108, N'February', 12500.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (108, N'March', 14300.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (109, N'January', 14300.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (109, N'February', 13700.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (109, N'March', 12100.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (100, N'', 0.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (100, N'', 0.0000)
GO
INSERT [dbo].[Emp_Salaries] ([Emp_id], [Months], [Salaries]) VALUES (101, N'January', 15100.0000)
GO
INSERT [dbo].[Emp_Salary] ([Emp_ID], [Salaries]) VALUES (100, 1000.0000)
GO
INSERT [dbo].[Emp_Salary] ([Emp_ID], [Salaries]) VALUES (100, 2000.0000)
GO
INSERT [dbo].[Emp_Salary] ([Emp_ID], [Salaries]) VALUES (101, 2000.0000)
GO
INSERT [dbo].[Emp_Salary] ([Emp_ID], [Salaries]) VALUES (101, 2000.0000)
GO
INSERT [dbo].[Emp_Salary] ([Emp_ID], [Salaries]) VALUES (102, 3000.0000)
GO
INSERT [dbo].[Emp_Salary] ([Emp_ID], [Salaries]) VALUES (102, 3000.0000)
GO
INSERT [dbo].[Emp_Salary] ([Emp_ID], [Salaries]) VALUES (102, 3000.0000)
GO
INSERT [dbo].[Emp_Salary] ([Emp_ID], [Salaries]) VALUES (100, NULL)
GO
INSERT [dbo].[Emp_Salary] ([Emp_ID], [Salaries]) VALUES (101, NULL)
GO
INSERT [dbo].[Emp_Salary] ([Emp_ID], [Salaries]) VALUES (102, NULL)
GO
INSERT [dbo].[Emp_Salary] ([Emp_ID], [Salaries]) VALUES (103, 1000.0000)
GO
INSERT [dbo].[Emp_Salary] ([Emp_ID], [Salaries]) VALUES (104, 2000.0000)
GO
INSERT [dbo].[Emp_Salary] ([Emp_ID], [Salaries]) VALUES (105, 2000.0000)
GO
INSERT [dbo].[Emp_Salary] ([Emp_ID], [Salaries]) VALUES (106, 2000.0000)
GO
INSERT [dbo].[Emp_Salary] ([Emp_ID], [Salaries]) VALUES (107, 3000.0000)
GO
INSERT [dbo].[Emp_Salary] ([Emp_ID], [Salaries]) VALUES (108, 3000.0000)
GO
INSERT [dbo].[Emp_Salary] ([Emp_ID], [Salaries]) VALUES (109, 3000.0000)
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 
GO
INSERT [dbo].[Employees] ([Emp_ID], [Salary]) VALUES (100, NULL)
GO
INSERT [dbo].[Employees] ([Emp_ID], [Salary]) VALUES (101, NULL)
GO
INSERT [dbo].[Employees] ([Emp_ID], [Salary]) VALUES (102, NULL)
GO
INSERT [dbo].[Employees] ([Emp_ID], [Salary]) VALUES (103, 1000.0000)
GO
INSERT [dbo].[Employees] ([Emp_ID], [Salary]) VALUES (104, 2000.0000)
GO
INSERT [dbo].[Employees] ([Emp_ID], [Salary]) VALUES (105, 2000.0000)
GO
INSERT [dbo].[Employees] ([Emp_ID], [Salary]) VALUES (106, 2000.0000)
GO
INSERT [dbo].[Employees] ([Emp_ID], [Salary]) VALUES (107, 3000.0000)
GO
INSERT [dbo].[Employees] ([Emp_ID], [Salary]) VALUES (108, 3000.0000)
GO
INSERT [dbo].[Employees] ([Emp_ID], [Salary]) VALUES (109, 3000.0000)
GO
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
INSERT [dbo].[Employees_Salary] ([Emp_ID], [Salary]) VALUES (100, 1000.0000)
GO
INSERT [dbo].[Employees_Salary] ([Emp_ID], [Salary]) VALUES (100, 2000.0000)
GO
INSERT [dbo].[Employees_Salary] ([Emp_ID], [Salary]) VALUES (101, 2000.0000)
GO
INSERT [dbo].[Employees_Salary] ([Emp_ID], [Salary]) VALUES (101, 2000.0000)
GO
INSERT [dbo].[Employees_Salary] ([Emp_ID], [Salary]) VALUES (102, 3000.0000)
GO
INSERT [dbo].[Employees_Salary] ([Emp_ID], [Salary]) VALUES (102, 3000.0000)
GO
INSERT [dbo].[Employees_Salary] ([Emp_ID], [Salary]) VALUES (102, 3000.0000)
GO
INSERT [dbo].[Sample_Program] ([Emp_id], [Name], [age], [city], [DOB]) VALUES (101, N'Arpit', 21, N'Noida', CAST(N'1998-05-22' AS Date))
GO
INSERT [dbo].[Sample_Program] ([Emp_id], [Name], [age], [city], [DOB]) VALUES (102, N'Shagun', 23, N'Badarpur', CAST(N'1996-04-12' AS Date))
GO
INSERT [dbo].[Sample_Program] ([Emp_id], [Name], [age], [city], [DOB]) VALUES (103, N'Azeem', 24, N'Delhi', CAST(N'1996-01-15' AS Date))
GO
INSERT [dbo].[Sample_Program] ([Emp_id], [Name], [age], [city], [DOB]) VALUES (104, N'Sonal', 19, N'Faridabad', CAST(N'2001-04-12' AS Date))
GO
INSERT [dbo].[Sample_Program] ([Emp_id], [Name], [age], [city], [DOB]) VALUES (105, N'Vishesh', 18, N'Ghaziabad', CAST(N'2002-02-10' AS Date))
GO
INSERT [dbo].[Sample_Program] ([Emp_id], [Name], [age], [city], [DOB]) VALUES (106, N'Neha', 25, N'Delhi', CAST(N'1995-09-04' AS Date))
GO
INSERT [dbo].[Sample_Program] ([Emp_id], [Name], [age], [city], [DOB]) VALUES (107, N'Vijay', 26, N'Delhi', CAST(N'1994-01-10' AS Date))
GO
INSERT [dbo].[Sample_Program] ([Emp_id], [Name], [age], [city], [DOB]) VALUES (108, N'Arpit', 22, N'Delhi', CAST(N'1998-04-06' AS Date))
GO
INSERT [dbo].[Sample_Program1] ([Emp_id], [Name], [age], [city], [DOB]) VALUES (101, N'Arpit', 22, N'Noida', CAST(N'1998-05-22' AS Date))
GO
INSERT [dbo].[Sample_Program1] ([Emp_id], [Name], [age], [city], [DOB]) VALUES (102, N'Shagun', 23, N'Badarpur', CAST(N'1996-04-12' AS Date))
GO
INSERT [dbo].[Sample_Program1] ([Emp_id], [Name], [age], [city], [DOB]) VALUES (103, N'Azeem', 24, N'Delhi', CAST(N'1996-01-15' AS Date))
GO
INSERT [dbo].[Sample_Program1] ([Emp_id], [Name], [age], [city], [DOB]) VALUES (104, N'Sonal', 19, N'Faridabad', CAST(N'2001-04-12' AS Date))
GO
INSERT [dbo].[Sample_Program1] ([Emp_id], [Name], [age], [city], [DOB]) VALUES (105, N'Vishesh', 18, N'Ghaziabad', CAST(N'2002-02-10' AS Date))
GO
INSERT [dbo].[Sample_Program2] ([Emp_id], [Name], [age], [city], [DOB]) VALUES (101, N'Arpit', 22, N'Noida', CAST(N'1998-05-22' AS Date))
GO
INSERT [dbo].[Sample_Program2] ([Emp_id], [Name], [age], [city], [DOB]) VALUES (102, N'Shagun', 23, N'Badarpur', CAST(N'1996-04-12' AS Date))
GO
INSERT [dbo].[Sample_Program2] ([Emp_id], [Name], [age], [city], [DOB]) VALUES (103, N'Azeem', 24, N'Delhi', CAST(N'1996-01-15' AS Date))
GO
INSERT [dbo].[Sample_Program2] ([Emp_id], [Name], [age], [city], [DOB]) VALUES (104, N'Sonal', 19, N'Faridabad', CAST(N'2001-04-12' AS Date))
GO
INSERT [dbo].[Sample_Program2] ([Emp_id], [Name], [age], [city], [DOB]) VALUES (105, N'Vishesh', 18, N'Ghaziabad', CAST(N'2002-02-10' AS Date))
GO
ALTER TABLE [dbo].[Emp] ADD  DEFAULT (NULL) FOR [Salary]
GO
ALTER TABLE [dbo].[Emp] ADD  DEFAULT (getdate()) FOR [Created_date]
GO
ALTER TABLE [dbo].[Emp_Salaries]  WITH CHECK ADD FOREIGN KEY([Emp_id])
REFERENCES [dbo].[Emp] ([Emp_id])
GO
ALTER TABLE [dbo].[Emp_Salary]  WITH CHECK ADD FOREIGN KEY([Emp_ID])
REFERENCES [dbo].[Employees] ([Emp_ID])
GO
ALTER TABLE [dbo].[Employees_Salary]  WITH CHECK ADD FOREIGN KEY([Emp_ID])
REFERENCES [dbo].[Employees] ([Emp_ID])
GO
ALTER TABLE [dbo].[Emp]  WITH CHECK ADD CHECK  ((len([ZIP_code])=(6)))
GO
ALTER TABLE [dbo].[Emp]  WITH CHECK ADD  CONSTRAINT [tendigits] CHECK  (([Mobile_No] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Emp] CHECK CONSTRAINT [tendigits]
GO
/****** Object:  StoredProcedure [dbo].[Call_Procedure]    Script Date: 3/4/2020 1:05:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Call_Procedure]
(
@E_name varchar(20),
@E_age int 
)
as 
begin
exec Procedure_Sample_Program @Name=@E_name,@age=@E_age
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_1]    Script Date: 3/4/2020 1:05:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_1]
@name varchar(20)
as 
begin
Select*from Emp where  Mobile_No like @name +'%'
end
GO
/****** Object:  StoredProcedure [dbo].[Procedure_1]    Script Date: 3/4/2020 1:05:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Procedure_1]
as 
begin
update Sample_Program 
set age=21
where Emp_id='101'
end 
GO
/****** Object:  StoredProcedure [dbo].[Procedure_Sample_Program]    Script Date: 3/4/2020 1:05:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Procedure_Sample_Program]
(
@Name varchar(20),
@age int
)
as 
begin
update Sample_Program set name=@Name where age=@age
end
GO
