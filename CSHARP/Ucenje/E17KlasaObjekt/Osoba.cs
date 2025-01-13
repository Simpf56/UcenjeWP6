using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt
{
    internal class Osoba
    {
        // klasa sadrzi svojstva (property)
        public int Sifra { get; set; } // OOP princip učahurivanja

        public string Ime { get; set; } // ? oznacavamo kako Ime moze biti null
        public string Prezime { get; set; }

        public Mjesto Mjesto { get; set; }

        // klasa sadrzi metode (i nemoraju biti statične)

        public string ImePrezime()
        {
            Console.WriteLine("Izvođenje s objekta");
            return Ime + " " + Prezime;
        }
        public static void Izvedi()
        {
            Console.WriteLine("Izvođenje statične metode s klase");
        }
    }
}
