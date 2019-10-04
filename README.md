# EF_ToList
EntityFramework Examples

# 1.ToList():
The ToList() method is usedto select all columns and all rows of the table. It Executes Query and returns data as a "collection of model class".
# Syntax:

CompanyDBContext db = new CompanyDBContext();
List<Employee> emps = db.Employees.ToList();
