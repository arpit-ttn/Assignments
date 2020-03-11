<Query Kind="Expression">
  <Connection>
    <ID>9b62a65f-b430-4045-a0e4-abfe6af4a0a7</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-FRDTOQH\SQLEXPRESS</Server>
    <Database>SQL_Exercise</Database>
  </Connection>
</Query>

// Question-8: Write LINQ to differentiate First and FirstOrDefault and display both the result.


(from s in Emps 
where s.Emp_id==1
select new{s.Emp_id,s.Emp_name,s.Mobile_No}).First()

Emps.First(t=>t.Emp_id==1)      //LAMBDA EXPRESSION

(from s in Emps 
where s.Emp_id==6
select new{s.Emp_id,s.Emp_name,s.Mobile_No}).FirstOrDefault()

Emps.FirstOrDefault(t=>t.Emp_id==6)    //LAMBDA EXPRESSION