using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07ForPetlja
    {
        public static void Izvedi()
        {
            //Console.WriteLine("Hello");

            int sum = 0;
            for(int i = 1; i <= 100;  i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            int x = 100;
            Console.WriteLine((x+1)*x/2);

            // ispisi sve parne brojeve od 1 do 20

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    //Console.WriteLine(i); ispise svaki drugi broj
                    Console.Write("{0},",i);
                }
            }
            Console.WriteLine();
            int idiOd = 12;
            int idiDo = 34;

            for (int i = idiOd; i < idiDo; i++)
            {
                Console.WriteLine(i);
            }

            int[] brojevi = { 1, 5, 3, 6, 5, 6, 11, 8, 9, 12, 11, };

            //ispisati sve brojeve

            for (int i = 0; i < brojevi.Length; i++)
            {
                Console.WriteLine(brojevi[i]);
            }

            int[,] tablica =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 },
            };

            for (int i = 0;i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i,j]+ " ");
                }
                Console.WriteLine();
            }
            















        }   
    }
}
