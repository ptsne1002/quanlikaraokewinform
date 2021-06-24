create table employee(
	employeeid number GENERATED ALWAYS AS IDENTITY primary key,
	employeename nvarchar2(100),
	phone nvarchar2(20),
	address nvarchar2(100),
	role nvarchar2(100),
	salary int,
	birthday date,
	gender nvarchar2(20));


create table account(
	username nvarchar2(100) primary key,
	password nvarchar2(100),
	employeeid int,
	foreign key(employeeid) references employee(employeeid));


create table room(
	roomid number GENERATED ALWAYS AS IDENTITY primary key,
	roomname nvarchar2(100),
	type nvarchar2(200),
	priceperhour int,
	status nvarchar2(50));

create table customer(
    customerid number GENERATED ALWAYS AS IDENTITY primary key,
    name nvarchar2(100),
    phone varchar2(11));

create table booking(
    bookingid number GENERATED ALWAYS AS IDENTITY primary key,
    roomid number,
    empid number,
    customerid number,
    timecreated nvarchar2(50),
    status nvarchar2(40),
    foreign key(empid) references employee(employeeid),
    foreign key(roomid) references room(roomid),
    foreign key(customerid) references customer(customerid));



create table service(
	serviceid NUMBER GENERATED by default on null as IDENTITY,
	servicename nvarchar2(100),
	price int,
    primary key (serviceid));


create table invoice(
    orderid number GENERATED ALWAYS AS IDENTITY primary key,
    bookingid number,
    timeend nvarchar2(50),
    totalprice number,
    createdby number,
    foreign key(createdby) references employee(employeeid),
    foreign key(bookingid) references booking(bookingid));


create table orderservice(
    bookingid number,
    serviceid NUMBER,
    amount number,
    total number,
    timecreated nvarchar2(40),
    foreign key(bookingid) references booking(bookingid),
    foreign key(serviceid) references service(serviceid));


/* Create Trigger For DB */

create or replace trigger insert_stt_for_room
before insert on room
for each row
begin 
    :new.status := 'Already' ;
end;

create or replace trigger set_price_for_room
before insert or update on room
for each row
begin 
    if :new.type = 'Normal' then
        :new.priceperhour := 50;
    ELSIF :new.type = 'Vip' then
        :new.priceperhour := 70;
    end if;
end;

create or replace trigger set_stt_for_booking
before insert on invoice
for each row
begin
    update booking
    set status = 'Done'
    where bookingid = :new.bookingid;
end;

create or replace trigger change_stt_room
before insert on booking
for each row
begin
    :new.status := 'Using';
    update room
    set status = 'Busy'
    where roomid = :new.roomid;
end;

create or replace trigger change_stt_room2
before update on booking
for each row
begin
    if :new.status ='Done' then
        update room
        set status = 'Already'
        where roomid = :new.roomid;
    end if;
end;

create or replace trigger auto_caculate_price
before update or insert on orderservice
for each row
declare
    unitprice service.price%type;
begin
    select price into unitprice
    from service
    where service.serviceid = :new.serviceid;
    :new.total := unitprice * :new.amount;
end;


/* Insert Data */

INSERT INTO employee ( employeename, phone, address, role, salary, birthday, gender) VALUES
( 'Pham Tien Sy', '0868686868', 'Gia Lai City', 'Admin', 20000, to_date('10/02/2000' ,'dd/mm/yyyy'), 'Male');
INSERT INTO employee ( employeename, phone, address, role, salary, birthday, gender) VALUES
( 'Pham Van Nhon', '087878787', 'Binh Thuan City', 'Staff', 9000, to_date('10/07/2000' ,'dd/mm/yyyy'), 'Male');
INSERT INTO employee ( employeename, phone, address, role, salary, birthday, gender) VALUES
( 'Do Thanh Quyen', '089898989', 'Hue City', 'Staff', 9000, to_date('10/04/2000' ,'dd/mm/yyyy'), 'Male');

INSERT INTO account (username, password, employeeid) VALUES('pts', 'pts', 1);

INSERT INTO room (roomname, type) VALUES ('A1.1', 'Normal');
INSERT INTO room (roomname, type) VALUES ('A1.2', 'Normal');
INSERT INTO room (roomname, type) VALUES ('A1.3', 'Normal');
INSERT INTO room (roomname, type) VALUES ('A1.4', 'Normal');
insert into room (roomname, type) VALUES ('A1.5','Normal');
insert into room (roomname, type) VALUES ('A1.6','Vip');


insert into invoice(bookingid, timeend, totalprice, createdby) values (11,'11:54 24/06/2021',5611910,1)
