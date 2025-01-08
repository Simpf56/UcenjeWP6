using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
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
            "Kalkulator"
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
            }
        }

        private static void Kalkulator()
        {
            throw new NotImplementedException();
        }

        private static void SortiranjeNiza()
        {
            throw new NotImplementedException();
        }

        private static void PretvorbaTemp()
        {
            throw new NotImplementedException();
        }

        private static void BrojanjeSamoglasnika()
        {
            throw new NotImplementedException();
        }

        private static void PreokretStringa()
        {
            NaslovPrograma("Program koji ispisuje napisani izraz odpozadi.");
            string izraz = UcitajString("Upiši izraz: ");

            for (int i = izraz.Length -1; i >= 0; i--)
            {
                Console.Write(izraz[i]);
            }          
        }

        private static void IspisFibNiza()
        {
            string odgovor;
            NaslovPrograma("Program koji ispisuje Fibonnacijev niz do zadanog N broja.");
            do
            {
                int broj = UcitajCijeliBroj("Upiši broj: ",1,50);
                int a = 0;
                int b = 1;

                for (int i = 1; i < broj; i++)
                {
                    Console.WriteLine(a);
                    int sljedeci = a + b;
                    a = b;
                    b = sljedeci;
                }
                do
                {
                    Console.WriteLine("Želiš li probati opet? (DA/NE)");
                    odgovor = Console.ReadLine().ToUpper();
                    if (odgovor != "DA" && odgovor != "NE")
                    {
                        Console.WriteLine("To nije opcija.");
                    }
                } while (odgovor != "DA" && odgovor != "NE");
            } while (odgovor == "DA");

        }

        private static void ProsjekOcijena()
        {
            int skupOcjena = CijeliBroj("Upiši broj predmeta? : ");
            int[] ocjene = new int[skupOcjena];
            
            for (int i = 0;i < skupOcjena; i++)
            {
                bool ispravanUnos = false;
                while (!ispravanUnos)
                {

                    Console.Write($"Upiši ocijenu {i + 1}: ");
                    string unos = Console.ReadLine();
                    try
                    {
                       int ocjena = int.Parse(unos);
                        if(ocjena >= 1 &&  ocjena <= 5)
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
            foreach(int ocjena in ocjene)
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
                do
                {
                    Console.WriteLine("Želiš li probati opet? (DA/NE)");
                    odgovor = Console.ReadLine().ToUpper();
                    if (odgovor != "DA" && odgovor != "NE")
                    {
                        Console.WriteLine("To nije opcija.");
                    }
                } while (odgovor != "DA" && odgovor != "NE");
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
                do
                {
                    Console.WriteLine("Želiš li probati opet? (DA/NE)");
                    odgovor = Console.ReadLine().ToUpper();
                    if (odgovor != "DA" && odgovor != "NE")
                    {
                        Console.WriteLine("To nije opcija.");
                    }
                } while (odgovor != "DA" && odgovor != "NE");
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
        private static string PitanjePonavljanja()
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

            // return "";
        }
    }
}
