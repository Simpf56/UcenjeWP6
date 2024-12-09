using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07Z1
    {
        public static void Izvedi()
        {
            //Console.WriteLine("Hello");
            Console.WriteLine("Unesi cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());

            //Console.WriteLine(broj);

            if(broj % 2 == 0)
            {
                int sum = 0;
                for(int i = 1; i <= broj; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
            }
            else
            {
                for( int i = 1; i <= broj; i++)
                {
                    if(i%2== 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

        }
    }
}
