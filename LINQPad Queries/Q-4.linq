<Query Kind="Expression">
  <Connection>
    <ID>9b62a65f-b430-4045-a0e4-abfe6af4a0a7</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-FRDTOQH\SQLEXPRESS</Server>
    <Database>SQL_Exercise</Database>
  </Connection>
</Query>

// Question 4: Write LINQ to get records using inner join and display columns from both tables.

from e in Emps 
join s in Emp_Salaries 
on e.Emp_id equals s.Emp_id 
select new { empid=e.Emp_id,empname=e.Emp_name,months=s.Months}