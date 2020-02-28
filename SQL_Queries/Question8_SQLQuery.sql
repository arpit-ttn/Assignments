
-----------------Q-8 Create and invoke one stored procedure from another stored procedure.------

------------------------------------------creating 1st Proc--------------------------
create proc Procedure_Sample_Program
(
@Name varchar(20),
@age int
)
as 
begin
update Sample_Program set name=@Name where age=@age
end            
-------------------------------------------creating 2nd proc----------------------------

create proc Call_Procedure
(
@E_name varchar(20),
@E_age int 
)
as 
begin
exec Procedure_Sample_Program @Name=@E_name,@age=@E_age
end

----------------------------------------------Executing 2nd Proc where 1st proc is called------
exec Call_Procedure @E_name='Arpit',@E_age=22

Select*from Sample_Program


