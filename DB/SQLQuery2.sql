-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE <Procedure_Name, sysname, ProcedureName> 
	-- Add the parameters for the stored procedure here
	<@Param1, sysname, @p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
	<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO

CREATE PROCEDURE deleteEmployeer
		@EmployeeID INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Delete employee details
    DELETE FROM tbl_Employeers WHERE ID_employee = @EmployeeID;
END
GO

CREATE PROCEDURE addEmployeer

		@name_Employeer VARCHAR(50),
		@first_name VARCHAR(50),
		@second_name VARCHAR(50),
		@email VARCHAR(50),
		@department VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Add employee details
    INSERT INTO tbl_Employeers(emp_name, FirstName, LastName, emp_email, emp_Department)
	VALUES(@name_Employeer, @first_name, @second_name, @email, @department);
END
GO