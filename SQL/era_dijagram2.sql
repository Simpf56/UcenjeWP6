
use master;
go

drop database if exists era_dijagram2;
go

drop table if exists osobe;
go

drop table if exists clan;
go

drop table if exists vlasnik;
go

drop table if exists knjige;
go

create database era_dijagram2;
go

use era_dijagram2;
go

create table osobe(
	sifra int not null primary key identity (1,1),
	ime varchar (50) not null,
	prezime varchar (50) not null,
	adresa varchar (50),
	email varchar (50) not null
);
create table clan(
	sifra int not null primary key identity (1,1),
	clbroj int
);
create table vlasnik(
	sifra int not null primary key identity (1,1),
	knjiga int
);
create table knjige(
	sifra int not null primary key identity (1,1),
	naslov varchar (50) not null,
	pisac varchar (50) not null,
	vlasnik int not null foreign key references vlasnik(sifra),
	clan int not null foreign key references clan(sifra),
	datumpos datetime,
	datumvrac datetime
);