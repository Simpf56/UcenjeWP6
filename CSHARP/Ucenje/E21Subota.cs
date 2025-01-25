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

            SlucajniBrojevi();


        }

        private void SlucajniBrojevi()
        {
            var random = new Random();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(20, 31));
            }
        }
    }
}
