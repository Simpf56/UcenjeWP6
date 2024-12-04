using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E02VarijableTipoviPodataka
    {


        public static void Izvedi()
        {

            //Console.WriteLine("Hello E02");

            //deklaracija varijable
            int i; // i je od increment(uvecanje)

            Console.WriteLine("Upiši broj: ");
            //dodjeljivanje vrijednosti
            //i = Console.ReadLine(); ovo neradi jer je desno string a lijevo int

            i = int.Parse(Console.ReadLine());
            //korištenje vrijednosti
            Console.WriteLine("Upisali ste u {0}, i evo ga još jednom {1}", i,i);
            
        }


    }
}
