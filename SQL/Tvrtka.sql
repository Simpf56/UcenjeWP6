
use master;
go

drop database if exists Tvrtka;
go

create database Tvrtka collate Croatian_CI_AS;
go

use Tvrtka;
create table Zaposlenici(
	sifra int not null primary key identity(1,1),
	ime varchar(50),
	prezime varchar(50),
	datum_rodenja date,
	placa decimal (22,2),
	invalid bit
);

create table Slike(
	sifra int not null primary key identity(1,1),
	zaposlenik int not null foreign key references Zaposlenici(sifra),
	redni_broj int not null,
	pitanja varchar (200)
);

insert into Zaposlenici (ime,prezime,datum_rodenja,placa,invalid)
values	('Marko','Jurić','1997-05-21',1000.00,1),
		('Petar','Filipović','1998-04-13',1100.00,0),
		('Marija','Anić','1949-05-03',1500.00,0);

insert into Slike (zaposlenik,redni_broj,pitanja)
values	(1,1,'Kad će plaća?'),
		(1,2,'Kamo krenuti?'),
		(2,3,'Kome se mogu obratiti za pomoć s trenutnim projektom?'),
		(2,4,'Kako mogu doprinijeti timu u trenutnom zadatku?'),
		(3,5,'Kako mogu unaprijediti svoje vještine?'),
		(3,6,'Kako napredovati dalje?');

select *from Zaposlenici;

select * from Slike;