using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojProjekat
{
    internal class VK5
    {
        public static void VjezbaKuci()
        {
            //Console.WriteLine("VK5");
            int redovi = UcitajBrojRedaka("Upiši broj redova: ");
            int stupci = UcitajBrojStupaca("Upiši broj stupaca: ");

            int[,] tablica = new int[redovi, stupci];

            int red = redovi - 1;
            int stup = stupci - 1;
            int vrijednost = 0;
            int max_vrijednost = redovi * stupci;

            Console.WriteLine();

            //dolje desno prema lijevo
            for (stup = stupci - 1; stup >= 0; stup--)
            {
                if (vrijednost == max_vrijednost) break;
                tablica[red, stup] = vrijednost++;
            }



            //(4,-1)
            //dolje lijevo prema gore red = 
            for(red = redovi - 2;red >= 0; red--)
            {
                if (vrijednost == max_vrijednost) break;
                tablica[red ,0] = vrijednost++;
            }



            //(-1,-1)
            //gore lijevo prema desno
            for(stup = 1;stup <= stupci-1; stup++)
            {
                if (vrijednost == max_vrijednost) break;
                tablica[0,stup] = vrijednost++;
            }
            

            //(-1,5)
            //gore desno prema dolje
            for(red = 1;red < redovi-1;red++)
            {
                if (vrijednost == max_vrijednost) break;
                tablica[red,stupci-1] = vrijednost++;
            }



            //(4,5)            
            //dolje desno prema lijevo
            for (stup = stupci -1; stup >= 2; stup--)
            {
                if (vrijednost == max_vrijednost) break;
                tablica[red - 1, stup - 1] = vrijednost++;
            }
            //(4,1)
            //dolje lijevo prema gore
            for (red = redovi -3;red >= 1; red--)
            {
                if (vrijednost == max_vrijednost) break;
                tablica[red,1] = vrijednost++;
            }



            //(0,1)
            //gore lijevo prema desno
            for (stup = 2;stup <= stupci - 2; stup++)
            {
                if (vrijednost == max_vrijednost) break;
                tablica[1, stup] = vrijednost++;
            }



            //(0,4)
            //gore desno prema dolje
            for (red = 1; red <= redovi-4; red++)
            {
                if (vrijednost == max_vrijednost) break;
                tablica[red+1, stup-1]= vrijednost++;
            }



            //(2,4)
            //dolje desno prema lijevo
            for (stup = stupci-2; stup >= 3; stup--)
            {
                if (vrijednost == max_vrijednost) break;
                tablica[red, stup - 1] = vrijednost++;
            }



            //(2,2)            
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i, j] + "\t");
                }
                Console.WriteLine();
            }






        }
        public static int UcitajBrojRedaka(string poruka)
        {
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    int broj = int.Parse(Console.ReadLine());
                    if(broj >= 3)
                    {
                        return broj;
                    }
                    else
                    {
                        Console.WriteLine("Minimalan broj redaka je 3!");
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                }
            }
        }
        public static int UcitajBrojStupaca(string poruka)
        {
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    int broj = int.Parse(Console.ReadLine());
                    if (broj >= 3)
                    {
                        return broj;
                    }
                    else
                    {
                        Console.WriteLine("Minimalan broj stupaca je 3!");
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
