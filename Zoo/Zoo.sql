use master;
go

drop database if exists Zoo;

create database Zoo;
go

use Zoo;
go



create table djelatnik(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
iban varchar (50) not null
);

create table prostorija(
sifra int not null primary key identity(1,1),
dimenzije varchar(30),
maks_broj int,
mjesto varchar(30)

);

create table datum(
datum_rodenja datetime,
datum_dolaska datetime,
datum_smrti datetime,
sifra int primary key identity (1,1) not null
);

create table zivotinja(
sifra int not null primary key identity(1,1),
vrsta varchar(50) not null,
ime varchar(50) not null,
djelatnik int not null references djelatnik(sifra),
prostorija int not null references prostorija(sifra),
datum int references datum (sifra)
);