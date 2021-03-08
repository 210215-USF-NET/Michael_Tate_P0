drop table Product;
drop table Location;
drop table Customer;
drop table Orders;



create table Customer
(
	id int identity primary key,
	firstName varchar(12) not null,
	lastName varchar(12) not null,
	email varchar(30) not null,
	phoneNumber varchar(16)

);

create table Location
(
	id int identity primary key,
	name varchar(20) not null,
	city varchar(17) not null,
	state varchar(2) not null,
	address varchar(30) not null,
	zip int not null
);

create table Product
(
	id int identity primary key,
	productName int not null,
	PieCount int not null,
	price DECIMAL(6,2) not null,
	Location int references Location(id)
);

create table Orders
(
	id int identity primary key,
	orderDate DATETIME DEFAULT SYSDATETIME() not null,
	quantity int not null,
	total DECIMAL not null,
	LocationID int,
	CustomerID int, 
	ProductID int
);

CREATE INDEX iOrderDate 
ON Orders (orderDate);



INSERT INTO Product (productName, PieCount, price, Location) values
(1, 10, 16.00, 1), (2, 10, 16.00, 1), (3, 10, 16.00, 1), (4, 10, 16.00, 1), (5, 10, 16.00, 1),
(1, 10, 16.00, 2), (2, 10, 16.00, 2), (3, 10, 16.00, 2), (4, 10, 16.00, 2), (5, 10, 16.00, 2);

insert into Location (name, city, state, address, zip) values
('GiGi Pie Shop','Chandler','AZ', '2929 E Ocotillo Rd', 85249), ('3.14','Gilbert', 'AZ', '3317 S Higley Rd',85297);

SELECT * FROM Product
