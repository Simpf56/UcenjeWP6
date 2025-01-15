using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.ZavrsniRad
{
    internal class Proizvodi
    {
        public int Sifra { get; set; }
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public Nabavljaci Nabavljaci { get; set; }=new Nabavljaci();
    }
}
