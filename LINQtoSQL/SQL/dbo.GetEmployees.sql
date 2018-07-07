Alter Procedure GetEmployees(@City Varchar(50)=Null)  
as  
begin  
If @City Is Null
   select *from Employee  
Else 
   select *from Employee where City = @City 
End