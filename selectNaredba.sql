select * from smjerovi;


--filtriranje kolona (između select i from)
--* sve kolone
-- kolona
--konstanta
--izraz

select naziv,cijena,
naziv, 'Osijek' as grad,
cijena*1.25 as sPDV,
getdate() as kada, * 
from smjerovi;


--izlistajte imena i prezimena polaznika

select ime,prezime from polaznici;

--filtriranje redova

select * from polaznici;

update polaznici set oib = '69813388640' where sifra=4;


use knjiznica;

select count(*) from autor;

select top 10 * from autor;

insert into autor (sifra,ime,prezime,datumrodenja)
values (4,'Antonijo','Šimpf',1997-07-21)

select sifra =4 from autor;

select top 10 a.ime, a.prezime, b.naslov,c.naziv
from autor a inner join katalog b
on a.sifra = b.autor
inner join mjesto c
on c.sifra = b.mjesto;

select * from katalog a left join autor b on b.sifra = a.autor;

use svastara;

select count(*) from artikli; --52601

select distinct artikl from ArtikliNaPrimci; --52999

select * from artikli where sifra not in (select distinct artikl from ArtikliNaPrimci);

delete from artikli where sifra = 98661;