using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MojProjekat
{
    internal class VK04
    {
        public static void VjezbaKuci()
        {


            //Console.WriteLine("VK4");

            Console.WriteLine("Upiši broj redova: ");
            int redovi = int.Parse(Console.ReadLine());
            Console.WriteLine("Upiši broj stupaca: ");
            int stupci = int.Parse(Console.ReadLine());

            //int redovi = 5;
            //int stupci = 5;
            int[,] tablica = new int[ redovi, stupci ];
            int stup = stupci -1;
            int red = redovi - 1;
            int vrijednost = 0;
            int max_vrijednost = redovi * stupci;

            Console.WriteLine();

            while (vrijednost < max_vrijednost )
            {

                // dolje desno prema lijevo
                for (stup = stupci - 1; stup >= 0; stup--)
                {
                    tablica[red, stup] = vrijednost++;
                }
                // dolje lijevo prema gore
                for (red = redovi - 2; red >= 0; red--)
                {
                    tablica[red, 0] = vrijednost++;
                }
                // gore lijevo prema desno
                for (stup = 1; stup < stupci; stup++)
                {
                    tablica[0, stup] = vrijednost++;
                }
                // gore desno prema dolje
                for (red = 1; red < redovi - 1; red++)
                {
                    tablica[red, stupci - 1] = vrijednost++;
                }
                // dolje desno -1 prema lijevo 
                for (stup = stupci - 2; stup >= 1; stup--)
                {
                    tablica[red - 1, stup] = vrijednost++;
                }
                // dolje lijevo -1 prema gore
                for (red = redovi - 3; red >= 1; red--)
                {
                    tablica[red, stup + 1] = vrijednost++;
                }
                // gore lijevo prema desno -2
                for (stup = 1; stup < stupci - 2; stup++)
                {
                    tablica[red + 1, stup + 1] = vrijednost++;
                }
                // gore desno prema dolje
                for (red = redovi - 3; red <= 2; red++)
                {
                    tablica[redovi / 2, stup] = vrijednost++;
                }
                // dolje desno prema lijevo
                for (stup = stupci / 2 + 1; stup <= stupci / 2 + 1; stup++)
                {
                    tablica[redovi / 2, stupci / 2] = vrijednost++;
                }
            }





            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i, j] + "\t");
                }
                Console.WriteLine();
            }





























        }
    }
}
