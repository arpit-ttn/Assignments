<Query Kind="Expression">
  <Connection>
    <ID>9b62a65f-b430-4045-a0e4-abfe6af4a0a7</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-FRDTOQH\SQLEXPRESS</Server>
    <Database>SQL_Exercise</Database>
  </Connection>
</Query>

// Question 5: Write LINQ to get records using left join from two tables.

from s in Emps
join t in Emp_Salaries
on s.Emp_id equals t.Emp_id into stu
from t in stu.DefaultIfEmpty()
select new {Id=s.Emp_id, Name=s.Emp_name, Mobile_No =s.Mobile_No}