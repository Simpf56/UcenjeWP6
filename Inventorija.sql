use master;
go

drop database if exists Inventorija;
go

create database Inventorija collate Croatian_CI_AS;;
go

use Inventorija;

create table Nabavljači(
	sifra int not null primary key identity (1,1),
	naziv varchar (100) not null,
	kontakt varchar (100) not null,
	br_tel varchar (100) not null
);

create table Proizvodi(
	sifra int not null primary key identity (1,1),
	naziv varchar (100)not null,
	cijena decimal (22,2) not null,
	nabavljac int foreign key references Nabavljači(sifra)
);

create table Kupci(
	sifra int not null primary key identity (1,1),
	ime varchar (50)not null,
	prezime varchar (50)not null,
	br_tel varchar (50) not null,
	adresa varchar (100), 
	datum_rod date
);

create table Narudžbe(
	sifra int not null primary key identity (1,1),
	ukupan_iznos int not null,
	datum datetime,
	status varchar (20),
	kupac int foreign key references Kupci(sifra)
);

create table Inventorija(
	sifra int not null primary key  identity (1,1),
	proizvod int foreign key references Proizvodi(sifra),
	kolicina_u_skladistu int not null,
	lokacija varchar (100),
	datum_promijene datetime
);

create table Stavke_narudžbe(
	sifra int primary key not null identity (1,1),
	proizvod int foreign key references Proizvodi(sifra),
	narudzba int foreign key references Narudžbe(sifra),
	kolicina int not null,
	cijena decimal (22,2)
);
