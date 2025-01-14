using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.ZavrsniRad
{
    internal class Stavke_narudzbe
    {
        public int sifra { get; set; }
        public Proizvodi proizvod{ get; set; } = new Proizvodi();
        public Narudzbe narudzba { get; set; } = new Narudzbe();
        public int kolicina { get; set; }
        public decimal? cijena { get; set; }
    }
}
