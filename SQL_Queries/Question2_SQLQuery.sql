-----------------------------Q-2 How to update column name of table ?-----------------------------

sp_rename 'Emp_Salaries.Salary', 'Salaries', 'COLUMN';
Select*from Emp_Salaries