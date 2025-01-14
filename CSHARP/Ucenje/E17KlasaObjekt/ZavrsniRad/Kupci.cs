using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.ZavrsniRad
{
    internal class Kupci
    {
        public int sifra { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string br_tel { get; set; }
        public string adresa { get; set; } = "";
        public DateOnly? datum_rod { get; set; }
    }
}
