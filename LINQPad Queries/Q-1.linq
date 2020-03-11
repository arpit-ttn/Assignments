<Query Kind="Expression">
  <Connection>
    <ID>9b62a65f-b430-4045-a0e4-abfe6af4a0a7</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-FRDTOQH\SQLEXPRESS</Server>
    <Database>SQL_Exercise</Database>
  </Connection>
</Query>

//Question-1: Write LINQ syntax and define each term of the syntax.

//1)Query Syntax
from e in Emps
where e.Emp_id==100
select e

//2)Method Syntax
Emps.Where(x=>x.Emp_id==100).ToList()

//3)Mixed Syntax
(from e in Emps
select e).Skip(4)