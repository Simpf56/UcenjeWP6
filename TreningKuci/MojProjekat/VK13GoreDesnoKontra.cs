using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojProjekat
{
    internal class VK13GoreDesnoKontra
    {
        public static void VjezbaKuci()
        {
            Console.WriteLine("VK13");
            //int redovi = 3;
            //int stupci = 3;
            int redovi = UcitajBrojRedaka("Upiši broj redaka: ");
            int stupci = UcitajBrojStupaca("Upiši broj stupaca: ");
            int[,] tablica = new int[redovi, stupci];
            int vrijednost = 1;
            int max_vrijednost = redovi * stupci;

            int desnaGranica = stupci - 1;
            int donjaGranica = redovi - 1;
            int gornjaGranica = 0;
            int lijevaGranica = 0;


            while (vrijednost <= max_vrijednost)
            {
                //1.gore desno prema lijevo
                for (int stup = desnaGranica; stup >= lijevaGranica && vrijednost <= max_vrijednost; stup--)
                {
                    tablica[gornjaGranica, stup] = vrijednost++;
                }
                gornjaGranica++;
                //2.gore lijevo prema dolje
                for (int redak = gornjaGranica; redak <= donjaGranica && vrijednost <= max_vrijednost; redak++)
                {
                    tablica[redak, lijevaGranica] = vrijednost++;
                }
                lijevaGranica++;
                //3.dolje lijevo prema desno
                for (int stup = lijevaGranica; stup <= desnaGranica && vrijednost <= max_vrijednost; stup++)
                {
                    tablica[donjaGranica, stup] = vrijednost++;
                }
                donjaGranica--;
                //4.dolje desno prema gore
                for (int redak = donjaGranica; redak >= gornjaGranica && vrijednost <= max_vrijednost; redak--)
                {
                    tablica[redak, desnaGranica] = vrijednost++;
                }
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
        public static int UcitajBrojRedaka(string poruka)
        {
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    int broj = int.Parse(Console.ReadLine());
                    if (broj >= 3 && broj <= 20)
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
        //metoda za tocan broj stupaca
        public static int UcitajBrojStupaca(string poruka)
        {
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    int broj = int.Parse(Console.ReadLine());
                    if (broj >= 3 && broj <= 20)
                    {
                        return broj;
                    }
                    else
                    {
                        Console.WriteLine("Minimalan broj stupaca je 3, a maksimalan 20!");
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
