using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E14Vjezbanje
    {
        public static void Izvedi()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Dobrodošli u vježbanje petkom.");
            Console.ResetColor();
            Izbornik();
            Console.WriteLine("Hvala na korištenju, doviđenja!");

        }
        //ulaz broj: 32472365762357
        //128
        //15
        //6


        

        private static void Izbornik()
        {
            string[] programi = {
                "Parnost broja",
                "Tablica Množenja",
                "Jedinična vrijednost",
                "Broj znakova naziva mjesta",
                "Zbroj znamenki broj",
                "Prebrojavanje broja znakova"
            };

            Console.WriteLine();
            Console.WriteLine("IZBORNIK");

            for (int i = 0; i < programi.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i+1, programi[i]);
            }
            
            Console.WriteLine("0.Izlaz iz programa");
            OdabirOpcijeIzbornika(programi.Length);
        }

        private static void OdabirOpcijeIzbornika(int BrojPrograma)
        {
            switch(E12Metode.UcitajCijeliBroj("Odaberi stavku izbornika: ",0,BrojPrograma))
            {
                case 0:
                    break;
                case 1:
                    ParnostBroja();
                    Izbornik();
                    break;
                case 2:
                    TablicaMnozenja();
                    Izbornik();
                    break;
                case 3:
                    JedinicnaVrijednost();
                    Izbornik();
                    break;
                case 4:
                    BrojZnakovaNazivaMjesta();
                    Izbornik();
                    break;
                case 5:
                    ZbrojZnamenkiBroja();
                    break;
                case 6:
                    PrebrojavanjeBrojaZnakova();
                    break;
            }
        }

        private static void PrebrojavanjeBrojaZnakova()
        {
            NaslovPrograma("Prebrojavanje znakova u izrazu");

            string izraz = E12Metode.UcitajString("Unesi izraz: ").ToLower();

            //Danas pada snijeg --> vanjska petlja
            //Danas pada snijeg --> unutarnja petlja
            int[] niz = new int[izraz.Length];
            bool[] ispisi = new bool[izraz.Length];// njegove sve vrijednosti su false
            int b;
            for(int i = 0;i<izraz.Length;i++)
            {
                b = 0;
                foreach(char c in izraz)
                {
                    if (izraz[i] == c)
                    {
                        b++;
                    }
                }
                niz[i] = b;
                if (b > 1)
                {
                    for(int j = 0; j < izraz.Length; j++)
                    {
                        if (izraz[i] == izraz[j])
                        {
                            ispisi[j] = true;
                            break;
                        }
                    }
                }
                else
                {
                    ispisi[i] = true;
                }
            }
            //Console.WriteLine(string.Join(",", niz));
            for (int i = 0; i < izraz.Length; i++)
            {
                if (ispisi[i] && izraz[i] != ' ')
                {
                    Console.Write("{0}: ({1}) ", izraz[i], niz[i]);
                }
            }
        }

        private static void ZbrojZnamenkiBroja()
        {
            NaslovPrograma("Zbroj znamenki broja");
            string broj = E12Metode.UcitajString("Unesi cijeli broj: ");
            int manjiOd = E12Metode.UcitajCijeliBroj("Zbroj mora biti manji od: ");
            if (!provjeraBroja(broj))
            {
                Console.WriteLine("Nije dobar broj!");
                return;
            }

            int rez = int.MaxValue;
            while (rez > manjiOd)
            {
                rez = 0;//(int)BigInteger.Zero
                foreach (char c in broj)
                {
                    rez += int.Parse(c.ToString());
                }
                //Console.WriteLine(rez);
                broj = rez.ToString();
            }
            Console.WriteLine(rez);
            

        }

        
        
        


        private static bool provjeraBroja(string broj)
        {
            foreach (char z in broj)
            {
                try
                {
                    int.Parse(z.ToString());
                }
                catch 
                {
                    return false;                   
                }
            }
            return true;
        }

        private static void BrojZnakovaNazivaMjesta()
        {
            NaslovPrograma("Za uneseni naziv mjesta ispisuje koliko ima znakova");
            string ime = E12Metode.UcitajString("Unesi ime mjesta: ");
            Console.WriteLine(ime.Length);
            //Console.WriteLine(E12Metode.UcitajString("Unesi ime grada: ").Length);
        }

        private static void JedinicnaVrijednost()
        {
            NaslovPrograma("Program koji ispisuje jedinićnu vrijednost broja");
            int broj = E12Metode.UcitajCijeliBroj("Unesi cijeli broj između 20 i 50: ",20,50);
            int zadnjiBroj = broj % 10; // dobija vrijednost zadnjeg broja
            Console.WriteLine(zadnjiBroj);
        }

        private static void TablicaMnozenja()
        {
            NaslovPrograma("Program koji za dane brojeve redaka i stupaca generira tablicu množenja");
            int redaka = E12Metode.UcitajCijeliBroj("Unesi broj redaka: ", 2, 10);
            int stupaca = E12Metode.UcitajCijeliBroj("Unesi broj stupaca: ", 2, 10);

            for (int i = 1; i<= redaka; i++)
            {
                for (int j = 1; j <= stupaca; j++)
                {
                    Console.Write("{0,4}",i * j);
                }
                Console.WriteLine();
            }

        }

        private static void ParnostBroja()
        {
            NaslovPrograma("Program koji provjerava da li je uneseni broj paran ili ne");
            int broj = E12Metode.UcitajCijeliBroj("Unesi cijeli broj: ");
            if(broj % 2 == 0)
            {
                Console.WriteLine("Uneseni broj {0} je PARAN,",broj);
            }
            else
            {
                Console.WriteLine("Uneseni borj {0} je NEPARAN",broj);
            }            
        }
        private static void NaslovPrograma(string naslov)
        {
            //ispisati broj zvijezdica koliko ima i znakova u naslovu
            NaglasiNaslov(naslov.Length);
            Console.WriteLine(naslov);
            NaglasiNaslov(naslov.Length);
        }
        private static void NaglasiNaslov(int komada)
        {
            for(int i = 0;i<komada;i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

        }
    }
}
