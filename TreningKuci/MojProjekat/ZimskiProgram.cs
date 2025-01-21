using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MojProjekat
{
    internal class ZimskiProgram
    {
        public static void Izvedi()
        {
            Console.WriteLine("Program");
            Izbornik();
        }
        private static void Izbornik()
        {

            string[] programi = {
            "Površina pravokutnika",
            "Provjera broja",
            "Zbroj Elemenata niza",
            "Prosjek ocjena",
            "Ispis Fibonaccijeva niza",
            "Preokret Stringa",
            "Brojanje samoglasnika",
            "Pretvorba temperature",
            "Sortiranje niza",
            "Kalkulator",
            "Generator Lozinke",
            "Kalkulator ljubavi"
            };

            Console.WriteLine();
            Console.WriteLine("IZBORNIK");

            for (int i = 0; i < programi.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, programi[i]);
            }

            Console.WriteLine("0. Izlaz iz programa");
            OdabirOpcijeIzbornika(programi.Length);
        }
        private static void OdabirOpcijeIzbornika(int brojPrograma)
        {
            switch (UcitajCijeliBroj("Odaberi stavku izbornika: ", 0, brojPrograma))
            {
                case 0:
                    break;
                case 1:
                    PovrsinaPravokutnika();
                    Izbornik();
                    break;
                case 2:
                    ProvjeraBroja();
                    Izbornik();
                    break;
                case 3:
                    ZbrojElementaNiza();
                    Izbornik();
                    break;
                case 4:
                    ProsjekOcijena();
                    Izbornik();
                    break;
                case 5:
                    IspisFibNiza();
                    Izbornik();
                    break;
                case 6:
                    PreokretStringa();
                    Izbornik();
                    break;
                case 7:
                    BrojanjeSamoglasnika();
                    Izbornik();
                    break;
                case 8:
                    PretvorbaTemp();
                    Izbornik();
                    break;
                case 9:
                    SortiranjeNiza();
                    Izbornik();
                    break;
                case 10:
                    Kalkulator();
                    Izbornik();
                    break;
                case 11:
                    GeneratorLozinke();
                    Izbornik();
                    break;
                case 12:
                    KalkulatorLjubavi();
                    Izbornik();
                    break;
            }
        }

        private static void KalkulatorLjubavi()
        {
            NaslovPrograma("Program koji za dva upisana imena izbacuje postotak kompatibilnosti.");


            string prvoIme = UcitajRijec("Upiši prvo ime: ");
            string drugoIme = UcitajRijec("Upiši drugo ime: ");
            string zajedno = string.Join("", prvoIme, drugoIme).ToLower();

            int[] niz = new int[zajedno.Length];
            bool[] ispisano = new bool[zajedno.Length]; // pocinje sa false na svim vrijednostima
            int b;

            for (int i = 0; i < zajedno.Length; i++)
            {
                b = 0;
                foreach (char c in zajedno)
                {
                    if (zajedno[i] == c)
                    {
                        b++;
                    }
                }
                niz[i] = b;
            }

            for (int i = 0; i < zajedno.Length; i++)
            {
                Console.WriteLine("{0}: {1}", zajedno[i], niz[i]);
            }

            int[] prviNiz = new int[zajedno.Length - drugoIme.Length];
            int[] drugiNiz = new int[zajedno.Length - prvoIme.Length];

            for (int i = 0; i < zajedno.Length; i++)
            {
                if (i < prviNiz.Length)
                {
                    prviNiz[i] = niz[i];
                }
                else
                {
                    drugiNiz[i - prviNiz.Length] = niz[i];
                }
            }

            Console.WriteLine("\nPrvi niz:");
            foreach (int broj in prviNiz)
            {
                Console.Write(broj + " ");
            }
            Console.WriteLine("\nDrugi niz:");
            foreach (int broj in drugiNiz)
            {
                Console.Write(broj + " ");
            }

            int duljina = (prviNiz.Length > drugiNiz.Length) ? prviNiz.Length : drugiNiz.Length;
            int minDuljina = (prviNiz.Length < drugiNiz.Length) ? prviNiz.Length : drugiNiz.Length; 

            int[]rezultat = new int[duljina];

            for(int i = 0; i < minDuljina; i++)
            {
                rezultat[i] = prviNiz[i] + drugiNiz[drugiNiz.Length - 1 - i];
            }

            if (prviNiz.Length > minDuljina)
            {
                for (int i = minDuljina; i < prviNiz.Length; i++)
                {
                    rezultat[i] = prviNiz[i];
                }
            }
            else if (drugiNiz.Length > minDuljina)
            {
                for (int i = minDuljina; i < drugiNiz.Length; i++)
                {
                    rezultat[i] = drugiNiz[drugiNiz.Length - 1 - i];
                }
            }
            Console.WriteLine(); // prva kalkulacija ujedno pretvara dva niza u jedan int[]rezultat
            for(int i = 0;i < rezultat.Length; i++)
            {
                Console.Write(rezultat[i]);
            }
        }

        private static void GeneratorLozinke()
        {
            NaslovPrograma("Program koji ispisuje lozinku/e po specifikacijama korisnika.");


            string odgovor;
            do
            {
                const string malaSlova = "abcdefghijklmnopqrstuvwxyz";
                const string velikaSlova = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                const string brojevi = "0123456789";
                const string znakovi = "!@#$%^&*()_+-=[]{}|;:'\",.<>?/";
                bool prvoBroj = false;
                bool prvoZnak = false;
                bool zadnjiBroj = false;
                bool zadnjiZnak = false;

                int LozinkaDuzina = UcitajCijeliBroj("Unesite dužinu lozinke: ", 3, 100);

                char[] Lozinka = new char[LozinkaDuzina];
                string LozinkaSadrzi = "";
                string odgovorDaNe = UcitajDaIliNe("Da li želite mala slova u lozinki?");

                if (odgovorDaNe.ToUpper() == "DA")
                {
                    LozinkaSadrzi += malaSlova;
                }


                odgovorDaNe = UcitajDaIliNe("Da li želite velika slova u lozinki?");

                if (odgovorDaNe.ToUpper() == "DA")
                {
                    LozinkaSadrzi += velikaSlova;
                }


                odgovorDaNe = UcitajDaIliNe("Da li želite brojeve u lozinki?");

                if (odgovorDaNe.ToUpper() == "DA")
                {
                    LozinkaSadrzi += brojevi;
                }


                odgovorDaNe = UcitajDaIliNe("Da li želite interpunkcijske znakove u lozinki?");

                if (odgovorDaNe.ToUpper() == "DA")
                {
                    LozinkaSadrzi += znakovi;
                }


                odgovorDaNe = UcitajDaIliNe("Da li želite lozinika započne sa brojem?");
                if (odgovorDaNe.ToUpper() == "DA")
                {
                    prvoBroj = true;
                }


                odgovorDaNe = UcitajDaIliNe("Da li želite lozinika započne sa interpunkcijskim znakom?");
                if (odgovorDaNe.ToUpper() == "DA")
                {
                    prvoZnak = true;
                    prvoBroj = false;
                }


                odgovorDaNe = UcitajDaIliNe("Da li želite lozinika završi sa brojem?");
                if (odgovorDaNe.ToUpper() == "DA")
                {
                    zadnjiBroj = true;
                }

                odgovorDaNe = UcitajDaIliNe("Da li želite lozinika završi sa interpunkcijskim znakom?");
                if (odgovorDaNe.ToUpper() == "DA")
                {
                    zadnjiZnak = true;
                    zadnjiBroj=false;
                }

                int brojLozinki = UcitajCijeliBroj("Koliko lozinki želite (Max 20): ", 1, 20);

                Random random = new Random();

                for (int j = 0; j < brojLozinki; j++)
                {

                    Lozinka = new char[LozinkaDuzina];


                    for (int i = 0; i < Lozinka.Length; i++)
                    {
                        Lozinka[i] = LozinkaSadrzi[random.Next(LozinkaSadrzi.Length)];
                    }


                    if (prvoBroj && brojevi.Length > 0)
                    {
                        Lozinka[0] = brojevi[random.Next(brojevi.Length)];
                    }
                    else if (prvoZnak && znakovi.Length > 0)
                    {
                        Lozinka[0] = znakovi[random.Next(znakovi.Length)];
                    }

                    if (zadnjiBroj && brojevi.Length > 0)
                    {
                        Lozinka[Lozinka.Length - 1] = brojevi[random.Next(brojevi.Length)];
                    }
                    else if (zadnjiZnak && znakovi.Length > 0)
                    {
                        Lozinka[Lozinka.Length - 1] = znakovi[random.Next(znakovi.Length)];
                    }


                    Console.WriteLine($"Generirana lozinka {j + 1}: " + new string(Lozinka));
                }

                Console.WriteLine();
                odgovor = Ponavljanja();
            } while (odgovor == "DA");
        }



    private static void Kalkulator()
        {
            string odgovor;
            NaslovPrograma("Program koji daje 4 opcije za računanje.");

            do
            {
                double broj1 = UcitajDoubleBroj("Upiši prvi broj ", double.MinValue, double.MaxValue);
                double broj2 = UcitajDoubleBroj("Upiši drugi broj ", double.MinValue, double.MaxValue);

                string znak = UcitajZnak("Odaberi opciju: ");
                double rezultat;

                if (znak == "+")
                {
                    rezultat = broj1 + broj2;
                    Console.WriteLine("Rezultat je : {0:F2}", rezultat);
                }
                if (znak == "-")
                {
                    rezultat = broj1 - broj2;
                    Console.WriteLine("Rezultat je : {0:F2}", rezultat);
                }
                if (znak == "*")
                {
                    rezultat = broj1 * broj2;
                    Console.WriteLine("Rezultat je : {0:F2}", rezultat);
                }
                if (znak == "/")
                {
                    rezultat = broj1 / broj2;
                    Console.WriteLine("Rezultat je : {0:F2}", rezultat);
                }
                Console.WriteLine();
                odgovor = Ponavljanja();
            } while (odgovor == "DA");
        }

        private static void SortiranjeNiza()
        {
            string odgovor;
            NaslovPrograma("Program koji sortira niz upisanih brojeva.");

            do
            {
                int brojevi = UcitajCijeliBroj("Upiši dužinu niza: ", int.MinValue, int.MaxValue);
                int[] niz = new int[brojevi];

                Console.WriteLine("Unesi brojeve: ");
                for (int i = 0; i < niz.Length; i++)
                {
                    niz[i] = UcitajCijeliBroj("Dodaj broj: ", -100, 100);
                }

                SortirajNiz(niz);

                foreach (int broj in niz)
                {
                    Console.Write(broj + " ");
                }
                Console.WriteLine();
                odgovor = Ponavljanja();
            } while (odgovor == "DA");
        }

        private static void SortirajNiz(int[] niz)
        {
            int trenutniBr;

            for (int i = 0; i < niz.Length; i++)
            {
                for (int j = 0; j < niz.Length - i - 1; j++)
                {
                    if (niz[j] > niz[j + 1])
                    {
                        trenutniBr = niz[j];
                        niz[j] = niz[j + 1];
                        niz[j + 1] = trenutniBr;
                    }
                }
            }
        }

        private static void PretvorbaTemp()
        {
            string odgovor;
            NaslovPrograma("Program koji za unesenu temperaturu u Celziusima mjenja u Fahrenheite i obrnuto ");

            do
            {
                switch (UcitajCijeliBroj("Odaberi koju temperaturu želiš promijeniti(0 za °C u °F, 1 za °F u °C): ", 0, 1))
                {
                    case 0:
                        double celz = UcitajDoubleBroj("Unesi temperaturu u Celzijusima: ", -50, 110);
                        double fahrenheit = CelzToFarenheit(celz);
                        Console.WriteLine("Temperatura u Fahrenheitu: {0:F2}°F", fahrenheit);
                        break;
                    case 1:
                        double fahr = UcitajDoubleBroj("Unesi temperaturu u Fahrenheitima: ", -50, 230);
                        double celzijus = FahrenheitToCelz(fahr);
                        Console.WriteLine("Temperatura u Celzijusima: {0:F2}°C", celzijus);
                        break;
                }
                odgovor = Ponavljanja();

            } while (odgovor == "DA");
        }

        private static double FahrenheitToCelz(double temperatura)
        {
            return (temperatura - 32) * 5 / 9;
        }

        private static double CelzToFarenheit(double temperatura)
        {
            return (temperatura * 9 / 5) + 32;
        }

        private static void BrojanjeSamoglasnika()
        {
            string odgovor;
            NaslovPrograma("Program koji ispisuje broj samoglasnika u stringu");

            do
            {

                string unos = UcitajString("Upiši izraz : ").ToUpper();
                char[] izraz = unos.ToCharArray();
                int samoglasnici = 0;
                foreach (char slovo in izraz)
                {
                    if (slovo == 'A' || slovo == 'E' || slovo == 'I' || slovo == 'O' || slovo == 'U')
                    {
                        samoglasnici++;
                    }

                }
                Console.WriteLine("Broj samoglasnika je: {0}.", samoglasnici);

                odgovor = Ponavljanja();

            } while (odgovor == "DA");

        }

        private static void PreokretStringa()
        {
            string odgovor;
            NaslovPrograma("Program koji ispisuje napisani string otpozadi.");
            do
            {
                string izraz = UcitajString("Upiši izraz: ");

                for (int i = izraz.Length - 1; i >= 0; i--)
                {
                    Console.Write(izraz[i]);
                }
                Console.WriteLine();
                odgovor = Ponavljanja();
            } while (odgovor == "DA");
        }

        private static void IspisFibNiza()
        {
            string odgovor;
            NaslovPrograma("Program koji ispisuje Fibonnacijev niz do zadanog N broja.");
            do
            {
                int broj = UcitajCijeliBroj("Upiši broj: ", 1, 50);
                int a = 0;
                int b = 1;

                for (int i = 1; i < broj; i++)
                {
                    Console.WriteLine(a);
                    int sljedeci = a + b;
                    a = b;
                    b = sljedeci;
                }
                odgovor = Ponavljanja();
            } while (odgovor == "DA");

        }

        private static void ProsjekOcijena()
        {
            int skupOcjena = CijeliBroj("Upiši broj predmeta? : ");
            int[] ocjene = new int[skupOcjena];

            for (int i = 0; i < skupOcjena; i++)
            {
                bool ispravanUnos = false;
                while (!ispravanUnos)
                {

                    Console.Write($"Upiši ocijenu {i + 1}: ");
                    string unos = Console.ReadLine();
                    try
                    {
                        int ocjena = int.Parse(unos);
                        if (ocjena >= 1 && ocjena <= 5)
                        {
                            ocjene[i] = ocjena;
                            ispravanUnos = true;
                        }
                        else
                        {
                            Console.WriteLine("Ocjena mora biti između 1 i 5.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Unos nije cijeli broj.");
                    }
                }
            }
            int sumaOcjena = 0;
            foreach (int ocjena in ocjene)
            {
                sumaOcjena += ocjena;
            }


            double prosjek = (double)sumaOcjena / skupOcjena;

            Console.WriteLine($"Prosjek tvojih ocjena je {prosjek:F2}");


        }

        private static void ZbrojElementaNiza()
        {
            NaslovPrograma("Program koji zbraja sve upisane brojeve.");
            string odgovor;

            int velicinaNiza = CijeliBroj("Koliko brojeva želiš unijeti? ");
            int[] brojevi = new int[velicinaNiza];

            for (int i = 0; i < velicinaNiza; i++)
            {
                bool ispravanUnos = false;
                while (!ispravanUnos)
                {

                    Console.Write($"Upiši broj {i + 1}: ");
                    string unos = Console.ReadLine();
                    try
                    {
                        brojevi[i] = int.Parse(unos);
                        ispravanUnos = true;
                    }
                    catch
                    {
                        Console.WriteLine("Unos nije cijeli broj.");
                    }
                }
            }

            int suma = 0;
            foreach (int broj in brojevi)
            {
                suma += broj;
            }
            Console.WriteLine($"Suma unesenih brojeva je: {suma}");



        }
        private static void ProvjeraBroja()
        {
            NaslovPrograma("Program koji provjerava da li je broj pozitivan,negativan ili 0.");

            string odgovor;
            do
            {

                int broj = CijeliBroj("Upiši broj: ");
                if (broj < 0)
                {
                    Console.WriteLine("Broj je negativan.");
                }
                else if (broj > 0)
                {
                    Console.WriteLine("Broj je pozitivan.");
                }
                else
                {
                    Console.WriteLine("Broj je 0");
                }
                odgovor = Ponavljanja();
            } while (odgovor == "DA");
        }
        private static void PovrsinaPravokutnika()
        {
            NaslovPrograma("Program koji vrši izračun površine pravokutnika.");
            string odgovor;
            do
            {
                int duzinaA = CijeliBroj("Upiši dužinu stranice A pravokutnika: ");
                int duzinaB = CijeliBroj("Upiši dužinu stranice B pravokutnika: ");
                Console.WriteLine();
                Console.WriteLine("Površina vašeg pravokutnika je {0} cm².", (duzinaA * duzinaB));

                odgovor = Ponavljanja();
            } while (odgovor == "DA");
        }

        private static void NaslovPrograma(string naslov)
        {
            NaglasiNaslov(naslov.Length);
            Console.WriteLine(naslov);
            NaglasiNaslov(naslov.Length);
        }

        private static void NaglasiNaslov(int komada)
        {
            for (int i = 0; i < komada; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        private static int CijeliBroj()
        {
            while (true)
            {
                try
                {
                    int broj = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("To nije cijeli broj.");
                }
            }
        }
        private static int CijeliBroj(string poruka = "")
        {
            int broj;

            // Ispiši poruku ako postoji
            if (!string.IsNullOrEmpty(poruka))
            {
                Console.WriteLine(poruka);
            }

            // Petlja dok unos nije valjan cijeli broj
            while (!int.TryParse(Console.ReadLine()?.Trim(), out broj))
            {
                Console.WriteLine("Neispravan unos. Pokušajte ponovno:");
            }

            return broj; // Vraća valjan broj
        }
        private static int UcitajCijeliBroj(string poruka, int min, int max)
        {
            int i;
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    i = int.Parse(Console.ReadLine());
                    if (i < min || i > max)
                    {
                        Console.WriteLine("Broj nije u danom rasponu {0} - {1}", min, max);
                        continue;
                    }
                    return i;
                }
                catch
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                }
            }
        }
        private static int UcitajCijeliBrojL(string poruka, int min, int max)
        {
            int i;
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    i = int.Parse(Console.ReadLine());
                    if (i < min)
                    {
                        Console.WriteLine("Lozinka mora sadržavati minimalno 8 znamenki!");
                        continue;
                    }
                    if (i > max)
                    {
                        Console.WriteLine("Lozinka nemože sadržavati više od 20 znamkenki!");
                        continue;
                    }
                    return i;
                }
                catch
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                }
            }
        }
        private static string Ponavljanja()
        {
            string odgovor;
            do
            {
                Console.WriteLine("Želiš li probati opet? (DA/NE)");
                odgovor = Console.ReadLine().ToUpper();

                if (odgovor != "DA" && odgovor != "NE")
                {
                    Console.WriteLine("To nije opcija.");
                }
            } while (odgovor != "DA" && odgovor != "NE");

            return odgovor;
        }
        private static string UcitajString(string poruka)
        {
            string s = "";
            while (true)
            {
                Console.Write(poruka);
                s = Console.ReadLine().Trim();
                if (s.Length == 0)
                {
                    Console.WriteLine("Obavezan unos");
                    continue;
                }
                return s;
            }
        }

        private static string UcitajRijec(string poruka)
        {
            string z = "";
            string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            while (true)
            {
                Console.Write(poruka);
                z = Console.ReadLine().Trim();

                if (z.Length == 0)
                {
                    Console.WriteLine("Obavezan unos");
                    continue;
                }

                bool ispravnaRijec = true;

                foreach (char c in z)
                {
                    bool znakIspravan = false;
                    
                    for (int i = 0; i < abc.Length; i++)
                    {
                        if (c == abc[i])
                        {
                            znakIspravan = true;
                            break;
                        }
                    }                    
                    if (!znakIspravan)
                    {
                        ispravnaRijec = false;
                        break;
                    }
                }

                if (ispravnaRijec)
                {
                    return z;
                }
                else
                {
                    Console.WriteLine("To nije riječ. Unesite samo slova.");
                }
            }
        }

        private static string UcitajDaIliNe(string poruka)
        {
            string unos;
            while (true)
            {
                Console.WriteLine(poruka);
                unos = Console.ReadLine()?.Trim().ToUpper();

                if (unos == "DA" || unos == "NE")
                {
                    return unos;
                }
                else
                {
                    Console.WriteLine("Neispravan unos. Molimo unesite 'DA' ili 'NE'.");
                }
            }
        }
        private static double UcitajDoubleBroj(string poruka, double min, double max)
        {
            double i;
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    i = double.Parse(Console.ReadLine());
                    if (i < min || i > max)
                    {
                        Console.WriteLine("Broj nije u danom rasponu {0} - {1}", min, max);
                        continue;
                    }
                    return i;
                }
                catch
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                }
            }
        }
        private static string UcitajZnak(string poruka)
        {
            string unos;
            while(true){
                Console.WriteLine(poruka);

                unos = Console.ReadLine();
                if (unos == "+" || unos == "-" || unos == "*" || unos == "/")
                {
                    return unos;
                }
                else
                {
                    Console.WriteLine("To nije opcija.");
                }
            }
                       
            
        }
    }
}
