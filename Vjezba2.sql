use master;
go

drop database if exists Vjezba2;
go

create database Vjezba2;
go
use Vjezba2;
go

CREATE TABLE klub (
    sifra INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    naziv VARCHAR(30) NOT NULL,                   
    osnovan DATETIME,                             
    stadion VARCHAR(30),                          
    predsjednik VARCHAR(30),                      
    drzava VARCHAR(30),                           
    liga VARCHAR(30)                              
);


CREATE TABLE igrac (
    sifra INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    ime VARCHAR(30) NOT NULL,                    
    prezime VARCHAR(30) NOT NULL,                
    datum_rođenja DATETIME,                      
    pozicija VARCHAR(30),                        
    broj_dresa INT,                              
    klub_sifra INT FOREIGN KEY (klub_sifra) REFERENCES klub(sifra)
	);


CREATE TABLE trener (
    sifra INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    ime VARCHAR(30) NOT NULL,                    
    prezime VARCHAR(30) NOT NULL,                
    klub_sifra INT,                              
    nacionalnost VARCHAR(30),                    
    iskustvo VARCHAR(30) FOREIGN KEY (klub_sifra) REFERENCES klub(sifra)
);


CREATE TABLE utakmica (
    sifra INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    datum DATETIME NOT NULL,                     
    lokacija VARCHAR(30),                        
    stadion VARCHAR(30),                         
    domaci_klub_sifra INT FOREIGN KEY (domaci_klub_sifra) REFERENCES klub(sifra), 
	gostujuci_klub_sifra INT FOREIGN KEY (gostujuci_klub_sifra) REFERENCES klub(sifra)
);