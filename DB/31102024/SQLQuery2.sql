USE [Generic_Company_DB]
GO
/****** Object:  StoredProcedure [dbo].[sp_add_procedure]    Script Date: 31/10/2024 09:41:25 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_add_procedure]
(
    @name INT,
	@first_surname NVARCHAR,
	@second_surname NVARCHAR,
	@email NVARCHAR,
	@department NVARCHAR
)
AS
BEGIN
    INSERT INTO tbl_Employees(emp_name, emp_first_surname, emp_second_surname, emp_email, emp_department)
	VALUES(@name, @first_surname, @second_surname, @email, @department)

END
