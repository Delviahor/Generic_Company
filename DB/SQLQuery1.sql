CREATE TABLE tbl_Employeers (
    ID_employee INT IDENTITY(1,1) PRIMARY KEY,
    emp_name VARCHAR(50) NOT NULL,
	FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50),
	emp_email VARCHAR(50) NOT NULL,
    emp_Department VARCHAR(50) NOT NULL,
);

