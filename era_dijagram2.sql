
use master;
go

drop database if exists era_dijagram2;
go

create database era_dijagram2;
go

use era_dijagram2;

create table osobe(
	sifra int not null primary key identity (1,1),
	ime varchar (50),
	prezime varchar (50),
	adresa varchar (50),
	email varchar (50)
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
	naslov varchar (50),
	pisac varchar (50),
	vlasnik int foreign key references vlasnik(sifra),
	clan int foreign key references clan(sifra),
	datumpos datetime,
	datumvrac datetime
);