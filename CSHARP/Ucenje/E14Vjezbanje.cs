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
            Console.WriteLine("Dobrodošli u vježbanje petkom.");
            Izbornik();
            Console.WriteLine("Hvala na korištenju, doviđenja!");




        }
        private static void Izbornik()
        {
            Console.WriteLine();
            Console.WriteLine("IZBORNIK");
            Console.WriteLine("1. Parnost broja");
            Console.WriteLine("2. Tablica množenja");
            Console.WriteLine("0.Izlaz iz programa");
            OdabirOpcijeIzbornika();
        }

        private static void OdabirOpcijeIzbornika()
        {
            switch(E12Metode.UcitajCijeliBroj("Odaberi stavku izbornika: ",0,2))
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
                
            }
        }

        private static void TablicaMnozenja()
        {
            NaslovPrograma("Program koji za dane brojeve redaka i stupaca generira tablicu množenja");
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
            Zvijezdice(naslov.Length);
            Console.WriteLine(naslov);
            Zvijezdice(naslov.Length);
        }
        private static void Zvijezdice(int komada)
        {
            for(int i = 0;i<komada;i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

        }
    }
}
