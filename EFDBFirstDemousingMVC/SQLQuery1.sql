create database Ef_DB_First_Demo
use Ef_DB_First_Demo
 
create table Employee
(
Empid int primary key identity(11,1),
Name varchar(50),
Gender varchar(50),
city varchar(50),
Salary bigint)


insert into Employee values ('Vishal','Male','prayagraj',45000)
insert into Employee values ('Manak','Male','Ghaziabhad',45000)
insert into Employee values ('Ashi','Female','Noida',45000)
insert into Employee values ('Ansh','Male','faridabad',45000)
insert into Employee values ('Ankit','Male','Lucknow',45000)
insert into Employee values ('Rakshit','Male','Mumbai',45000)
insert into Employee values ('saurabh','Male','Mumbai',45000)

select * from Employee

create table Department
(
Id int primary key identity,
Name Varchar(50)
)

insert into Department values('IT'),
('HR'),
('PayRoll')

select * from Department

alter table Employee add  DepartmentId int 
foreign key (DepartmentId) references Department(Id)