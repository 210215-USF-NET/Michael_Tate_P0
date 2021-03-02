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
	productName varchar(15) not null,
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



INSERT INTO Product (productName, wholeCount, sliceCount, price, Location) values
('CoconutCream', 10, 20, 16.00, 1), ('Strawberry', 10, 20, 16.00, 1), ('Blueberry', 10, 20, 16.00, 1), ('Pumpkin', 10, 20, 16.00, 1), ('Apple', 10, 20, 16.00, 1),
('CoconutCream', 10, 20, 16.00, 2), ('Strawberry', 10, 20, 16.00, 2), ('Blueberry', 10, 20, 16.00, 2), ('Pumpkin', 10, 20, 16.00, 2), ('Apple', 10, 20, 16.00, 2);

insert into Location (name, city, state, address, zip,) values
('GiGi Pie Shop','Chandler','AZ', '2929 E Ocotillo Rd', 85249), ('3.14','Gilbert', 'AZ', '3317 S Higley Rd',85297);



SELECT * FROM Product