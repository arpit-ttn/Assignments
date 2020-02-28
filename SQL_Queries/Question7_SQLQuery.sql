--------------Q-7 Give examples of self,Inner,left outer,right outer joins.-------------------------

--------------Example of Inner Join-----------------------------------------
select*from Sample_Program inner join Sample_Program2 on Sample_Program.Emp_id=Sample_Program2.Emp_id
--------------Example of Left Join------------------------------------------
select*from Sample_Program left join Sample_Program2 on Sample_Program.Emp_id=Sample_Program2.Emp_id
--------------Example of Right Join-----------------------------------------
select*from Sample_Program right join Sample_Program2 on Sample_Program.Emp_id=Sample_Program2.Emp_id
--------------Example of Self Join-----------------------------------------
select*from Sample_Program as a join Sample_Program as b on a.Emp_id=b.Emp_id