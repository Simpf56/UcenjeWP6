using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.ZavrsniRad
{
    internal class Narudzbe
    {
        public int sifra { get; set; }
        public decimal ukupan_iznos { get; set; }
        public DateTime? datum { get; set; }
        public string status { get; set; } = "";
        public Kupci kupac{ get; set; }= new Kupci();

    }
}
