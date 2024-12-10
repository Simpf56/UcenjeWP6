using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07DZ
    {
        public static void Izvedi()
        {
            //Console.WriteLine("Eo me!");ž

            Console.WriteLine("Broj redova: 5 ");
            int brojred1 = 5;
            Console.WriteLine("Broj stupaca: 5");
            int brojstup1 = 5;
            int[,] cTablica1 = new int[brojred1, brojstup1];

            for (int i = sum; i < brojred1; i++)
            {
                for(int j = 0; j < brojstup1; j++)
                {
                    cTablica1[i, j] = i * brojred1 + j;
                }
            }

            for (int i = 0; i < cTablica1.GetLength(0); i++)
            {
                for (int j = 0; j < cTablica1.GetLength(1); j++)
                {                 
                    Console.Write("\t" + cTablica1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Broj redova: 5 ");
            int brojred = 5;
            Console.WriteLine("Broj stupaca: 5");
            int brojstup = 5;
            int[,] cTablica = new int[brojred, brojstup];
            int broj4 = 1;
            int broj3 = 1;

            for (int i = 0; i < brojred; i++)
            {
                for (int j = 0; j < brojstup; j++)
                {
                    Console.Write("\t" + cTablica[i, j]);
                }
                Console.WriteLine();
            }

            for(int i = 0;i < brojstup; i++)
            {
                for (int j = 0; j < brojstup; j++)
                {
                    if (i == brojred && i == brojstup)
                    {
                        Console.Write( ++broj3);
                    }
                }
            }

            





















        }
    }
}
