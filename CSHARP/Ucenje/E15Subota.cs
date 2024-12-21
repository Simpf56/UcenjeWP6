using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E15Subota
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E15");
            PrimjerTryCatch();
        }

        private static void PrimjerTryCatch()
        {
            try
            {
                int.Parse("Osijek");
            }
            catch
            {
                Console.WriteLine("Žao nam je zbog greške");
            }

            bool vrijednost = false; // default je false
            
            Console.WriteLine("Da li si zaposen/a? (upiši DA ili bilo što za ne)");
            if(Console.ReadLine().Trim().ToUpper() == "DA")
            {
                vrijednost = true;
            }
            Console.WriteLine(vrijednost);

            Console.WriteLine(E12Metode.UcitajBool("Da li si zaposen/a? (upiši DA ili bilo što za ne)","DA"));

            Console.WriteLine(E12Metode.UcitajBool("Jutros sam pojeo tri sendvića (Istina/Laž)", "Istina"));
        }    
    }
}
