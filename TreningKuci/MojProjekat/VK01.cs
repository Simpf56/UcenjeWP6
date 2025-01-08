using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojProjekat
{
    internal class VK01 {
        public static void VjezbaKuci()
        {
            int a = 2, b = 3;
            a = b-- + a; // 2 = 3-- + 2 ---------> a = 5 b = 2
            b += ++a; // 2 += ++5 -------> a = 5 b = 8
            Console.WriteLine(a + b); // 5 + 8 = 14

            int x = 5, y = 7;
            x = ++y - x; // 5 = ++7 - 5 ------> x = 3 y = 8
            y += x--; // 8 += 3-- ---------> x = 2 y = 11 
            Console.WriteLine(x + y); // 15

            int p = 4, q = 6;
            p = q++ - --p; // p = 3 q = 7
            q -= p++; // p = 4 q = 4
            Console.WriteLine(p + q); // 8

            int m = 10, n = 2;
            m = m-- + ++n; // m = 13 n = 3
            n -= --m; // m = 12 n = -9
            Console.WriteLine(m + n); // 3

            int c1 = 8, d1 = 2; 
            c1 = --d1 + c1++; //c1 = 9 d1 = 1 
            d1 += ++c1; //c1 = 10 d1 = 11
            Console.WriteLine(c1 + d1); //21

            int e1 = 4, f1 = 6; 
            e1 = f1++ - --e1; // e1 = 3 f1= 7
            f1 -= e1++; // e1 = 4 f1 = 4
            Console.WriteLine(e1 + f1); // 8



        }
    }
}
