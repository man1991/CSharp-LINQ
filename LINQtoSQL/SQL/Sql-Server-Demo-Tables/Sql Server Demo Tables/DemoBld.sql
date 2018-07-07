Set NoCount ON
If Exists(Select * From SysObjects Where xtype='U' And name='Emp')
Begin
  Drop Table Emp
End
If Exists(Select * From SysObjects Where xtype='U' And name='DeptDetails')
Begin
  Drop Table DeptDetails
End
If Exists(Select * From SysObjects Where xtype='U' And name='Dept')
Begin
  Drop Table Dept
End
If Exists(Select * From SysObjects Where xtype='U' And name='Salgrade')
Begin
  Drop Table Salgrade
End
If Exists(Select * From SysObjects Where xtype='U' And name='Transactions')
Begin
  Drop Table Transactions
End
If Exists(Select * From SysObjects Where xtype='U' And name='Customer')
Begin
  Drop Table Customer
End
Create Table Dept(Deptno Int Constraint Deptno_Pk Primary Key, DName Varchar(50), Loc Varchar(50))
Insert into Dept values(10, 'Marketing', 'Mumbai')
Insert into Dept values(20, 'Sales', 'Chennai')
Insert into Dept values(30, 'Finance', 'Delhi')
Insert into Dept values(40, 'Production', 'Kolkota')

Create table Emp(Empno Int Constraint Empno_Pk Primary Key, Ename Varchar(100), Job Varchar(100), Mgr Int Constraint Mgr_Ref References Emp(Empno), HireDate SmallDateTime, Sal Money Constraint Sal_Check Check (Sal Between 1500 And 7500), Comm Money, Deptno Int, Constraint Deptno_Ref Foreign Key (Deptno) References Dept(Deptno))

Insert into Emp (Empno, Ename, Job, Mgr, HireDate, Sal, Comm, Deptno) Values(1001, 'Scott', 'President', NULL, '01/01/88', 5000, NULL, 10)
Insert into Emp (Empno, Ename, Job, Mgr, HireDate, Sal, Comm, Deptno) Values(1002, 'Clark', 'Manager', 1001, '01/01/88', 4000, NULL, 10)
Insert into Emp (Empno, Ename, Job, Mgr, HireDate, Sal, Comm, Deptno) Values(1003, 'Smith', 'Manager', 1001, '01/01/90', 3500, 500, 20)
Insert into Emp (Empno, Ename, Job, Mgr, HireDate, Sal, Comm, Deptno) Values(1004, 'Vijay', 'Manager', 1001, '01/01/92', 4000, NULL, 30)
Insert into Emp (Empno, Ename, Job, Mgr, HireDate, Sal, Comm, Deptno) Values(1005, 'Ajay', 'Salesman', 1003, '02/04/89', 3000, 300, 20)
Insert into Emp (Empno, Ename, Job, Mgr, HireDate, Sal, Comm, Deptno) Values(1006, 'John Smith', 'Salesman', 1003, '02/08/88', 4000, 600, 20)
Insert into Emp (Empno, Ename, Job, Mgr, HireDate, Sal, Comm, Deptno) Values(1007, 'Venkat', 'Salesman', 1003, '04/15/88', 3300, 0, 20)
Insert into Emp (Empno, Ename, Job, Mgr, HireDate, Sal, Comm, Deptno) Values(1008, 'Vinod', 'Clerk', 1003, '01/15/88', 2400, NULL, 20)
Insert into Emp (Empno, Ename, Job, Mgr, HireDate, Sal, Comm, Deptno) Values(1009, ' Suneel', 'Clerk', 1004, '05/12/83', 2000, NULL, 30)
Insert into Emp (Empno, Ename, Job, Mgr, HireDate, Sal, Comm, Deptno) Values(1010, 'Srinivas', 'Analyst', 1004, '03/01/89', 3400, NULL, 30)
Insert into Emp (Empno, Ename, Job, Mgr, HireDate, Sal, Comm, Deptno) Values(1011, 'Smyth', 'Analyst', 1004, '03/01/89', 3600, NULL, 30)
Insert into Emp (Empno, Ename, Job, Mgr, HireDate, Sal, Comm, Deptno) Values(1012, 'Madan', 'Analyst', 1004, '01/09/91', 3100, NULL, 30)
Insert into Emp (Empno, Ename, Job, Mgr, HireDate, Sal, Comm, Deptno) Values(1013, 'JohnSmith', 'Clerk', 1002, '01/06/88', 1800, NULL, 10)
Insert into Emp (Empno, Ename, Job, Mgr, HireDate, Sal, Comm, Deptno) Values(1014, 'Raju', 'Clerk', 1005, '06/01/89', 2300, NULL, 20)
Insert into Emp (Empno, Ename, Job, Mgr, HireDate, Sal, Comm, Deptno) Values(1015, 'Ramesh', 'Clerk', 1011, '08/22/90', 2500, NULL, 30)

Create table DeptDetails (Did Int Constraint Did_Pk Primary Key, Deptno Int References Dept(Deptno), Comments Varchar(8000))
Insert into DeptDetails values(1, 10, 'This department is located in Mumbai and mainly involved in marketing')
Insert into DeptDetails values(2, 20, 'This department is located in Chennai and mainly involved in Sales')
Insert into DeptDetails values(3, 30, 'This department is located in Delhi and mainly involved in Finance')
Insert into DeptDetails values(4, 40, 'This department is located in Kolkota and mainly involved in Production')

Create Table SalGrade(Grade Int Constraint Grade_Pk Primary Key, LoSal Money, Hisal Money)
Insert into SalGrade Values(1, 1300, 1800)
Insert into SalGrade Values(2, 1801, 2700)
Insert into SalGrade Values(3, 2701, 3500)
Insert into SalGrade Values(4, 3501, 5000)
Insert into SalGrade Values(5, 5001, 8000)

Create Table Customer(Custid Int Constraint Custid_Pk Primary Key, Cname Varchar(50), Balance Decimal(9, 2), Status Bit Default 1)
Insert Into Customer Values(101, 'Zane', 15000, 1)
Insert Into Customer Values(102, 'Jones', 12000, 1)
Insert Into Customer Values(103, 'Anne', 21000, 0)
Insert Into Customer Values(104, 'Peter', 35000, 1)
Insert Into Customer Values(105, 'Venu', 10000, 1)
Insert Into Customer Values(106, 'Raghu', 15000, 1)

Create Table Transactions(
TransId Int Identity Constraint TransId_Pk Primary Key, Custid Int Constraint Custid_FK References Customer(Custid), TransType Varchar(50), TransDate Date, TransTime Time, TransAmount Decimal(9, 2), TransRemarks Varchar(100))