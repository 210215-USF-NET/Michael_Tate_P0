drop table Cutomer;
drop table Orders;
drop table OrderItems;
drop table Product;
drop table Inventorty;
drop table storeLocation;



create table Cutomer
(
	id int identity primary key,
	firstName varchar(12) not null,
	lastName varchar(12) not null,
	email varchar(30) not null,
	phoneNumber varchar(10)

);

create table Product
(
	id int identity primary key,
	productName char(15) not null,
	description char(50), --may delete later
	price smallmoney not null
);

create table storeLocation
(
	id int identity primary key,
	city char(17) not null,
	state char(2) not null,
	address char(30) not null,
	zip int not null
);

create table OrderItems
(
	id int identity primary key,
	quantity int not null,
	Product int references Product(id)
);

create table Orders
(
	id int identity primary key,
	firstName varchar(12) not null,
	lastName varchar(12) not null,
	productName varchar(15) not null,
	quantity int not null,
	total smallmoney not null,
	Location int references storeLocation(id),
	Cutomer int references Cutomer(id)
);

create table Inventorty
(
	id int identity primary key,
	quantity int not null,
	productName char(15) not null,
	Product int references Product(id),
	Location int references storeLocation(id)
);
insert into storeLocation (city, state, address, zip) values
('Chandler','AZ', '2929 E Ocotillo Rd', 85249);