--drop table account;
--drop table customer;
--drop table orderdetail;
--drop table orders;
--drop table publishcompany;
--drop table staff;

create table account(
    username varchar2(50) primary key,
    password varchar2(50),
    staffid number);

create table staff(
    staffid number GENERATED ALWAYS AS IDENTITY primary key,
    fullname varchar2(100),
    dayofbirth date,
    position varchar2(50),
    salary number);

alter table account
add CONSTRAINT fk_account_staffid FOREIGN key (staffid) REFERENCES staff(staffid);

create table author(
    authorid number GENERATED ALWAYS AS IDENTITY primary key,
    fullname varchar2(100),
    dayofbirth date);

create table book(
    bookid number GENERATED ALWAYS AS IDENTITY primary key,
    title varchar2(100),
    authorid number,
    publishyear date,
    price number,
    publishcompany number,
    img nclob);

alter table book
add CONSTRAINT fk_book_authorid FOREIGN key (authorid) REFERENCES author(authorid);

create table customer(
    customerid number GENERATED ALWAYS AS IDENTITY primary key,
    fullname varchar2(100),
    datecreate date,
    createbystaff number);

alter table customer
add CONSTRAINT fk_customer_createbystaff FOREIGN key (createbystaff) REFERENCES staff(staffid);

create table orders(
    orderid number GENERATED ALWAYS AS IDENTITY primary key,
    customerid number,
    totalprice number,
    timecreate date);
    
create table orderdetail(
    orderid number,
    bookid number,
    price number,
    quantom number);

alter table orderdetail
add CONSTRAINT fk_orderdetail_orderid FOREIGN key (orderid) REFERENCES orders(orderid);

alter table orderdetail
add CONSTRAINT fk_orderdetail_bookid FOREIGN key (bookid) REFERENCES book(bookid);

create table publishcompany(
    companyid number GENERATED ALWAYS AS IDENTITY primary key,
    name varchar2(50));
    
alter table book
add CONSTRAINT fk_book_publishcompany FOREIGN key (publishcompany) REFERENCES publishcompany(companyid);

    
insert into staff(fullname,dayofbirth,position,salary) values('Ph?m Ti?n S?',to_date('10/02/2000','dd/mm/yyyy'),'Admin','10000');
insert into staff(fullname,dayofbirth,position,salary) values('Nguy?n V?n A',to_date('13/06/1995','DD-MM-YYYY'),'Sale','2000');


insert into account values('admin','admin',1);

commit;
