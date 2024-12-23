using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojProjekat
{
    internal class VK7
    {
        public static void VjezbaKuci()
        {
            //Console.WriteLine("VK5");
            //int redovi = 5;
            //int stupci = 5;
            int redovi = UcitajBrojRedaka("Upiši broj redaka: ");
            int stupci = UcitajBrojStupaca("Upiši broj stupaca: ");

            int[,] tablica = new int[redovi, stupci];

            int vrijednost = 0;
            int max_vrijednost = redovi * stupci;

            int gornjaGranica = 0;
            int donjaGranica = redovi - 1;
            int lijevaGranica = 0;
            int desnaGranica = stupci - 1;


            while (vrijednost < max_vrijednost)
            {
                //1.dolje desno prema lijevo
                for (int stup = desnaGranica; stup >= lijevaGranica && vrijednost < max_vrijednost; stup--)
                {
                    tablica[donjaGranica, stup] = vrijednost++;
                }
                donjaGranica--;
                //2.dolje lijevo prema gore
                for (int redak = donjaGranica; redak >= gornjaGranica && vrijednost < max_vrijednost; redak--)
                {
                    tablica[redak, lijevaGranica] = vrijednost++;
                }
                lijevaGranica++;
                //3.gore lijevo prema desno
                for (int stup = lijevaGranica; stup <= desnaGranica && vrijednost < max_vrijednost; stup++)
                {
                    tablica[gornjaGranica, stup] = vrijednost++;
                }
                gornjaGranica++;
                //4.gore desno prema dolje
                for (int redak = gornjaGranica; redak <= donjaGranica && vrijednost < max_vrijednost; redak++)
                {
                    tablica[redak, desnaGranica] = vrijednost++;
                }
                desnaGranica--;
            }
            // ispis tablice
            for(int redak = 0; redak < redovi; redak++)
            {
                for(int stup = 0; stup < stupci; stup++)
                {
                    Console.Write(string.Format("{0,4}",tablica[redak,stup])+ "\t");
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