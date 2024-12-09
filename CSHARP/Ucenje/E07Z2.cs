using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07Z2
    {
        public static void Izvedi()
        {
            //Console.WriteLine("Hello There");

            Console.WriteLine("Unesi dva cijela broja: ");

            int broj1 = int.Parse(Console.ReadLine());
            int broj2 = int.Parse(Console.ReadLine());


            for (int i = ++broj1 ; i < broj2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
