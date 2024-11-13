-- Ovo je SQL skripta
--prebacujem se na master bazu
use master;
go -- dajemo mu vremena prije nego sto se prebaci

drop database if exists edunovawp6;
go -- dajemo mu vremena prije nego sto se prebaci

create database edunovawp6; --pravimo novu bazu edunovawp6
go-- dajemo mu vremena prije nego sto se prebaci

use edunovawp6; --prebacujemo se na edunova bazu
go -- dajemo mu vremena prije nego sto se prebaci

--pravim tablicu smjerovi
create table smjerovi(
	sifra int not null primary key identity(1,1),
	naziv varchar(50) not null,
	cijena decimal(18,2) null, -- null se ne mora pisati
	izvodiseod datetime,
	vaucer bit
);
--pravim tablicu grupe
create table grupe(
	sifra int not null primary key identity(1,1),
	naziv varchar (20) not null,
	velicinagrupe int not null,
	predavac varchar (50),
	smjer int not null references smjerovi(sifra)
);
-- pravim tablicu polaznici
create table polaznici(
	sifra int not null primary key identity(1,1),
	ime varchar (50) not null,
	prezime varchar (50) not null,
	email varchar (100) not null,
	oib char (11)
);
--pravim tablicu clanovi
create table clanovi(
	grupa int not null references grupe(sifra),
	polaznik int not null references polaznici(sifra)
);