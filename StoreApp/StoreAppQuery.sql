--drop table Customer;
--drop table Orders;
--drop table Product;
--drop table Location;



create table Customer
(
	id int identity primary key,
	firstName char(12) not null,
	lastName char(12) not null,
	email char(30) not null,
	phoneNumber char(16)

);

create table Location
(
	id int identity primary key,
	city char(17) not null,
	state char(2) not null,
	address char(30) not null,
	zip int not null
);

create table Product
(
	id int identity primary key,
	productName char(15) not null,
	wholeCount int not null,
	sliceCount int not null,
	price DECIMAL(6,2) not null,
	Location int references Location(id)
);

create table Orders
(
	id int identity primary key,
	orderDate DATETIME DEFAULT 0 not null,
	quantity int not null,
	Location int references Location(id),
	Customer int references Customer(id),
	Product int REFERENCES Product(id)
);

CREATE INDEX iOrderDate 
ON Orders (orderDate);



--INSERT INTO Product (productName) values
--('CoconutCream'), ('Strawberry'), ('Blueberry'), ('Pumpkin'), ('Apple');

insert into Location (city, state, address, zip) values
('Chandler','AZ', '2929 E Ocotillo Rd', 85249), ('Gilbert', 'AZ', '3317 S Higley Rd',85297);



SELECT * FROM Location