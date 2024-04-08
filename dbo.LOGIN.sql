CREATE TABLE [dbo].[LOGIN] (
    [EmpID]         INT        NOT NULL,
    [EmpDepartment] NCHAR (10) NULL,
    [EmpSalary]     FLOAT (53) NULL,
    [EmpPos]        NCHAR (10) NULL,
    [Password] NCHAR(10) NULL, 
    PRIMARY KEY CLUSTERED ([EmpID] ASC)
);

