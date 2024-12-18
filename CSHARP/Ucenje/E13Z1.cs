using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Z1
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E13Z1");
            int broj = E12Metode.UcitajCijeliBroj("Unesi cijeli broj: ");
            while(broj < 0 || broj > 10)
            {
                Console.WriteLine("Broj mora biti između 1 i 9!");
                broj = E12Metode.UcitajCijeliBroj("Unesi cijeli broj: ");
            }
            Console.WriteLine("Rez je {0}", Faktorijel(broj));
        }


        private static int Faktorijel(int b)
        {
            if (b == 1)
            {
                return 1;
            }
            return b * Faktorijel(b - 1);

        }
        
    }
}
