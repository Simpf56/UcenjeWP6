using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MojProjekat
{
    internal class VK4
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

            for (stup = stupci -1;stup >= 0; stup--)
            {
                tablica[red, stup] = vrijednost++;
            }

            for(red=redovi -2;red >= 0; red--)
            {
                tablica[red, 0] = vrijednost++;
            }

            for(stup = stupci/stupci;stup < stupci; stup++)
            {
                tablica[0, stup] = vrijednost++;
            }

            for (red = redovi / redovi; red < redovi -1; red++)
            {
                tablica[red, stupci-1] = vrijednost++;
            }

            for (stup = stupci / 2 + 1; stup >= 1; stup--)
            {
                tablica[red - 1, stup] = vrijednost++;
            }

            for(red = redovi-3;red >= 1;red--)
            {
                tablica[red,stup+1]= vrijednost++;
            }

            for (stup = 1; stup < 3; stup++)
            {
                tablica[red+1,stup+ 1] = vrijednost++;
            }
            
            for (red = redovi / 2; red == 2; red++)
            {
                tablica[redovi/2,stup] = vrijednost++;
            }

            for (stup = stupci / 2 + 1; stup == stupci / 2 + 1; stup++)
            {
                tablica[redovi/2,stupci/2] = vrijednost++;
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
