use mysql;

DROP DATABASE if EXISTS Inventorija;

create DATABASE Inventorija collate utf8mb4_croatian_ci;

use Inventorija;

create table Nabavljaci(
sifra int not null auto_increment primary key,
naziv varchar (100) not null,
ime varchar (100) not null,
prezime varchar (100) not null,
kontakt varchar (100) not null,
br_tel varchar (100) not null
);

create table Proizvodi(
sifra int not null auto_increment primary key,
naziv varchar (100)not null,
cijena decimal (22,2) not null,
nabavljac int not null,
foreign key (nabavljac) references Nabavljaci(sifra)
);

create table Kupci(
sifra int not null auto_increment primary key ,
ime varchar (50) not null,
prezime varchar (50) not null,
br_tel varchar (50) not null,
adresa varchar (100), 
datum_rod date
);

create table Narudzbe(
	sifra int not null auto_increment primary key ,
	ukupan_iznos decimal (22,2) not null,
	datum date,
	status varchar (20),
	kupac int not null,
	foreign key (kupac) references Kupci(sifra)
);

create table Stavke_narudzbe(
	sifra int not null auto_increment primary key ,
	proizvod int not null,
	narudzba int not null,	
	kolicina int not null,
	cijena decimal (22,2),
	foreign key (proizvod) references Proizvodi(sifra),
	foreign key (narudzba) references Narudzbe(sifra)
);

insert into Nabavljaci ( naziv,ime,prezime,kontakt,br_tel)
values('Dobavljač d.o.o.','Ivan','Perić','ivan.peric@dobavljac.hr',0911234567),
('Global Supplies Ltd.','Petra','Novak','petra.novak@global.com',0917654321);

insert into Proizvodi(naziv,cijena,)
values('T-Shirt','20.00'),
('Laptop','4500.00'),
('Kava','60.00');

insert into Kupci(ime,prezime,br_tel,adresa,datum_rod)
values('Marko','Horvat',0912345678,'Ulica Marka 5, Zagreb','1990-05-15'),
('Ana','Kovačić',0918765432,'Ulica Ane 10, Split','1985-12-20');

insert into Narudzbe(ukupan_iznos,datum,status,kupac)
values(100.00,'2024-11-22','Poslana',1),
(60.00,'2024-11-21','U tijeku',2);

insert into Stavke_narudzbe(proizvod,narudzba,kolicina,cijena)
values(1,1,2,40.00),
(1,2,1,60.00),
(2,2,1,60.00);