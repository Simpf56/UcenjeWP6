using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.E17KlasaObjekt.edunova;

namespace Ucenje.E17KlasaObjekt
{
    public class Program
    {
        public Program()
        {
            // objest je instanca (pojavnost)klase

            // Osoba je ime klase (Primjetiti veliko početno slovo)
            // osoba je ime Objeka (instance/pojavnosti) - varijabla (primjetiti malo pocetno slovo o)
            Osoba osoba = new Osoba();

            osoba.Sifra = 1;

            // Osoba.Sifra na klasi ne postoji svojstvo, ono je na objektu

            osoba.Ime = "Pero"; /*E12Metode.UcitajString("Unesi ime");*/
            osoba.Prezime = "Perić";

            Console.WriteLine(osoba.Ime);

            osoba = new Osoba() { 
                Sifra = 2,
                Ime = "Karlo",
                Prezime = "Lik" 
            };

            Console.WriteLine("{0} {1}",osoba.Ime, osoba.Prezime);
            Console.WriteLine(osoba.ImePrezime());

            Osoba.Izvedi();
            //Console.WriteLine(osoba.Izvedi()); Nemožeš pozvati statičnu metodu na objektu (malo slovo o), vec


            Mjesto mjesto = new Mjesto(){ Naziv = "Osijek",PostanskiBroj = "32000"};

            //osoba.Mjesto = mjesto;
            //ispisi Osijek
            //Console.WriteLine(osoba.Mjesto.Naziv);

            if (osoba.Mjesto != null)
            {
                Console.WriteLine(osoba.Mjesto.Naziv);
            }

            //kraci nacin
            Console.WriteLine(osoba.Mjesto?.Naziv); // ? je ovdje indikacija


            osoba.Mjesto = new Mjesto() { Naziv = "Osijek" };

            Console.WriteLine(osoba.Mjesto.Zupanija?.Zupan ?? "Prazno"); // nakon ?? ide vrijednost koja se koristi ako je svojstvo null

            Smjer smjer = new Smjer() { Naziv = "Web Programiranje" };
            Grupa grupa = new Grupa() { Naziv = "WP6", Smjer = smjer };// jos krace

            Polaznik[] polazniciNiz = new Polaznik[2];

            polazniciNiz[0] = new Polaznik(){ Ime = "Pero" };
            polazniciNiz[1] = new Polaznik(){ Ime = "Marija" };

            grupa.Polaznici = polazniciNiz;

            //ispisati podatke o grupe

            Console.WriteLine(grupa.Naziv);
            Console.WriteLine(grupa.Smjer.Naziv);

            foreach(Polaznik p in grupa.Polaznici)
            {
                Console.WriteLine("{0} {1}", p.Ime, p.Prezime);

            }

            Console.WriteLine("*******************");
            grupa.DetaljiGrupe();
        }
    }
}
