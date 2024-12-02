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
	datum_nabave datetime,
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
	datum datetime,
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
	values	('Margarin','2024-11-24 09:59',1.50,1),
			('Kruh','2024-11-24 10:02',0.80,1),
			('Coca-Cola','2024-11-25',1.50,1);

insert into Kupci(ime,prezime,ulica,mjesto)
	values	('Antonijo','Perić','Matije Gupca 42','Osijek'),
			('Petra','Katavić','Kralja Zvonimira 58','Osijek'),
			('Anamarija','Mijatović','Genscherova 1', 'Vinkovci');

insert into Racuni(datum,kupac,status)
	values	('2024-11-25 15:00',1,1),
			('2024-11-25 12:00',2,1),
			('2024-11-25 13:00',3,1);

insert into Stavke(racun,proizvod,kolicina,cijena)
	values	(1,1,2,3.00),
			(2,2,3,2.40),
			(3,3,6,9.00);

select * from Proizvodi;
select * from Kupci;
select * from Racuni;
select * from Stavke;

