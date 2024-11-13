use master;
go;

drop database if exists Zoo;

create database Zoo;
go;

use Zoo;
go;

create table Zivotinja(
sifra int not null primary key identity(1,1),
vrsta varchar(50),
ime varchar(50),
djelatnik int,
prostorija int,
datum int
);

create table djelatnik(
sifra int not null primary key identity(1,1),
ime varchar(50),
prezime varchar(50),
iban varchar (50)
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
sifra int
);
