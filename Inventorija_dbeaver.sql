use mysql;

DROP DATABASE if EXISTS Inventorija;

create DATABASE Inventorija collate utf8mb4_croatian_ci;

use Inventorija;

create table Nabavljaci(
sifra int not null auto_increment primary key,
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