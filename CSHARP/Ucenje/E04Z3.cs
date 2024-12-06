using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04Z3
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E04Z3");

            Console.WriteLine("Unesi cijeli broj: ");
            int broj1 = int.Parse(Console.ReadLine());
            int broj2 = int.Parse(Console.ReadLine());

            if (broj1 < broj2)
            {
                Console.WriteLine(broj1);
            }
            else
            {
                Console.WriteLine(broj2);
            }

        }
    }
}
