using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.ZavrsniRad
{
    internal class Stavke_narudzbe
    {
        public int Sifra { get; set; }
        public Proizvodi Proizvodi{ get; set; } = new Proizvodi();
        public Narudzbe Narudzbe { get; set; } = new Narudzbe();
        public int Kolicina { get; set; }
        public decimal? Cijena { get; set; }
    }
}
