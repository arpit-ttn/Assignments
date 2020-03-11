<Query Kind="Expression">
  <Connection>
    <ID>9b62a65f-b430-4045-a0e4-abfe6af4a0a7</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-FRDTOQH\SQLEXPRESS</Server>
    <Database>SQL_Exercise</Database>
  </Connection>
</Query>

// Question 6:Write LINQ to perform aggregate function Count, Max, Min, Average on the table.

(from e in Emps
select e.Emp_name).Count()

(from e in Emps select e.Salary).Max()

Emps.Max(e=>e.Salary)   

(from e in Emps
select e.Salary).Min()

Emps.Min(e=>e.Salary)   

(from e in Emps
select e.Salary).Average()

Emps.Average(e=>e.Salary)