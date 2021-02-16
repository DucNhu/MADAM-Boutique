create database MADAMDataBase
go
-- Product
create table product(
ProductId int identity(1,1),
ProductName varchar(100),
Description varchar(max),
ImagePath varchar(250),
CategoryID int,
UnitPrice float,
Sale int
)

insert into product values
('This is ProductName', 'This is Des', 'default.png', 1, 99.9, 0)

--Category
create table Category(
CategoryId int identity(1,1),
CategoryName varchar(100),
ImageCategory varchar(250)
)

insert into Category values
('Category 1', 'default.png')


--Cart
create table Cart(
CartId int identity(1,1),
ProductId int,
Quantity int
)

insert into Cart values
(1, 10)

