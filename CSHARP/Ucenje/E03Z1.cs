using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
        // Program od korisnika unosi dva cijela broja
        // Program ispisuje u novim redovima
        // zbroj
        // razliku drugog i prvog
        // umnožak
        // zbroj kvadrata prvog i drugog broja
        // kvocijent prvog
{
    internal class E03Z1
    {
        public static void Izvodi()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a+b);
            Console.WriteLine(b - a);
            Console.WriteLine(a*b);
            Console.WriteLine((a*a)+(b*b));
            Console.WriteLine(a/(float) b);
            Console.WriteLine("Bravo");
        }
    }
}
