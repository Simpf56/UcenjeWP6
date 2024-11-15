use master;
go

drop database if exists Vjezba2;
go

create database Vjezba2;
go
use Vjezba2;
go

CREATE TABLE klub (
    sifra INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary key for klub
    naziv VARCHAR(30) NOT NULL,                   -- Name of the club
    osnovan DATETIME,                             -- Year founded
    stadion VARCHAR(30),                          -- Stadium name
    predsjednik VARCHAR(30),                      -- Club president
    drzava VARCHAR(30),                           -- Country
    liga VARCHAR(30)                              -- League
);

-- Create igrac table
CREATE TABLE igrac (
    sifra INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary key for igrac
    ime VARCHAR(30) NOT NULL,                    -- Player's first name
    prezime VARCHAR(30) NOT NULL,                -- Player's last name
    datum_rođenja DATETIME,                      -- Date of birth
    pozicija VARCHAR(30),                        -- Position (e.g., forward, defender)
    broj_dresa INT,                              -- Jersey number
    klub_sifra INT FOREIGN KEY (klub_sifra) REFERENCES klub(sifra)
	);

-- Create trener table
CREATE TABLE trener (
    sifra INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary key for trener
    ime VARCHAR(30) NOT NULL,                    -- Coach's first name
    prezime VARCHAR(30) NOT NULL,                -- Coach's last name
    klub_sifra INT,                              -- Foreign key referencing klub(sifra)
    nacionalnost VARCHAR(30),                    -- Nationality
    iskustvo VARCHAR(30) FOREIGN KEY (klub_sifra) REFERENCES klub(sifra)
);

-- Create utakmica table
CREATE TABLE utakmica (
    sifra INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary key for utakmica
    datum DATETIME NOT NULL,                     -- Match date and time
    lokacija VARCHAR(30),                        -- Match location
    stadion VARCHAR(30),                         -- Stadium name
    domaci_klub_sifra INT FOREIGN KEY (domaci_klub_sifra) REFERENCES klub(sifra), 
	gostujuci_klub_sifra INT FOREIGN KEY (gostujuci_klub_sifra) REFERENCES klub(sifra)
);