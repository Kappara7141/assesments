CREATE DATABASE EmployeeDB1;
use EmployeeDB1;
CREATE TABLE Employee2
(EmpID int not null,
EmpName varchar(50) not null,SSN bigint not null,
salary float not null,DepID int not null);
select * from Employee2;
insert into Employee2 values(1,'jeffre',111111,1111111.00,1);
insert into Employee2 values(2,'mary',111111,5587.00,2);
insert into Employee2 values(3,'john',15462823,76538.00,1);
insert into Employee2 values(4,'micy',134561,8754111.00,3);
insert into Employee2 values(5,'nick',98456,567431.00,7);
select * from Employee2;
alter table Employee2 add DOB date;
select * from Employee2;
Update Employee2 SET DOB='03/01/2020';
select * from Employee2;
Alter Table Employee2
Add Constraint pk_EmpID PRIMARY KEY(EmpID);
Insert into Employee2 values(6,'mersey',54646,20000,4,'01/10/1990');
select * from Employee2;
Create Table Department
(DepID int PRIMARY KEY,
DepName varchar(30) not null);
Insert into Department values(1,'Admin');

Insert into Department values(2,'Marketing');

Insert into Department values(3,'Technical');

Insert into Department values(4,'Stores');
select * from Department;
Alter Table Department
Add Description varchar(100);
select * from Department;
Update Department SET Description='This is an admin department with higher activities' where DepID=1;
Update Department SET Description='This is an marketing department with higher activities' where DepID=2;
Update Department SET Description='This is an technical department with higher activities' where DepID=3;
Update Department SET Description='This is an stores department with higher activities' where DepID=4;
select * from Department;
select * from Employee2;
Alter Table Employee2
Add constraint chk_DOB CHECK(DOB BETWEEN '01/01/1990' and '12/31/2020');
select * from Employee2;
select * from Department where DepName='marketing' or DepName='technical';
select * from Employee2 where DepID=2 or DepID=3;
select * from Employee2;
Alter Table Employee2
Add constraint FK_DepID FOREIGN KEY (DepID) REFERENCES Department(DepID);
select MAX(salary) 'Max salary',MIN(salary)'Min salary' from Employee2;
select AVG(salary)'Avg salary' from Employee2;
select COUNT(EmpID)'Total Employees' from Employee2;
select SUM(salary)'Total salary' from Employee2;
select DepID,SUM(salary)'Total salary' from Employee2
Group By DepID
order By 'Total salary';
select * from Employee2;
select DepID,SUM(salary)'Total salary' from Employee2
Group By DepID
Having SUM(salary)>30000
order By 'Total salary';
select * from Employee2;
select e.EmpID,e.EmpName,e.salary,e.DepID,d.DepName from Employee2 e INNER JOIN
Department d ON e.DepID=d.DepID;
Insert into Employee2 values(10,'jims',23428,260000,4,null);
Insert into Employee2 values(8,'joeseph',23489,270000,4,null);

select e.EmpID,e.EmpName,e.salary,e.DepID,d.DepName from Employee2 e LEFT OUTER JOIN
Department d ON e.DepID=d.DepID;
select e.EmpID,e.EmpName,e.salary,e.DepID,d.DepName from Employee2 e RIGHT OUTER JOIN
Department d ON e.DepID=d.DepID;
select * from Department;
Update Department SET Description='This is an HR Department which finds human'where DepID=5;
select * from Employee2;
insert into Employee2 values(9,'cock',76584,280000,6,'1995/12/25');
insert into Employee2 values(10,'jimmy',58768,300000,7,'1997/10/27');
Drop table Employee2;
CREATE TABLE Employee4
(EmpID int not null,
EmpName varchar(50) not null,SSN bigint not null,
salary float not null,DepID int,DOB date);
select * from Employee4;
insert into Employee4 values(1,'jeffre',111111,1111111.00,1,'1998-1-1');
insert into Employee4 values(2,'mary',111111,5587.00,2,'1998-7-6');
insert into Employee4 values(3,'john',15462823,76538.00,1,'1999-12-14');
insert into Employee4 values(4,'micy',134561,8754111.00,3,'1999-11-17');
insert into Employee4 values(5,'nick',98456,567431.00,7,'1997-10-13');
insert into Employee4 values(6,'mickey',1756464,270000,null,'1995-9-18');
insert into Employee4 values(7,'rosy',7563983,670000,null,'1994-7-16');
select * from Employee4;
select Top 5 * from Employee4
select Top(2) with ties * from Employee4
Order by SSN;
select GetDate() 'Today''s Date';
select Day(GetDate())As 'Day',Month(GetDate())As 'Month',Year(GetDate())As 'Year';
select DATEDIFF(yy,DOB,GetDate()) as 'Age' from Employee4;
select EmpName as 'Full Name',SUBSTRING(EmpName,1,5) as 'PartName' from Employee4;
Declare @Greetings as varchar(50);
set @Greetings='Hello Good Morning All';
select SUBSTRING(@Greetings,1,10)'Hi all';
Declare @name as varchar(30);
set @name='     Anders Helsberg      ';
select LTrim(@name) as name;
select RTrim(@name) as name;
Declare @CompanyName as varchar(30);
set @CompanyName='cognizant technology solutions';
select Upper(@CompanyName) as uppercase,Lower(@CompanyName) as Lowercase;
select Reverse(EmpName) as 'Name Reversed' from Employee4;
select Top 3 left(EmpName,5) as 'part name from left' from Employee4;
select * from Employee4 where salary>(select AVG(salary) from Employee4);
 





