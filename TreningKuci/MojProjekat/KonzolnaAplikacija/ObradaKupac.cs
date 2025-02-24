using MojProjekat.KonzolnaAplikacija;
using System.Security.Cryptography;
using MojProjekat.KonzolnaAplikacija.Modeli;

namespace MojProjekat.KonzolnaAplikacija
{
    internal class ObradaKupac
    {

        public List<Kupac> Kupci { get; set; }

        public ObradaKupac()
        {
            Kupci = new List<Kupac>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            for (int i = 0; i < 10; i++)
            {
                Kupci.Add(new()
                {
                    Ime = Faker.Name.First(),
                    Prezime = Faker.Name.Last()
                });
            }
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad s kupacima");
            Console.WriteLine("1. Pregled svih kupaca");
            Console.WriteLine("2. Unos novog kupca");
            Console.WriteLine("3. Promjena podataka postojećeg kupca");
            Console.WriteLine("4. Brisanje kupaca");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziKupce();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNovogKupca();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjeniPodatakKupca();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiKupca();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;
            }
        }

        private void ObrisiKupca()
        {
            PrikaziKupce();
            var odabrani = Kupci[
                Pomocno.UcitajRasponBroja("Odaberi redni broj kupca za brisanje",
                1, Kupci.Count) - 1
                ];
            if (Pomocno.UcitajBool("Sigurno obrisati " + odabrani.Ime + " " + odabrani.Prezime + "? (DA/NE)", "da"))
            {
                Kupci.Remove(odabrani);
            }
        }

        private void PromjeniPodatakKupca()
        {
            PrikaziKupce();
            var odabrani = Kupci[
                Pomocno.UcitajRasponBroja("Odaberi redni broj kupca za promjenu",
                1, Kupci.Count) - 1
                ];
            odabrani.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru kupca", 1, int.MaxValue);
            odabrani.Ime = Pomocno.UcitajString(odabrani.Ime, "Unesi ime kupca", 50, true);
            odabrani.Prezime = Pomocno.UcitajString("Unesi prezime kupca", 50, true);
            odabrani.Adresa = Pomocno.UcitajString("Unesi adresu kupca", 50, true);
            odabrani.Telefon = Pomocno.UcitajString("Unesi telefon kupca", 50, true);
            odabrani.Datum_rod = Pomocno.UcitajDatum("Unesi datum rođenja kupca");
        }

        public void PrikaziKupce()
        {
            PrikaziKupce(Kupci, "Popis kupaca u aplikaciji");
        }

        public void PrikaziKupce(List<Kupac> lista, string naslov)
        {
            Console.WriteLine("*****************************");
            Console.WriteLine(naslov);
            int rb = 0;
            foreach (var p in lista)
            {
                Console.WriteLine(++rb + ". " + p.Ime + " " + p.Prezime); // prepisati metodu toString
            }
            Console.WriteLine("****************************");
        }

        public void UnosNovogKupca()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Unesite tražene podatke o kupcu");
            Kupci.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šifru kupca", 1, int.MaxValue),
                Ime = Pomocno.UcitajString("Unesi ime kupca", 50, true),
                Prezime = Pomocno.UcitajString("Unesi prezime kupca", 50, true),
                Adresa = Pomocno.UcitajString("Unesi adresu kupca", 50, true),
                Telefon = Pomocno.UcitajString("Unesi telefon kupca", 50, true),
                Datum_rod = Pomocno.UcitajDatum("Unesi datum rođenja kupca")
            });
        }
    }
}
