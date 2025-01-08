using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojProjekat
{
    internal class Tester
    {
        public static void Izvedi()
        {
            //Console.WriteLine("VK16");
            //int redovi = 3;
            //int stupci = 3;
            int redovi = UcitajBrojRedaka("Upiši broj redaka: ");
            int stupci = UcitajBrojStupaca("Upiši broj stupaca: ");
            int[,] tablica = new int[redovi, stupci];
            int vrijednost = 1;
            int max_vrijednost = redovi * stupci;

            // Središnji početak
            int trenutniRed = redovi / 2;
            int trenutniStup = stupci / 2;

            // Granice
            int gornjaGranica = trenutniRed - 1;
            int donjaGranica = trenutniRed + 1;
            int lijevaGranica = trenutniStup - 1;
            int desnaGranica = trenutniStup + 1;

            while (vrijednost <= max_vrijednost)
            {
                // 1. Lijevo
                for (; trenutniStup >= lijevaGranica && vrijednost <= max_vrijednost; trenutniStup--)
                {                    
                    tablica[trenutniRed, trenutniStup] = vrijednost++;
                }
                trenutniStup++;
                donjaGranica--;

                // 2. Gore
                for (; trenutniRed >= gornjaGranica && vrijednost <= max_vrijednost; trenutniRed--)
                {                    
                    tablica[trenutniRed, trenutniStup] = vrijednost++;
                }
                trenutniRed++;
                lijevaGranica++;

                // 3. Desno
                for (; trenutniStup <= desnaGranica && vrijednost <= max_vrijednost; trenutniStup++)
                {                    
                    tablica[trenutniRed, trenutniStup] = vrijednost++;
                }
                trenutniStup--;
                gornjaGranica++;

                // 4. Dolje
                for (; trenutniRed <= donjaGranica && vrijednost <= max_vrijednost; trenutniRed++)
                {                    
                    tablica[trenutniRed, trenutniStup] = vrijednost++;
                }
                trenutniRed--;
                desnaGranica--;
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

