﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MojProjekat
{
    internal class VK02
    {
        public static void VjezbaKuci()
        {
            //Console.WriteLine("Hello There");

            int i = 1;
            bool uvjet = i > 0;

            if (uvjet)
            {
                Console.WriteLine("veće od 0");
            }

            if (i > 0)
            {
                Console.WriteLine("veće od 0");
            }

            if (uvjet)
            {
                Console.WriteLine("veće od 0");
            }
            else
            {
                Console.WriteLine("NIJE veće od 0");
            }

            if (uvjet)
            {
                Console.WriteLine("Veće od 0");
            }
            else if (i== -1)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine("Nije veće od 0");
            }

            
            if (i > 0)
            {
                int p = -2;
                if (p < 0)
                {
                    Console.WriteLine("Osijek");
                }
            }

            if (i > 0)
            {
                Console.WriteLine("veće od 0");                
            }
            else
            {
                Console.WriteLine("NIJE veće od 0");
            }

            Console.WriteLine(i > 0 ? "veće od 0" : "NIJE veće od 0");

            int x = 1, y = 0;

            if (x != 1 & y > 0)
            {
                Console.WriteLine("Osijek");
            }

            if (x != 1 && y > 0)
            {
                Console.WriteLine("Osijek");
            }

            if (x == 1 | y == 0)
            {
                Console.WriteLine("Osijek");
            }

            if (x == 1 || y== 0)
            {
                Console.WriteLine("Osijek");
            }

            int ocjena = 3;

            switch (ocjena)
            {
                case 1:
                    Console.WriteLine("Nedovoljan");
                    break;
                case 2:
                    Console.WriteLine("Dovoljan");
                    break;
                case 3:
                    Console.WriteLine("Dobar");
                    break;
                case 4:
                    Console.WriteLine("Vrlo Dobar");
                    break;
                case 5:
                    Console.WriteLine("Odličan");
                    break;
                default:
                    Console.WriteLine("Nije cjena");
                    break ;
            }

            












        }   
    }
}
