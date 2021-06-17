create table employee(
	employeeid int NOT NULL AUTO_INCREMENT primary key,
	employeename varchar(100),
	phone varchar(20),
	address varchar(100),
	role varchar(100));

create table account(
	username varchar(100) primary key,
	password varchar(100),
	employeeid int,
	foreign key(employeeid) references employee(employeeid));


create table room(
	roomid int not null AUTO_INCREMENT primary key,
	roomname varchar(100),
	title varchar(200),
	priceperhour int
);

create table service(
	serviceid int not null AUTO_INCREMENT primary key,
	servicename varchar(100),
	price int
);

create table order(
	orderid int not null AUTO_INCREMENT primary key,
	roomid int,
	serviceorder int,
	totalprice int,
	timecreated date,
	employeeid int,
	foreign key(employeeid) references employee(employeeid),
	foreign key(roomid) references room(roomid)
);
