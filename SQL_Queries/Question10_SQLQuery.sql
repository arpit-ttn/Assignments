----------Q-10 Difference between stored procedures and user defined functions. Explain with suitable examples.------

-----------------------------Difference Between Stored Procedure and Function--------------------------------
------Stored Procedure allows SELECT as well as DML statements and can return ZERO or N values 
------whereas Function allows SELECT statement and must return one value
------Functions can be called from Stored Procedures whereas Stored procedures cannot be called from functions
-------------------------------Stored Procedure------------------------------
create proc Procedure_1
as 
begin
update Sample_Program 
set age=21
where Emp_id='101'
end 

---------------------------------Function--------------------------------------
create function Function_Sample(@age int)
returns table
as
return (Select Name,city,DOB from Sample_Program where age=@age )

select * from Function_Sample(22)
