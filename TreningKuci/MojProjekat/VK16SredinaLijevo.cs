using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojProjekat
{
    internal class VK16SredinaLijevo
    {
        public static void VjezbaKuci()
        {
            //Console.WriteLine("VK16");
            //int redovi = 3;
            //int stupci = 3;
            int redovi = UcitajBrojRedaka("Upiši broj redaka: ");
            int stupci = UcitajBrojStupaca("Upiši broj stupaca: ");
            int[,] tablica = new int[redovi, stupci];
            int vrijednost = 1;
            int max_vrijednost = redovi * stupci;

            int srednjiRed = redovi / 2;
            int srednjiStup = stupci / 2;

            int gornjaGranica = srednjiRed - 1;
            int donjaGranica = srednjiRed + 1;
            int lijevaGranica = srednjiStup - 1;
            int desnaGranica = srednjiStup + 1;


            
            for (;srednjiStup >= lijevaGranica && vrijednost <= max_vrijednost; srednjiStup--)
            {
                tablica[srednjiRed, srednjiStup] = vrijednost++;
            }
            lijevaGranica--;

            for(srednjiRed = donjaGranica;srednjiRed>= gornjaGranica && vrijednost <= max_vrijednost; srednjiRed--)
            {
                tablica[srednjiRed, srednjiStup] = vrijednost++;
            }

                // ispis tablice
                for (int redak = 0; redak < redovi; redak++)
            {
                for (int stup = 0; stup < stupci; stup++)
                {
                    Console.Write(string.Format("{0,4}", tablica[redak, stup]) + "\t");
                }
                Console.WriteLine();
            }

        }



        //metoda za tocan broj redaka
        private static int UcitajBrojRedaka(string poruka)
        {
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    int broj = int.Parse(Console.ReadLine());
                    if (broj >= 3 && broj <= 50)
                    {
                        return broj;
                    }
                    else
                    {
                        Console.WriteLine("Minimalan broj redaka je 3, a maksimalan 50!");
                    }

                }
                catch
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                }
            }
        }
        //metoda za tocan broj stupaca
        private static int UcitajBrojStupaca(string poruka)
        {
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    int broj = int.Parse(Console.ReadLine());
                    if (broj >= 3 && broj <= 50)
                    {
                        return broj;
                    }
                    else
                    {
                        Console.WriteLine("Minimalan broj stupaca je 3, a maksimalan 50!");
                    }

                }
                catch
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                }
            }
        }
        //metoda za broj početka
        private static int UcitajBrojPocetka(string poruka)
        {
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    int broj = int.Parse(Console.ReadLine());
                    if (broj >= 0)
                    {
                        return broj;
                    }
                    else
                    {
                        Console.WriteLine("Minimalan broj redaka je 3, a maksimalan 20!");
                    }

                }
                catch
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                }
            }
        }
    }
}