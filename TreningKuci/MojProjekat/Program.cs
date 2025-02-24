using System;
using MojProjekat;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Kako se zoveš?");
//        string ime = Console.ReadLine();

//        Console.WriteLine("Kako se prezivaš?");
//        string prezime = Console.ReadLine();

//        Console.WriteLine("Koliko imaš godina?");
//        int godina = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Ti se zoveš " + ime + " " + prezime + " i imas " + godina + " godina.");
//    }
//}
//Tester.Izvedi();
//VK01.VjezbaKuci();
//VK02.VjezbaKuci();
//VK03.VjezbaKuci();
//VK04.VjezbaKuci();
//VK05.VjezbaKuci();
//VK06.VjezbaKuci();
//VK07CiklicnaTablica.VjezbaKuci();
//VK08PocinjeOdBroja.VjezbaKuci();
//VK09PocinjeLijevoDolje.VjezbaKuci();
//VK10PocinjeGoreLijevo.VjezbaKuci();
//VK11PocinjeLijevoDolje.VjezbaKuci();
//VK12DoljeDesnoKontra.VjezbaKuci();
//VK13GoreDesnoKontra.VjezbaKuci();
//VK14GoreLijevoKontra.VjezbaKuci();
//VK15DoljeLijevoKontra.VjezbaKuci();
//VK16SredinaLijevo.VjezbaKuci();
//VK17SredinaDesno.VjezbaKuci();
//VK18SredinaGore.VjezbaKuci();
//VK19SredinaDolje.VjezbaKuci();
//ZimskiProgram.Izvedi();
new MojProjekat.KonzolnaAplikacija.Izbornik();












// NAPOMENA vezana za AI. Korištenje AI alata je dobrodošli ako Vam pomogne u boljem razumjevanju
// programerskih koncepata. Ako već i generirate rješenje, svakako ga testirajte i definitivno
// u komunikaciji s AI alatom tražite da Vam se objasni kod ili linija po linija (to dobro radi)


/*

Zimski zadaci:

Jednostavni
1. Izračun površine pravokutnika:
    Napiši program koji od korisnika traži da unese duljinu i širinu pravokutnika, a zatim izračunava i ispisuje površinu pravokutnika.
2. Provjera je li broj pozitivan, negativan ili nula:
    Napiši program koji od korisnika traži da unese broj i ispisuje je li broj pozitivan, negativan ili nula.
3. Zbroj elemenata niza:
    Napiši program koji deklarira niz cijelih brojeva, traži od korisnika da unese vrijednosti u niz, a zatim izračunava i ispisuje zbroj svih elemenata niza.
4. Prosjek ocjena:
    Napiši program koji od korisnika traži da unese broj ocjena, a zatim i same ocjene. Program treba izračunati i ispisati prosjek ocjena.
5. Ispis Fibonaccijevog niza:
    Napiši program koji od korisnika traži da unese broj n, a zatim ispisuje prvih n brojeva Fibonaccijevog niza (0, 1, 1, 2, 3, 5, 8...).
6. Preokret stringa:
    Napiši program koji od korisnika traži da unese string, a zatim ispisuje taj string naopako (npr. "zdravo" postaje "ovardz").
7. Brojanje samoglasnika:
    Napiši program koji od korisnika traži da unese string, a zatim prebrojava i ispisuje koliko samoglasnika ima u tom stringu.
8. Pretvorba temperature:
    Napiši program koji od korisnika traži da unese temperaturu u Celzijusima i pretvara je u Fahrenheit (°F = °C * 9/5 + 32) ili obrnuto, ovisno o odabiru korisnika.
9. Sortiranje niza:
    Napiši program koji deklarira niz cijelih brojeva, traži od korisnika da unese vrijednosti u niz, a zatim sortira niz uzlazno i ispisuje sortirani niz.
10. Kalkulator:
    Napiši program koji od korisnika traži da unese dva broja i operaciju (+, -, *, /), a zatim izračunava i ispisuje rezultat. Koristi switch statement za odabir operacije.


Generator lozinki
   Program od korisnika traži unos podataka:
   Dužina lozinke
   Uključena/isključena velika slova
   Uključena/isključena mala slova
   Uključeni/isključeni brojevi
   Uključeni/isključeni interpunkcijski znakovi
   Lozinka počinje ili ne s brojem
   Lozinka počinje ili ne s interpunkcijskim znakom
   Lozinka završava ili ne s brojem
   Lozinka završava ili ne s interpunkcijskim znakom
   Lozinka ima/nema ponavljajuće znakove
   Broj lozinki koje je potrebno generirati

   Shodno unesenim pravilima program generira rezultat (jedna ili više lozinki)


Ciklična matrica
RIJEŠENO Napraviti osnovni zadatak prema inicijalnoj slici
Dodatno:
Osigurati unos brojeva redova i kolona u rasponu 2 do 50
Napraviti da nakon završetka generiranja jedne matrice pita želite li napraviti još jednu i tako sve dok ne unese NE
Napraviti opcije programa o smjeru kretanja brojeva:
RIJEŠENO 1. dolje desno početak u smjeru kazaljke na satu (inicijalni zadatak)
RIJEŠENO 2. dolje lijevo početak u smjeru kazaljke na satu
RIJEŠENO 3. gore lijevo početak u smjeru kazaljke na satu
RIJEŠENO 4. gore desno početak u smjeru kazaljke na satu
RIJEŠENO 
RIJEŠENO 5. dolje desno početak u kontra smjeru kazaljke na satu 
RIJEŠENO 6. dolje lijevo početak u kontra smjeru kazaljke na satu
RIJEŠENO 7. gore lijevo početak u kontra smjeru kazaljke na satu
RIJEŠENO 8. gore desno početak u kontra smjeru kazaljke na satu

19. sredina (ono što je bio kraj u prvih 8 primjera) lijevo u smjeru kazaljke na satu
10. sredina (ono što je bio kraj u prvih 8 primjera) desno u smjeru kazaljke na satu
11. sredina (ono što je bio kraj u prvih 8 primjera) gore u smjeru kazaljke na satu
12. sredina (ono što je bio kraj u prvih 8 primjera) dolje u smjeru kazaljke na satu

13. sredina (ono što je bio kraj u prvih 8 primjera) lijevo u kontra smjeru kazaljke na satu
14. sredina (ono što je bio kraj u prvih 8 primjera) desno u kontra smjeru kazaljke na satu
15. sredina (ono što je bio kraj u prvih 8 primjera) gore u kontra smjeru kazaljke na satu
16. sredina (ono što je bio kraj u prvih 8 primjera) dolje u kontra smjeru kazaljke na satu

Formatirati brojeve da budu potpisati po pravilima matematike: jedinica ispod jedinice, desetica ispod desetice, stotica ispod stotice






Ljubavni kalkulator
Napraviti osnovni zadatak prema inicijalnoj slici koristeći rekurziju
Dodatno:
Osigurati unos imena (smije imati samo slova, bez brojeva i interpunkcijskih znakova)
promijeniti algoritam da zbraja dva susjedna broja (1 i 2, 3 i 4, 5 i 6, itd.) umjesto osnovnog algoritma 1 i zadnji, drugi i predzadnji itd.
Umjesto rekurzije koristiti petlju po izboru









Kada završite sve zadatke s svim opcijama javite se na email pa ću poslati nove :)






*/



