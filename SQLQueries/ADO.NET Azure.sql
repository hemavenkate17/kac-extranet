use KGC_DevNew

create table Students(
ID int identity(1,1) ,
Name Varchar(20) not null,
Age int not null,
Address Varchar(25),
PhoneNumber varchar(10)
Constraint PK_ID Primary key (ID)
);

insert into Students values('Hema',21,'No.6 Anna Nagar,chennai','9940239001','2001-08-17')
insert into Students values('Ram',20,'No.62 JK Nagar,chennai','1234567890')
insert into Students values('Vino',22,'No.3 Gandhi Nagar,chennai','9940298348')
insert into Students values('Deep',22,'No.4 Valmiki st,chennai','9123123101')
insert into Students values('chiko',23,'No.6 abimanyu st,chennai','9133423555','2001-08-17')

select * from Students

insert into Students (Name,Age,Address,PhoneNumber) values ('jaya',23,'No.6 abimanyu st,chennai','9133423555'),('jaya',23,'No.6 abimanyu st,chennai','9133423555')

update Students set Age=50 where ID=22

delete Students where ID=28

delete Students where ID=27

select top(5) * from Students 

alter table Students add DOB Date

select distinct Name from Students

select count( distinct Name ) from Students

--select count(*) as Noofpeople from (select distinct Name from Students)

--Where clause filter record 
select * from Students where Name='hemanath'

select count(Name) from Students where Name='hemanath'

--first 2 char should be h then any number of char and any chars
select * from Students where Name like 'he%'

--first char can be anything the second char should be a and then any chars any number of chars
select * from Students where Name like '_a%'

--Aggregate function

select sum(Age) totalAge from Students
select Min(Age) minage from Students
select Max(Age) minage from Students
select count(Age) from Students
select Avg(Age) average from Students

select count(*) numbercount from Students where Age=23

--group by = for every
select ID , Avg(Age) from Students group by ID

-- sorting

select * from Students order by Name --asc
select * from Students order by Name desc

select Name,avg(Age)avg_Age
from Students 
group by Name
having avg(Age)<15

select * from Students

create table Customers(
CustomerID int identity(100,1),
CustomerName varchar(20),
ContactNumber varchar(10),
City varchar(30))

alter table Customers add constraint PK Primary key (CustomerID)
alter table Customers add StudentID int

alter table Customers add foreign key (StudentID) references Students(ID)

insert into Customers values('Vishnu','9992846479','chennai',1),('beema','9992846479','chennai',10),('ramu','9992846479','chennai',11)

select * from Customers

---Subquery

select * from Customers where StudentID=1

select * from Customers where StudentID = (select ID from Students where Name='hema')

--order select ,from,where,group by,having ,order by

--joins

select CustomerName, City from Customers c join Students s
on c.StudentID = s.ID

--Print the student Id in students table that are not in Customers table
select ID, Name from Students where ID not in 
(select distinct StudentID from Customers)

select Name,Age,Address, CustomerName,City from Students s left outer join Customers c
on c.StudentID = s.ID


select * from Students where Age between 12 and 20

select * from Students where Age not between 12 and 20

select * from Students where Age between 12 and 20 and Name not in('kanaga')

--inner join  (matching values in both the tables)

select ID from Students inner join Customers
on Customers.StudentID = Students.ID

select stud.Name ,Stud.Address, stud.Age , Cust.CustomerName, Cust.City
from Students Stud left outer join Customers Cust 
on Stud.ID = Cust.StudentID

-- self join
select a.Name,a.Age,a.Address,b.PhoneNumber 
from Students a , Students b
where a.Age = b.Age

--The UNION operator is used to combine the result-set of two or more SELECT statements.
--Every SELECT statement within UNION must have the same number of columns
--The columns must also have similar data types
--The columns in every SELECT statement must also be in the same order
--union all for allowing duplicate values

select Name,Address from Students
union
select CustomerName,City from Customers


select * from Students cross join Customers

create procedure proc_students
as
begin
  select * from Students
end

Exec proc_students

create procedure selectStudents @Name varchar(20),@PhoneNumber varchar(10)
as
begin 
    select * from Students where Name=@Name and PhoneNumber= @PhoneNumber
end

Exec selectStudents @Name='hema' ,@PhoneNumber='9940239001'

Exec selectStudents 'hema' ,'9940239001'

create procedure proc_Sample (@un varchar(10), @gender varchar(6))
as
begin 
   if( @gender = 'male')
     begin 
	    select concat('Welcome Mr.',@un)
     end
   else
     begin 
	    select concat('Welcome Ms.',@un)
	end
end

Exec proc_Sample @un='hema',@gender='female'
Exec proc_Sample @un='ram', @gender='male'

create procedure InsertStudents (@ID int,@Name varchar(20), @Age int, @Address varchar(30))
as
begin 
   if(@ID = 0)
    begin
	 insert into Students (Name,Age,Address) values(@Name,@Age,@Address)
	end
   else
     begin
	   select * from Students where ID = @ID
	end
end

Exec InsertStudents @ID=1, @Name='kk',@Age=29,@Address='no 5 olive flat'
Exec InsertStudents @ID=0, @Name='kk',@Age=29,@Address='no 5 olive flat'

create function func_Salary (@basic float,@hra float, @da float,@ded float )
returns float
as 
begin 
   declare @netsal float
   set @netsal = @basic+@hra+@da-@ded
   return @netsal
end

drop Function func_Salary

-- table valued function
create function Function_Student()
returns table
as
return(select * from Students)

select * from Function_Student()

----------------------------------------------------------------

print dbo.Function_Student

create function Func_Add(@num1 int,@num2 int)
returns int
begin
 declare @result int
 set @result =@num1 + @num2
 return @result
end

print dbo.Func_Add (20,50)


create trigger trgInsertDummy
on Students
after Insert
as
begin
 select concat('Hello there!!!!',Name) from inserted
end

declare @ID int, @Name varchar(20)
declare cur_student cursor for
select ID ,Name from Students
open cur_student
fetch next from cur_student into @ID, @Name
print'Student data'
while @@FETCH_STATUS =0
begin 
  print 'Student ID' + cast(@ID as varchar(10))
  print 'Student Name' + @Name

fetch next from cur_student into @ID,@Name
end 
close cur_student
deallocate cur_Student
   

create procedure Student_CRUD
@ID int = null,
@Name varchar(20) =null ,
@Age int= null,
@Address varchar(25)= null,
@PhoneNumber varchar(10)= null,
@DOB date= null,
@Action varchar(10)
as
begin 
if(@Action = 'Create')
begin 
   insert into Students(Name,Age,Address,PhoneNumber,DOB) values (@Name,@Age,@Address,@PhoneNumber,@DOB)
   --Set NoCount On
   --SET @ID=SCOPE_IDENTITY()
   --Set @ID = @@IDENTITY
end
if(@Action = 'SelectAll')
begin
   select * from Students
end
else if(@Action = 'SelectById')
begin
   select * from Students where ID = @ID
end
else if(@Action ='Update')
begin
 update Students set Name=@Name,Age=@Age,Address=@Address,PhoneNumber=@PhoneNumber,@DOB = DOB where ID = @ID
end
else if(@Action ='Delete')
begin
   delete from Students where ID = @ID
end
end

drop proc Student_CRUD
Exec Student_CRUD @Action= 'Create',@Name='fazil',@Age=23,@Address='no 2 vinayaga kovil',@PhoneNumber='9940239001',@DOB='2021-09-08'

Exec Student_CRUD @Action='Update', @Name='hema' where @ID=3