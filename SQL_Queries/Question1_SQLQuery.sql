------Q-1 Create a table (datatype should be appropriate for each column).Insert data into table,Update one table
------data using join with other table(you can create another table which takes the reference from the first table)

---------------------Table Creation-1-----------------------------
create table Emp
(
Emp_id int identity(100,1) primary key,
Emp_name varchar(20),
Mobile_No varchar(20) constraint tendigits check(Mobile_No like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
DOB date,
Emp_address varchar(20),
Salary money default null,
ZIP_code int check(len(ZIP_code)=6),
Is_Active bit,
Created_date datetime default GetDate(),
Modified_date datetime2
)
---------------------------inserting the values into Table 1-------------------------
insert into Emp(Emp_name,Mobile_No,DOB,Emp_address,Salary,ZIP_code,Is_Active)
values('Azeem','7588242609','1996-01-15','Delhi',NULL,201308,1)
insert into Emp(Emp_name,Mobile_No,DOB,Emp_address,Salary,ZIP_code,Is_Active)
values('Abhishek','9588252609','1998-10-04','Allahbad',NULL,246701,1)
insert into Emp(Emp_name,Mobile_No,DOB,Emp_address,Salary,ZIP_code,Is_Active)
values('Vishesh','7598242789','1998-08-22','Ghaziabad',NULL,210390,1)
insert into Emp(Emp_name,Mobile_No,DOB,Emp_address,Salary,ZIP_code,Is_Active)
values('Neha','7578642659','1995-03-7','Delhi',NULL,241301,1)
insert into Emp(Emp_name,Mobile_No,DOB,Emp_address,Salary,ZIP_code,Is_Active)
values('Vijay','8588252607','1994-07-24','Banaras',NULL,246308,1)
insert into Emp(Emp_name,Mobile_No,DOB,Emp_address,Salary,ZIP_code,Is_Active)
values('Shagun','8886242609','1997-04-20','Faridabad',NULL,193308,1)
insert into Emp(Emp_name,Mobile_No,DOB,Emp_address,Salary,ZIP_code,Is_Active)
values('Sonal','7590242609','1998-09-12','Aligarh',NULL,202398,1)
insert into Emp(Emp_name,Mobile_No,DOB,Emp_address,Salary,ZIP_code,Is_Active)
values('Punita','7562242609','1997-01-25','Haryana',NULL,201366,1)
insert into Emp(Emp_name,Mobile_No,DOB,Emp_address,Salary,ZIP_code,Is_Active)
values('Latika','7554242609','1996-07-05','Gurgaon',NULL,210310,1)

Select*from Emp

-------------------------------------Creation of Table-2--------------------------------
Create table Emp_Salaries
(
Emp_id int foreign key(Emp_id) references Emp (Emp_id),
Months varchar(20), 
Salary money
)
-----------------------------------insertion in table-2-------------------------------------------
insert into Emp_Salaries
values(100,'January',15000)
insert into Emp_Salaries
values(100,'February',12700)
insert into Emp_Salaries
values(100,'March',14300)


insert into Emp_Salaries
values(101,'January',15100)
insert into Emp_Salaries
values(101,'February',13000)
insert into Emp_Salaries
values(101,'March',12300)

insert into Emp_Salaries
values(102,'January',14000)
insert into Emp_Salaries
values(102,'February',15100)
insert into Emp_Salaries
values(102,'March',13900)

insert into Emp_Salaries
values(103,'January',12700)
insert into Emp_Salaries
values(103,'February',14300)
insert into Emp_Salaries
values(103,'March',14300)

insert into Emp_Salaries
values(104,'January',13200)
insert into Emp_Salaries
values(104,'February',14800)
insert into Emp_Salaries
values(104,'March',15100)

insert into Emp_Salaries
values(105,'January',13400)
insert into Emp_Salaries
values(105,'February',12500)
insert into Emp_Salaries
values(105,'March',14300)

insert into Emp_Salaries
values(106,'January',15100)
insert into Emp_Salaries
values(106,'February',14000)
insert into Emp_Salaries
values(106,'March',14100)

insert into Emp_Salaries
values(107,'January',14000)
insert into Emp_Salaries
values(107,'February',15200)
insert into Emp_Salaries
values(107,'March',12900)

insert into Emp_Salaries
values(108,'January',12600)
insert into Emp_Salaries
values(108,'February',12500)
insert into Emp_Salaries
values(108,'March',14300)

insert into Emp_Salaries
values(109,'January',14300)
insert into Emp_Salaries
values(109,'February',13700)
insert into Emp_Salaries
values(109,'March',12100)

Select*from Emp_Salaries

-------------------------------Update one table data using join with other table---------------------
----------------------------------------we have used subquery here----------------------------------
UPDATE Emp 
SET Emp.Salary = Emp_Salaries.Salary
FROM Emp 
INNER JOIN (select Emp_id, sum(Salary) as Salaries
   from Emp_Salaries
  group by Emp_id) as Emp_Salaries
on Emp.Emp_id = Emp_Salaries.Emp_id
--------------------------------------------------------------------------------------------------