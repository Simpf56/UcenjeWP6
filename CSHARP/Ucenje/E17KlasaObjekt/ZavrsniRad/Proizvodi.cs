using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.ZavrsniRad
{
    internal class Proizvodi
    {
        public int sifra { get; set; }
        public string naziv { get; set; }
        public decimal cijena { get; set; }
        public Nabavljaci Nabavljac { get; set; }=new Nabavljaci();
    }
}
