create table Sample_Program
(
Emp_id int ,
Name varchar(20),
age int ,
city varchar(20),
DOB Date,
)
insert into Sample_Program
values(101,'Arpit',22,'Noida','05-22-1998')
insert into Sample_Program
values(102,'Shagun',23,'Badarpur','04-12-1996')
insert into Sample_Program
values(103,'Azeem',24,'Delhi','01-15-1996')
insert into Sample_Program
values(104,'Sonal',19,'Faridabad','04-12-2001')
insert into Sample_Program
values(105,'Vishesh',18,'Ghaziabad','02-10-2002')
insert into Sample_Program
values(106,'Neha',25,'Delhi','09-04-1995')
insert into Sample_Program
values(107,'Vijay',26,'Delhi','1-10-1994')
insert into Sample_Program
values(108,'Abhishek',22,'Delhi','04-06-1998')

select * from Sample_Program

---------------Q-3. How data can be copied from one table to another table ?------------------------- 

Create table Sample_Program1
(
Emp_id int,
Name varchar(20),
age int ,
city varchar(20),
DOB date
)

insert into Sample_Program1
values(101,'Arpit',22,'Noida','05-22-1998')
insert into Sample_Program1
values(102,'Shagun',23,'Badarpur','04-12-1996')
insert into Sample_Program1
values(103,'Azeem',24,'Delhi','01-15-1996')
insert into Sample_Program1
values(104,'Sonal',19,'Faridabad','04-12-2001')
insert into Sample_Program1
values(105,'Vishesh',18,'Ghaziabad','02-10-2002')

---------------------------Command To copy data from one table to another table-------------------
select*into Sample_Program2 from Sample_Program1
--------------------------------------------------------------------------------------------------
select * from Sample_Program2
--------------------------------------------------------------------------------------------------

