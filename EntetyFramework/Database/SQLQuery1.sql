
DROP TABLE Errands
DROP TABLE Customers

CREATE TABLE Customers (
	Id int not null identity primary key,
	FirstName nvarchar(50) not null,
	LastName nvarchar(50) not null,
	Email nvarchar(50) not null unique,
	PhoneNumber char(10) not null unique,
	PostalCode char(5) not null,
	AdressName nvarchar(50) not null,
	City nvarchar(50) not null,
	Country nvarchar(50) not null

)
Go


CREATE TABLE Errands(
	Id int not null identity primary key,
	ErrandTitel nvarchar(50) not null,
	ErrandSpecipication nvarchar(150) not null,
	ErrandTime datetime2(7) not null,
	ErrandStatus nvarchar(50) not null,
	CustomerId int not null references Customers(Id),
	
) 





