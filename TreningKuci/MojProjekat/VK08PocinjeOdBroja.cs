using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MojProjekat
{
    internal class VK08PocinjeOdBroja
    {
        public static void VjezbaKuci()
        {
            //Console.WriteLine("VK8");
            //int redovi = 5;
            //int stupci = 5;
            int redovi = UcitajBrojRedaka("Upiši broj redaka: ");
            int stupci = UcitajBrojStupaca("Upiši broj stupaca: ");
            int pocetniBroj = UcitajBrojPocetka("Od kojeg broja želiš početi? ");
            int[,] tablica = new int[redovi, stupci];
            int vrijednost = pocetniBroj;
            int max_vrijednost = pocetniBroj + (redovi * stupci) -1;

            int desnaGranica = stupci - 1;
            int donjaGranica = redovi - 1;
            int gornjaGranica = 0;
            int lijevaGranica = 0;
            
            

            while (vrijednost <= max_vrijednost)
            {
                //1.dolje desno prema lijevo
                for (int stup = desnaGranica; stup >= lijevaGranica; stup--)
                {
                    if (vrijednost > max_vrijednost) break;
                    tablica[donjaGranica, stup] = vrijednost++;
                    
                }
                if (vrijednost > max_vrijednost) break;
                donjaGranica--;
                //2.dolje lijevo prema gore
                for (int redak = donjaGranica; redak >= gornjaGranica; redak--)
                {
                    if (vrijednost > max_vrijednost) break;
                    tablica[redak, lijevaGranica] = vrijednost++;
                    
                }
                if (vrijednost > max_vrijednost) break;
                lijevaGranica++;
                //3.gore lijevo prema desno
                for (int stup = lijevaGranica; stup <= desnaGranica; stup++)
                {
                    if (vrijednost > max_vrijednost) break;
                    tablica[gornjaGranica, stup] = vrijednost++;
                    
                }
                if (vrijednost > max_vrijednost) break;
                gornjaGranica++;
                //4.gore desno prema dolje
                for (int redak = gornjaGranica; redak <= donjaGranica; redak++)
                {
                    if (vrijednost > max_vrijednost) break;
                    tablica[redak, desnaGranica] = vrijednost++;
                    
                }
                if (vrijednost > max_vrijednost) break;
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
        //metoda za broj redaka
        private static int UcitajBrojRedaka(string poruka)
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
        private static int UcitajBrojStupaca(string poruka)
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
