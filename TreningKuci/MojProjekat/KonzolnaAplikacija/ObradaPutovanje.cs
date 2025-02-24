using MojProjekat.KonzolnaAplikacija;
using MojProjekat.KonzolnaAplikacija.Modeli;

namespace MojProjekat.KonzolnaAplikacija
{
    internal class ObradaPutovanje
    {

        public List<Putovanje> Putovanja { get; set; }

        public ObradaPutovanje()
        {
            Putovanja = new List<Putovanje>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            Putovanja.Add(new() { Naziv = "Austrija" });
            Putovanja.Add(new() { Naziv = "Njemačka" });
            Putovanja.Add(new() { Naziv = "Španjolska" });
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad sa putovanjima");
            Console.WriteLine("1. Pregled svih putovanja");
            Console.WriteLine("2. Pregled detalja pojedinog putovanja");
            Console.WriteLine("3. Unos novog putovanja");
            Console.WriteLine("4. Promjena podataka postojećeg putovanja");
            Console.WriteLine("5. Brisanje putovanja");
            Console.WriteLine("6. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 6))
            {
                case 1:
                    PrikaziPutovanja();
                    PrikaziIzbornik();
                    break;
                case 2:
                    PregledDetaljaPojedinogPutovanja();
                    PrikaziIzbornik();
                    break;
                case 3:
                    UnosNovogPutovanja();
                    PrikaziIzbornik();
                    break;
                case 4:
                    PromjeniPostojecePutovanje();
                    PrikaziIzbornik();
                    break;
                case 5:
                    ObrisiPostojecePutovanje();
                    PrikaziIzbornik();
                    break;
                case 6:
                    Console.Clear();
                    break;
            }
        }

        private void PregledDetaljaPojedinogPutovanja()
        {
            PrikaziPutovanja();
            var s = Putovanja[
                Pomocno.UcitajRasponBroja("Odaberi redni broj putovanja za detalje", 1, Putovanja.Count) - 1
                ];
            Console.WriteLine("--------------------");
            Console.WriteLine("Detalji putovanja:");
            Console.WriteLine("Šifra: " + s.Sifra);
            Console.WriteLine("Naziv: " + s.Naziv);
            Console.WriteLine("Destinacija: " + s.Destinacija);
            Console.WriteLine("Cijena: " + s.Cijena);
            Console.WriteLine("Datum: " + s.Datum.ToString("dd. MM. yyyy."));
            Console.WriteLine("Popust: " + ((bool)s.Popust ? "DA" : "NE"));            
            Console.WriteLine("--------------------");
        }

        private void ObrisiPostojecePutovanje()
        {
            PrikaziPutovanja();
            var odabrani = Putovanja[Pomocno.UcitajRasponBroja("Odaberi redni broj putovanja za Brisanje",
                1, Putovanja.Count) - 1];

            if (Pomocno.UcitajBool("Sigurno obrisati " + odabrani.Naziv + "? (DA/NE)", "da"))
            {
                Putovanja.Remove(odabrani);
            }

        }

        private void PromjeniPostojecePutovanje()
        {
            PrikaziPutovanja();
            var odabrani = Putovanja[Pomocno.UcitajRasponBroja("Odaberi redni broj putovanja za promjenu",
                1, Putovanja.Count) - 1];

            if (Pomocno.UcitajRasponBroja("1. Mjenjaš sve\n2. Pojedinačna promjena", 1, 2) == 1)
            {
               
                odabrani.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru putovanja", 1, int.MaxValue);
                odabrani.Naziv = Pomocno.UcitajString("Unesi naziv putovanja", 50, true);
                odabrani.Destinacija = Pomocno.UcitajString("Unesi datum putovanja", 50, true);
                odabrani.Cijena = Pomocno.UcitajDecimalniBroj("Unesi cijenu putovanja", 1,10000,true);
                odabrani.Popust = Pomocno.UcitajBool("Da li putovanje ima popust (DA/NE)", "da");

            }
            else
            {
                
                switch (Pomocno.UcitajRasponBroja("1. Šifra\n2. Naziv\n3. Destinacija\n4. Datum\n5. Status\n6.Datum promjene ",
                    1, 7))
                {
                    case 1:
                        odabrani.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru putovanja", 1, int.MaxValue);
                        break;
                    case 2:
                        odabrani.Naziv = Pomocno.UcitajString("Unesi naziv putovanja", 50, true, odabrani.Naziv);
                        break;
                    case 3:
                        odabrani.Destinacija = Pomocno.UcitajString("Unesi naziv destinacije", 50, true, odabrani.Destinacija);
                        break;
                    case 4:
                        odabrani.Cijena = Pomocno.UcitajDecimalniBroj("Unesi naziv putovanja", 0,10000);
                        break;
                    case 5:
                        odabrani.Datum = Pomocno.UcitajDatum("Unesi datum putovanja", true);
                        break;
                    case 6:
                        odabrani.Popust = Pomocno.UcitajBool("Da li putovanje ima popust (DA/NE)", "da");
                        break;
                    case 7:
                        odabrani.DatumPromjene = DateTime.Now;
                        break;

                }
            }




        }

        public void PrikaziPutovanja()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Putovanja u aplikaciji");
            int rb = 0;
            foreach (var s in Putovanja)
            {
                Console.WriteLine(++rb + ". " + s.Naziv);
            }
            Console.WriteLine("****************************");
        }

        private void UnosNovogPutovanja()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Unesite tražene podatke o putovanju");
            Putovanja.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šifru putovanja", 1, int.MaxValue),
                Naziv = Pomocno.UcitajString("Unesi naziv putovanja", 50, true),
                Destinacija = Pomocno.UcitajString("Unesi naziv destinacije",50,true),
                Cijena = Pomocno.UcitajDecimalniBroj("Unesi cijenu putovanja", 0, 10000),
                Datum = Pomocno.UcitajDatum("Unesi datum od kada se izvodi putovanje", true),
                Popust = Pomocno.UcitajBool("Da li ima popust na putovanje (DA/NE)", "da"),
                DatumPromjene = DateTime.Now
            });
        }
    }
}
