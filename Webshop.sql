use master;
go

drop database if exists Webshop;
go

create database Webshop collate Croatian_CI_AS;
go

use Webshop;

create table Proizvodi(
	sifra int not null primary key identity (1,1),
	naziv varchar(50),
	datum_nabave datetime AS FORMAT(datum_nabave,'dd-MM-yyyy HH:mm'),
	cijena decimal (22,2),
	aktivan bit
);

create table Kupci(
	sifra int not null primary key identity (1,1),
	ime varchar (50) not null,
	prezime varchar (50) not null,
	ulica varchar (100) not null,
	mjesto varchar (50) not null
);

create table Racuni(
	sifra int not null primary key identity (1,1),
	datum_nabave datetime,
	kupac int foreign key references Kupci(sifra),
	[status] bit not null
);

create table Stavke(
	sifra int not null primary key identity (1,1),
	racun int not null foreign key references Racuni(sifra),
	proizvod int not null foreign key references Proizvodi(sifra),
	kolicina int not null,
	cijena decimal (22,2) not null
);

insert into Proizvodi (naziv,datum_nabave,cijena,aktivan)
		values ('Margarin','2024-11-24 09:59',1.50,1);

select * from Proizvodi;
