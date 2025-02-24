using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojProjekat.KonzolnaAplikacija.Modeli
{
    internal class Putovanje:Entitet
    {
        public Putovanje()
        {
            this.Popust = false;
            Cijena = 0;
            Datum = DateTime.Now;
            DatumPromjene = DateTime.Now;
        }

        public string Naziv { get; set; }="";
        public string Destinacija { get; set; } = "";
        public float Cijena { get; set; }
        public DateTime Datum { get; set; }
        public bool Popust { get; set; }

        public DateTime? DatumPromjene { get; set; }

        public override string ToString()
        {
            return "Sifra=" + Sifra + ", Naziv=" + Naziv + ", Cijena=" + Cijena +
       ", Destinacija=" + Destinacija + ", Datum=" + Datum + ", Verificiran=" + Popust;
        }
    }
}
