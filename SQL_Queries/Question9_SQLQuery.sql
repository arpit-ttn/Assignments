
-----------Q-9 Difference b/w having clause and where clause provide examples.----------------------

--------------------------Difference betweeen WHERE and hAVING clause------------------------------
--(1)WHERE clause cannot be used with aggregates whereas HAVING can.This means WHERE clause is used 
--for filtering individual rows whereas HAVING clause is used to filter groups.--------------------
--(2)WHERE comes before GROUPBY.This means WHERE clause filters rows before aggregate calculations 
--are performed.HAVING comes after GROUPBY.This means HAVING clause filters rows after aggregate 
--calculations are performed.

---------------------------------------------Where Clause-----------------------------------------
Select *from Emp
where Emp_Id =102

---------------------------------------------Having Clause----------------------------------------
Select avg(Salary) as Average_Salary,DOB from Emp
group by DOB
having avg(Salary)>25000

