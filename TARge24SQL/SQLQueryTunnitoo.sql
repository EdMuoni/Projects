--Kasutame left joini
SELECT Title, FirstName, MiddleName, LastName, CompanyName, SalesPerson, EmailAddress, Phone
FROM SalesLt.Customer
LEFT JOIN SalesLt.CustomerAddress
ON Customer.CustomerId = SalesLt.CustomerAddress.CustomerId
ORDER BY LastName

--Kasutame right joini
SELECT SalesLt.CustomerAddress.CustomerID, COUNT(SalesLt.Customer.CustomerID) AS TotalCustomers
FROM SalesLt.Customer
RIGHT JOIN SalesLt.CustomerAddress
ON Customer.CustomerId = SalesLt.CustomerAddress.CustomerId
GROUP BY SalesLt.CustomerAddress.CustomerID

--Kasutame inner joini
-- kuvab neid, kellel on SalesLt.CustomerAddress all olemas väärtus
select Title, FirstName, MiddleName, LastName, CompanyName, SalesPerson, EmailAddress, Phone
from SalesLt.Customer
inner join SalesLt.CustomerAddress
on Customer.CustomerId = SalesLt.CustomerAddress.CustomerId

-- full join
--mõlema tabeli mitte-kattuvate väärtustega read kuvab välja
SELECT Title, FirstName, MiddleName, LastName, SalesLt.Customer.CustomerID, SalesLt.CustomerAddress.CustomerID
FROM SalesLt.Customer
FULL JOIN SalesLt.CustomerAddress
ON Customer.CustomerID = SalesLt.CustomerAddress.CustomerID;


--- cross join võtab kaks allpool olevat tabelit kokku ja korrutab need omavahel läbi
select Title, FirstName, MiddleName, LastName, CompanyName, SalesPerson, EmailAddress, Phone
from SalesLt.Customer
cross join SalesLt.CustomerAddress

--Outer join
SELECT Title, FirstName, MiddleName, LastName, 
       SalesLt.Customer.CustomerID, SalesLt.CustomerAddress.CustomerID
FROM SalesLt.Customer
FULL OUTER JOIN SalesLt.CustomerAddress 
ON SalesLt.Customer.CustomerID = SalesLt.CustomerAddress.CustomerID


create table Employees
(
Id int primary key,
FirstName nvarchar(50),
MiddleName  nvarchar(50),
LastName  nvarchar(50),
Gender nvarchar(50),
Salary nvarchar(50),
DepartmentId int,
Married nvarchar(50),
Children int,
Car  nvarchar(50),
Animal  nvarchar(50)
)
select * from Employees


insert into Employees (Id, FirstName, MiddleName, LastName, Gender, Salary, DepartmentId, Married, Children, Car, Animal)
values (1, 'Tom', 'Hendrikson', 'Mada', 'Male', 4000, 1, 'Yes', 4, 'Toyota', 'Horse')
insert into Employees (Id, FirstName, MiddleName, LastName, Gender, Salary, DepartmentId, Married, Children, Car, Animal)
values (2, 'Dim', 'Dam', 'Dum', 'Female', 6000, 2, 'No', 2, 'Toyota', 'Dog')
insert into Employees (Id, FirstName, MiddleName, LastName, Gender, Salary, DepartmentId, Married, Children, Car, Animal)
values (3, 'Ah', 'Oh', 'Uh', 'Female', 5000, 3, 'No', 8, 'Honda', 'Cat')
insert into Employees (Id, FirstName, MiddleName, LastName, Gender, Salary, DepartmentId, Married, Children, Car, Animal)
values (4, 'Tom', 'Hendrikson', 'Mada', 'Male', 4000, 3, 'Yes', 4, 'Toyota', 'Horse')
insert into Employees (Id, FirstName, MiddleName, LastName, Gender, Salary, DepartmentId, Married, Children, Car, Animal)
values (5, 'Vin', 'Ni', 'Puhh', 'Male', 8000, 5, 'Yes', 7, 'Mazda', 'Pig')
insert into Employees (Id, FirstName, MiddleName, LastName, Gender, Salary, DepartmentId, Married, Children, Car, Animal)
values (6, 'Ai', 'Oi', 'Mama', 'Male', 5959, 6, 'Yes', 5, 'BMW', 'Lemur')



-- 2 server
-- samm nr 2
set deadlock_priority high
go
begin tran
update TableB set Name =
Name + 'Transaction 1' where Id = 1

-- samm nr 4
update TableA set Name =
Name + 'Transaction 1' where Id
in (1, 2, 3, 4, 5)

-- samm nr 6
commit tran

--
create procedure spTransaction2
as
begin
	begin tran
	update TableB set Name = 'Mark Transaction 2' where Id = 1
	waitfor delay '00:00:10'
	update TableA set Name = 'Mary Transaction 2' where Id = 1
	commit tran
end

exec spTransaction2

SELECT
    [s_tst].[session_id],
    [s_es].[login_name] AS [Login Name],
    DB_Name(s_tdt.database_id) AS [Database],
    [s_tdt].[database_transaction_begin_time] AS [Begin Time],
    [s_tdt].[database_transaction_log_bytes_used] AS [Log Bytes],
    [s_tdt].[database_transaction_log_bytes_reserved] AS [Log Rsvd],
    [s_est].text AS [Last T-SQL Text],
    [s_eqp].[query_plan] AS [Last Plan]
FROM
    sys.dm_tran_database_transactions [s_tdt]
JOIN
    sys.dm_tran_session_transactions [s_tst]
    ON [s_tst].[transaction_id] = [s_tdt].[transaction_id]
JOIN
    sys.dm_exec_sessions [s_es]  -- <-- FIXED LINE
    ON [s_es].[session_id] = [s_tst].[session_id]
JOIN
    sys.dm_exec_connections [s_ec]
    ON [s_ec].[session_id] = [s_tst].[session_id]
LEFT OUTER JOIN
    sys.dm_exec_requests [s_er]
    ON [s_er].[session_id] = [s_tst].[session_id]
CROSS APPLY
    sys.dm_exec_sql_text([s_ec].[most_recent_sql_handle]) AS [s_est]
OUTER APPLY
    sys.dm_exec_query_plan([s_er].[plan_handle]) AS [s_eqp]
ORDER BY
    [Begin Time] ASC;
GO

