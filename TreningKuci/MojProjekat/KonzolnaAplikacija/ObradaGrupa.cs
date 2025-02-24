using MojProjekat.KonzolnaAplikacija.Modeli;

namespace MojProjekat.KonzolnaAplikacija
{
    internal class ObradaGrupa
    {

        public List<Grupa> Grupe { get; set; }
        private Izbornik Izbornik;

        public ObradaGrupa()
        {
            Grupe = new List<Grupa>();

        }
        public ObradaGrupa(Izbornik izbornik) : this()
        {
            this.Izbornik = izbornik;
            Ucitajtestnepodatke();
        }

        private void Ucitajtestnepodatke()
        {
            var kupci = new List<Kupac>();
            kupci.Add(Izbornik.ObradaKupac.Kupci[0]);
            kupci.Add(Izbornik.ObradaKupac.Kupci[1]);
            Grupe.Add(new()
            {
                Naziv = "Grupa 1",
                Opis = "Opis grupe 1",
                Vodic = "Vodic 1",
                VelicinaGrupe = 10,
                Kupci = kupci
            });
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad s grupama");
            Console.WriteLine("1. Pregled svih grupa");
            Console.WriteLine("2. Unos nove grupe");
            Console.WriteLine("3. Promjena podataka postojeće grupe");
            Console.WriteLine("4. Brisanje grupe");
            Console.WriteLine("5. Brisanje kupaca iz grupe");
            Console.WriteLine("6. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziGrupe();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNoveGrupe();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjeniPodatkeGrupe();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiGrupu();
                    PrikaziIzbornik();
                    break;
                case 5:
                    ObrisiKupcaIzGrupe();
                    PrikaziIzbornik();
                    break;
                case 6:
                    Console.Clear();
                    break;
            }
        }

        private void ObrisiKupcaIzGrupe()
        {
            PrikaziGrupe();
            var g = Grupe[
                Pomocno.UcitajRasponBroja("Odaberi redni broj grupe na kojima ce se brisati kupci", 1, Grupe.Count) - 1
                ];

            Izbornik.ObradaKupac.PrikaziKupce(g.Kupci, "Popis kupaca u grupi");

            var odabrani = g.Kupci[
                Pomocno.UcitajRasponBroja("Odaberi redni broj kupaca za brisanje",
                1, g.Kupci.Count) - 1
                ];
            g.Kupci.Remove(odabrani);

        }

        private void ObrisiGrupu()
        {
            PrikaziGrupe();
            var g = Grupe[
                Pomocno.UcitajRasponBroja("Odaberi redni broj grupe za brisanje", 1, Grupe.Count) - 1
                ];
            if (Pomocno.UcitajBool("Sigurno obrisati " + g.Naziv + "? (DA/NE)", "da"))
            {
                Grupe.Remove(g);
            }
        }

        private void PromjeniPodatkeGrupe()
        {
            PrikaziGrupe();
            var g = Grupe[
                Pomocno.UcitajRasponBroja("Odaberi redni broj grupe za promjenu", 1, Grupe.Count) - 1
                ];
            // copy paste s linije 102 - izvući u metodu
            g.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru grupe", 1, int.MaxValue);
            g.Naziv = Pomocno.UcitajString("Unesi naziv grupe", 50, true);
            g.Opis = Pomocno.UcitajString("Unesi opis grupe", 150, true);
            g.Vodic = Pomocno.UcitajString("Unesi ime i prezime vodiča", 50, true);
            g.VelicinaGrupe = Pomocno.UcitajRasponBroja("Unesi Veličinu grupe", 1, 30);


            g.Kupci = UcitajKupce((int)g.VelicinaGrupe);


        }

        private void PrikaziGrupe()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Grupe u aplikaciji");
            int rb = 0, rbp;
            foreach (var g in Grupe)
            {
                Console.WriteLine(++rb + ". " + g.Naziv + " (" + g.Opis + "), " + g.Vodic + " kupaca"); // prepisati metodu toString
                rbp = 0;
                g.Kupci.Sort();
                foreach (var p in g.Kupci)
                {
                    Console.WriteLine("\t" + ++rbp + ". " + p.Ime + " " + p.Prezime);
                }
            }
            Console.WriteLine("****************************");
        }

        private void UnosNoveGrupe()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Unesite tražene podatke o grupi");

            Grupa g = new Grupa();
            g.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru grupe", 1, int.MaxValue);
            g.Naziv = Pomocno.UcitajString("Unesi naziv grupe", 50, true);
            g.Opis = Pomocno.UcitajString("Unesi opis grupe",150,true);
            g.Vodic = Pomocno.UcitajString("Unesi ime i prezime predavača", 50, true);
            g.VelicinaGrupe = Pomocno.UcitajRasponBroja("Unesi veličinu grupe", 1, 30);

            // polaznici
            g.Kupci = UcitajKupce((int)g.VelicinaGrupe);

            Grupe.Add(g);
        }

        private List<Kupac> UcitajKupce(int maksimalnoKupaca)
        {
            List<Kupac> lista = new List<Kupac>();
            while (lista.Count < maksimalnoKupaca && Pomocno.UcitajBool("Za unos kupca unesi DA", "da"))
            {
                Izbornik.ObradaKupac.PrikaziKupce();
                Console.WriteLine((Izbornik.ObradaKupac.Kupci.Count + 1) + ". Dodaj novog kupca");
                var odabranaOpcija = Pomocno.UcitajRasponBroja("Odaberi redni broj kupaca ili zadnji broj za dodavanje novog", 1,
                        Izbornik.ObradaKupac.Kupci.Count + 1);
                if (odabranaOpcija == Izbornik.ObradaKupac.Kupci.Count + 1)
                {
                    // ide novi
                    Izbornik.ObradaKupac.UnosNovogKupca();
                    lista.Add(Izbornik.ObradaKupac.Kupci.LastOrDefault());
                }
                else
                {
                    lista.Add(Izbornik.ObradaKupac.Kupci[odabranaOpcija - 1]);
                }

            }

            return lista;
        }
    }
}
    

        