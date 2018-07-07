Create procedure [dbo].[AddNewEmpDetails]  
(  
   @Name varchar (50),  
   @City varchar (50),  
   @Address varchar (50)
   --@ID Int Out
)  
as  
begin  
   --Select @ID = ISNULL(Max(Id), 1000) + 1 From Employee
   Insert into Employee values(@Name,@City,@Address)  
End
