
use master;
go

drop database if exists katalog;
go

create database katalog;
go

use katalog;

create table autor(
	sifra int not null primary key identity (1,1),
	ime nvarchar(50) not null,
	prezime nvarchar(50) not null,
	datum_rodenja datetime
);

create table izdavac(
	sifra int not null primary key identity (1,1),
	naziv nvarchar(50) not null,
	aktivan bit
);

create table mjesto(
	sifra int not null primary key identity (1,1),
	naziv nvarchar (50) not null,
	postanski_broj nvarchar(10) not null,
	drzava nvarchar(50)
);

create table katalog(
	sifra int not null primary key identity (1,1),
	autor int not null foreign key references autor(sifra),
	naslov nvarchar (50) not null,
	izdavac int not null foreign key references izdavac(sifra),
	mjesto int not null foreign key references mjesto(sifra)
	);