using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E12Metode
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E12");

            //metode se sastoje od dva dijela
            //1. Tijelo Metode
            //2. Poziv Metode

            //Tijelo metode
            //Tip 1: Ne prima parametre, ne vraća vrijednost

            // poziv metode
            Tip1();
            Tip1();

            Tip2(7);
            Tip2(5);
            Tip2(10, "Poziv druge varijante metode Tip2");

            int i = Tip3() + 1;
            Console.WriteLine(i);

            int[] niz = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            Console.WriteLine(Tip4(niz));

            
            

        }
            static void Tip1(/*Ovdje dođu parametri ili ne */) // void je oznaka ne vraća vrijednost
            {
                Console.WriteLine("Ispis iz 1. tipa metode");
                Console.WriteLine("*******************");
                Console.WriteLine("Kraj ispisa iz 1. tipa metode");
            }

            //Tip 2: Prima parametre ali ne vraća vrijednost

             private static void Tip2(int x)
            {
                for (int i= 0; i < x; i++)
                {
                    Console.WriteLine(i);
                }
            Console.WriteLine();
            }

            //potpis metode
            //naziv + lista parametara
            //Method overloading
            private static void Tip2(int x,string naslov)
        {
            Console.WriteLine(naslov);
            Tip2(x);
        }

        //Tip 3. Ne prima parametre ali vraća vrijednost

        private static int Tip3()
        {
            return int.MaxValue;// svaka metoda tipa koji nije void mora imati return
        }

        // Tip 4: Prima parametre i vraća vrijednost
        /// <summary>
        /// Metoda će za primljeni niz cijelih brojeva vratiti sumu
        /// </summary>
        /// <param name="niz">Niz cijelih brojeva</param>
        /// <returns>Suma primljenih brojeva</returns>
        private static int Tip4(int[]niz)
        {
            int suma = 0;
            foreach (int i in niz)
            {
                suma += 1;
            }
            return suma;

            
        }


        //NAMA BITNE METODE
        //Write once , use everywhere

        public static int UcitajCijeliBroj(string poruka)
        {
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Problem kod učitanja broja!");                    
                }
            }



            //return 0;  // kasnije obrisati sluzi da se ne pokazuje greška
        }



    }
}
