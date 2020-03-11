<Query Kind="Expression">
  <Connection>
    <ID>9b62a65f-b430-4045-a0e4-abfe6af4a0a7</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-FRDTOQH\SQLEXPRESS</Server>
    <Database>SQL_Exercise</Database>
  </Connection>
</Query>

// Question 7:  Write LINQ to perform the Grouping operation.

from t in Emps
group t by t.Emp_id 

Emps.GroupBy(t=>t.Emp_id)   // BY LAMBDA EXPRESSION

from t in Emp_Salaries
group t by t.Emp_id


Emp_Salaries.GroupBy(t=>t.Emp_id)    // BY LAMBDA EXPRESSION