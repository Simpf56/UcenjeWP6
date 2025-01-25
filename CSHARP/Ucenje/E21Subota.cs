using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    class E21Subota
    {
        public E21Subota()
        {
            //Console.WriteLine("Hello from E21Subota");

            //SlucajniBrojevi();
            //SlucajniDatumi();
            Ljubav();



        }

        private void Ljubav()
        {
            var ona = "Marta";
            var on = "Manuel";

            var izraz = ona.Trim().ToLower() + on.Trim().ToLower();

            Console.WriteLine(izraz);

            var brojevi = PrebrojiZnakove(izraz);
            Console.WriteLine(string.Join('|', izraz.ToArray()));
            Console.WriteLine(string.Join('|',brojevi));
        }

        private int[] PrebrojiZnakove(string izraz)
        {
            int[] brojevi = new int[izraz.Length];
            var ponoviloSe = 0;
            for (int i = 0; i < izraz.Length; i++)
            {
                ponoviloSe = 0;
                for (int j = 0; j < izraz.Length; j++)
                {
                    if (izraz[i] == izraz[j])
                    {
                        ponoviloSe++;
                    }
                }
                brojevi[i] = ponoviloSe;
            }
            return brojevi;
        }

        private void SlucajniBrojevi()
        {
            var random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(20, 31));
            }
        }

        private void SlucajniDatumi()
        {
            var random = new Random();
            for (int i = 0; i < 100; i++)
            {                
                try
                {
                    var d = new DateTime(2023, random.Next(1, 13), random.Next(1, 32));
                    Console.WriteLine((i+1) + ": " + d.ToString("yyyy-MM-dd"));
                }
                catch
                {
                    i--;                 
                }
                
            
            }
        }
    }
}
