using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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

            // bit logicka vrijednost 

            bool logickaVrijednost;

            Console.Write("Unesi True ili False: ");

            logickaVrijednost = bool.Parse(Console.ReadLine());

            Console.WriteLine("Unijeli ste {0}", logickaVrijednost);

            // float - decimalni broj

            Console.Write("Unesi broj (, za decimalni dio): ");

            Console.WriteLine(float.Parse(Console.ReadLine()));

            float broj = 3.14f; // f zato sto je to float

            Console.WriteLine("Unesi ime: ");

            string ime = Console.ReadLine();

            Console.WriteLine("Unio sam \n{0}\n{1}\n{2}\n{3}",
                i, logickaVrijednost, broj, ime);




        }


    }
}
