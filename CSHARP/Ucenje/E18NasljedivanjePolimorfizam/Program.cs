using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje.E18NasljedivanjePolimorfizam
{
    public class Program
    {
        // konstruktor -> poziva se s kljucnom riješenju
        public Program(string s)
        {
            Console.WriteLine(s);
            var smjer = new Smjer() { Sifra = 1, Naziv = "Web Programiranje" };

            Console.WriteLine(smjer); // kada se ispisuje cijeli objest izvodi se motedoa toString na klasama od dolje prema gore(zadnja je object)

            var osoba = new Osoba() { Sifra = 1, Ime = "Pero", Prezime = "Perić" };

            osoba = new Osoba("Marija", "Zimska");

            Console.WriteLine(osoba);
            // string je immutable https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
            string s1 = "AA";

            Console.WriteLine(s1.GetHashCode()); // hashcode je reprezentant memorijeske lokacije

            s1 = "BB";

            Console.WriteLine(s1.GetHashCode());

            // dosadasnja praksa spajanja stringova s + nije dobra

            // dobra praksa je koristiti string builder

            var sb = new StringBuilder();

            sb.Append("AA");

            Console.WriteLine(sb.GetHashCode());

            sb.Clear().Append("BB");

            Console.WriteLine(sb.GetHashCode());


            Smjer smjer1 = new Smjer() { Naziv = "Web Programiranje" };
            Smjer smjer2 = new Smjer() { Naziv = "Web Programiranje" };

            Console.WriteLine(smjer1.GetHashCode());
            Console.WriteLine(smjer2.GetHashCode());
            Console.WriteLine(smjer.Equals(smjer2));


            // ima li smisla raditi instancu klase entitet??
            //var e = new Entitet();
            //e.Sifra = 1;

            var e = new EntitetImpl() { Sifra = 1 };

            // još nismo na polimorfizmu

            Obrada[] obrade = new Obrada[2];

            obrade[0] = new ObradaUlazniRacun();
            obrade[1] = new ObradaIzlazniRacun();

            // polimorfizam
            foreach(Obrada o in obrade)
            {
                o.Procesuiraj();
            }
        }
    }
}
