using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.ZavrsniRad
{
    public class Narudzbe:Kupci
    {
        public int Sifra { get; set; }
        public decimal Ukupan_iznos { get; set; }
        public DateTime? Datum { get; set; }
        public string Status { get; set; } = "";
        public Kupci Kupci{ get; set; }= new Kupci();

    }
}
