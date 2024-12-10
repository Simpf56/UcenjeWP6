using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07ForPetlja
    {

        public static void Izvedi()
        {
            //Console.WriteLine("E07");

            // 10 puta jedno ispod drugog ispišite Osijek
            // ovo je rješenje ali nije dobra praksa
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");

            // unaprijed
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}Osijek iz petlje",i);
            }
            // unazad
            for (int i = 10;i > 0; i--)
            {
                Console.WriteLine("{0}.Unazad",i);
            }

            //ugnježđena petlja
            for(int i = 1;i<= 10;i++)
            {
                for(int j = 1;j <= 10; j++)
                {
                    Console.Write("\t{0,3}",i * j); // Domaca zadaca formatirati desno, formatiro da se pomakne 3 mjesta desno
                 }
                Console.WriteLine();
            }

            int sum = 0;
            for(int i = 1;i<= 100; i++)
            {
                sum += i; // postojecoj sumi dajem vrijednost i
            }
            Console.WriteLine(sum);
            int x = 100;
            Console.WriteLine((x+1)*x/2);

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    if (i < 20)
                    {
                        //Console.WriteLine();
                        Console.Write("{0},", i);
                    }
                    else
                    {
                        Console.Write(i);
                    }
                }
            }                       // nema tocke nakon zareza

            Console.WriteLine();
            int idiOd = 12;
            int idiDo = 34;

            for(int i = idiOd; i <= idiDo; i++)
            {
                Console.WriteLine(i);
            }

            int[] brojevi = { 1, 2, 3, 3, 2, 3, 3, 3, 4, 3, 3};

            for(int i = 0;i < brojevi.Length; i++)
            {
                Console.Write(brojevi[i]);
            }
            Console.WriteLine();

            int[,] tablica = 
            {
                 { 1, 2, 3 },
                 { 4, 5, 6 },
                 { 6, 7, 8 },
            };


            for(int i = 0;i< tablica.GetLength(0); i++)
            {
                for(int j = 0;j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i,j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0;i < 10; i++)
            {
                if(i == 3)
                {
                    continue;
                }
                
                if(i == 7)
                {
                    break;
                }

                Console.WriteLine(i);
            }

            // dz  saznati kako prekinuti ugnježđenu petlju (iz najdublje vanjsku)

            bool izadji = false; // postavljajuci flag varijablu ili return na kraju

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
                for (int j = 0;j < 3; j++)
                {
                    
                        if (j == 2)
                        {
                            Console.WriteLine(j);
                            izadji = true;
                            break;
                        }
                 
                }
            }


            
            



                                

















        }

    }
}
