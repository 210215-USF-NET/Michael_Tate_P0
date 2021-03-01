drop table Customer;
drop table Orders;
drop table OrderItems;
drop table Product;
drop table Inventorty;
drop table storeLocation;



create table Customer
(
	id int identity primary key,
	firstName char(12) not null,
	lastName char(12) not null,
	email char(30) not null,
	phoneNumber char(16)

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
	orderDate DATETIME DEFAULT 0 not null,
	firstName char(12) not null,
	lastName char(12) not null,
	productName char(15) not null,
	quantity int not null,
	total smallmoney not null,
	Location int references storeLocation(id),
	Customer int references Customer(id)
);

create table Inventorty
(
	id int identity primary key,
	quantity int not null,
	productName char(15) not null,
	Product int references Product(id),
	Location int references storeLocation(id)
);

INSERT INTO Product (productName) values
('CoconutCream'), ('Strawberry'), ('Blueberry'), ('Pumpkin'), ('Apple'),
('Cherry'), ('Peach'), ('SweetPotato'), ('MixedBerry'), ('BananaCream'),
('Razzleberry'), ('Mince'), ('ChocolateCream'), ('Grasshopper'), ('LemonMeringue'),
('Custard'), ('Turtle'), ('VanillaCaramel'), ('Rhubarb'), ('Blackberry'), ('KeyLime'),
('Pear'), ('Pecan');

insert into storeLocation (city, state, address, zip) values
('Chandler','AZ', '2929 E Ocotillo Rd', 85249), (), (), (), ();

select *;