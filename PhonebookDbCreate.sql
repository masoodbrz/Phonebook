create database Phonebook
Go
use phonebook
Go
create table Person(
	ID int primary key identity(1,1),
	Title nvarchar(50),
	PhoneNumber nvarchar(50),
	Mobile nvarchar(50)
	)