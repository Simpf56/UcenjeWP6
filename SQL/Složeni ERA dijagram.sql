use master;
go

drop database if exists Izdavacka_kuca ;
go

create database Izdavacka_kuca collate Croatian_CI_AS;
go

use Izdavacka_kuca;

create table Drzava(
	sifra int not null primary key identity (1,1),
	naziv varchar (50)
);

create table Spol(
	sifra int not null primary key identity (1,1),
	naziv varchar (50)
);

create table Ocjena(
	sifra int not null primary key identity (1,1),
	naziv varchar (50),
	opis varchar (20)
);

create table Vrsta_albuma(
	sifra int not null primary key identity (1,1),
	naziv varchar (50),
	skracenica varchar (50)
);

create table Instrument(
	sifra int not null primary key identity (1,1),
	naziv varchar (50)
);

create table [Status](
	sifra int not null primary key identity (1,1),
	naziv varchar (50),
	opis varchar (50),
);

create table Zanr(
	sifra int not null primary key identity (1,1),
	naziv varchar (50)
);

create table Grad(
	sifra int not null primary key identity (1,1),
	naziv varchar (50),
	drzava int not null foreign key references Drzava(sifra)
);

create table Izdavacka_kuca(
	sifra int not null primary key identity (1,1),
	naziv varchar (50),
	sjediste int foreign key references Grad(sifra)
);

create table Grupa(
	sifra int not null primary key identity (1,1),
	naziv varchar (50),
	godina_osnutka char (4),
	godina_raspada char (4),
	teme_pjesama varchar (50),
	opis_grupe varchar (100),
	web_stranica varchar (200),
	zemlja_podrijetla int foreign key references Drzava(sifra),
	lokacija int foreign key references Grad(sifra),
	[status] int foreign key references [Status](sifra),
	zanr int foreign key references Zanr(sifra)
);

create table Grupa_izdavacka_kuce(
	sifra int not null primary key identity (1,1),
	grupa int foreign key references Grupa(sifra),
	izdavacka_kuca int foreign key references Izdavacka_kuca(sifra),
	datum_raskida date
);

create table Izvodjac(
	sifra int not null primary key identity (1,1),
	ime varchar (50),
	prezime varchar (50),
	nadimak varchar (50),
	datum_rodenja date,
	datum_smrti date,
	grad_rodenja int foreign key references Grad(sifra),
	spol int foreign key references Spol(sifra)
);

create table Album(
	sifra int not null primary key identity (1,1),
	naslov varchar (50),
	grupa int foreign key references Grupa(sifra),
	vrsta_albuma int foreign key references Vrsta_albuma(sifra),
	izdavacka_kuca int foreign key references Izdavacka_kuca(sifra),
	datum_izdavanja date,
	informacije varchar (200)
);

create table Album_izvodjaci(
	sifra int not null primary key identity (1,1),
	izvodjac int foreign key references Izvodjac(sifra),
	album int foreign key references Album(sifra),
	instrument int foreign key references Instrument(sifra)
);

create table Pjesme(
	sifra int not null primary key identity (1,1),
	naziv varchar (100),
	album int foreign key references Album(sifra),
	trajanje time,
	rijeci varchar (1000)
);

create table Korisnik(
	sifra int not null primary key identity (1,1),
	ime varchar (50),
	prezime varchar (50),
	korisnicko_ime varchar (50),
	lozinka varchar (100),
	email varchar (100),
	datum_rodenja date,
	tekst varchar (200),
	spol int foreign key references Spol(sifra),
	grad_rodenja int foreign key references Grad(sifra),
	trenutno_boraviste int foreign key references Grad(sifra)
);

create table Korisnik_zeli_album(
	korisnik int foreign key references Korisnik(sifra),
	album int foreign key references Album(sifra),
	ocjena int foreign key references Ocjena(sifra)
);

create table Korisnik_ima_album(
	korisnik int foreign key references Korisnik(sifra),
	album int foreign key references Album(sifra),
	datum_nabave date,
	stanje_albuma varchar (50),
	ocjena int foreign key references Ocjena(sifra)
);




