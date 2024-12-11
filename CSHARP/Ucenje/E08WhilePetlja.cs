using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E08WhilePetlja
    {
        public static void Izvedi()
        {
            //Console.WriteLine("Hello");



            int brojDo = 0;  // ovo unosi korisnik

            for(int i = 0; i < brojDo; i++)
            {
                Console.WriteLine(i);
            }

            // while radi s bool tipom podatka
            //beskonačna petlja
            while (true)
            {
                Console.WriteLine("Osijek");
                break;
            }

            int broj = 0, t = 2;


            while (broj < 10 && t == 2)
            {
                Console.WriteLine(++broj);
            }

            // while se ne mora ući
            broj = 10;
            while (broj < 10)
            {
                Console.WriteLine(++broj);
            }

            int sum = 0;
            broj = 1;
            while(broj <= 100)
            {
                sum += broj++;
            }
            Console.WriteLine(sum);


















        }
    }
}
