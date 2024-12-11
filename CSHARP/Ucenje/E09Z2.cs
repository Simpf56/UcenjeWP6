using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E09Z2
    {
        public static void Izvedi()
        {
            //Console.WriteLine("e0z2");

            int sum = 0,broj;
            while (true)
            {
                Console.WriteLine("Unesi broj: ");
                broj = int.Parse(Console.ReadLine());
                if (broj == -1)
                {
                     break;
                }
                sum = sum + broj;
            }          
                Console.WriteLine(sum);









        }
    }
}
