------------------------Q-5. How to create and invoke user defined functions ?------------------

--------------------------------- create function scalar-valued udf-----------------------------
create function dbo.udf_Function_S (@age int)
returns varchar(20)
as
begin
    return(select Name from Sample_Program where age=@age)
end

select* from Sample_Program
---------------------------------invoking a udf------------------------------------------
print dbo.udf_Function_S(24)

---------------------------------------Table Valued udf------------------------------------------

create function Function3(@age int)
returns table
as
return (Select Name,city,DOB from Sample_Program where age=@age )
---------------------------------------invoking a table valued udf---------------------------------
select * from Function3(22)

