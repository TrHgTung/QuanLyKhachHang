CREATE TABLE SL_tblCustomerList (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName NVARCHAR(255) NOT NULL,
    TaxCode NVARCHAR(50) NULL,
    IsCustomer BIT NOT NULL DEFAULT 0,
    IsVendor BIT NOT NULL DEFAULT 0,
    IsPersonal BIT NOT NULL DEFAULT 0,
    Mobile NVARCHAR(20) NULL,
    Email NVARCHAR(255) NULL,
    Address NVARCHAR(500) NULL,
    ContactPerson NVARCHAR(255) NULL,
    DebtLimit DECIMAL(18,2) NULL,
    NumberDayLimit INT NULL
);
