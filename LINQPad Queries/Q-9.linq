<Query Kind="Expression">
  <Connection>
    <ID>9b62a65f-b430-4045-a0e4-abfe6af4a0a7</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-FRDTOQH\SQLEXPRESS</Server>
    <Database>SQL_Exercise</Database>
  </Connection>
</Query>

// Question-9: Write LINQ to define DefaultIfEmpty().

(from s in Emps 
where s.Emp_id==106
select new{s.Emp_id,s.Emp_name,s.Emp_address}).DefaultIfEmpty().First()