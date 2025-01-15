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
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Br_tel { get; set; }
        public string Adresa { get; set; } = "";
        public DateOnly? Datum_rod { get; set; }
    }
}
