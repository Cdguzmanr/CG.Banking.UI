

drop table if exists customers;
create table customers
(
	CustomerID INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	SSN NVARCHAR(11),
	FirstName NVARCHAR(32),
	LastName NVARCHAR(32),
	DOB Date
)

drop table if exists transactions;
create table transactions
(
	TransactionID INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	CustomerID INT foreign key references customers,
	Amount decimal(5,2),
	TransactionDate Date,
)
