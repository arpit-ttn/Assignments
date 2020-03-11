<Query Kind="Expression">
  <Connection>
    <ID>9b62a65f-b430-4045-a0e4-abfe6af4a0a7</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-FRDTOQH\SQLEXPRESS</Server>
    <Database>SQL_Exercise</Database>
  </Connection>
</Query>

// Question-10: Write LINQ to find 3rd highest Salary from the table.

(from e in Emps
orderby e.Salary descending 
select e).Skip(2).FirstOrDefault()