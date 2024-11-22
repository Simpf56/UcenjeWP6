use master;
go

drop database if exists Inventorija;
go

create database Inventorija collate Croatian_CI_AS;;
go

use Inventorija;
go

create table Nabavljači(
	sifra int not null primary key identity (1,1),
	ime varchar (100) not null,
	prezime varchar (100) not null,
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
	ukupan_iznos decimal (22,2) not null,
	datum date,
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

insert into Nabavljači ( naziv,ime,prezime,kontakt,br_tel)
values ('Dobavljač d.o.o.','Ivan','Perić','ivan.peric@dobavljac.hr',0911234567),
('Global Supplies Ltd.','Petra','Novak','petra.novak@global.com',0917654321);

insert into Proizvodi ( naziv,cijena)
values ('T-Shirt',20.00),
('Laptop',4500.00),
('Kava',60.00);

insert into Kupci (ime,prezime,br_tel,adresa,datum_rod)
values ('Marko','Horvat',0912345678,'Ulica Marka 5, Zagreb','1990-05-15'),
('Ana','Kovačić',0918765432,'Ulica Ane 10, Split','1985-12-20');

insert into Narudžbe (ukupan_iznos,datum,status)
values (100,00,'2024-11-22','Poslana'),
(60,00,'2024-11-21','U tijeku');

insert into Inventorija (kolicina_u_skladistu,lokacija,datum_promijene)
values (100,'Zagreb','2024-11-15'),
(50,'Split','2024-11-10'),
(200,'Zagreb','2024-11-12');

insert into Stavke_narudžbe (proizvod,narudzba,kolicina,cijena)
values (1,1,2,40.00),
(1,3,1,60.00),
(2,3,1,60.00);