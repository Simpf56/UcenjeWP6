using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18NasljedivanjePolimorfizam
{
    public abstract class Entitet: Object // sve klase nasljeduju objekt
        // abstraktna klasa je ona klasa koja ne moze imati instancu
        //služi tome da zadržava zajednicka svojstva i metode te da ju netko nasljedi
    {
        public int Sifra { get; set; }

        public override string ToString()
        {
            return Sifra.ToString();
        }
    }
}
