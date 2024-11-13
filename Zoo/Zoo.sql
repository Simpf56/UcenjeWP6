use master;
go

drop database Zoo if exists;

create database Zoo;
go

use Zoo;
go

create table Zivotinja(
sifra int not null primary key(1,1),
vrsta varchar(50),
ime varchar(50),
djelatnik int,
prostorija int,
datum int
);

create table djelatnik(
sifra int not null primary key(1,1),
ime varchar(50),
prezime varchar(50),
iban varchar (50)
);

create table 
