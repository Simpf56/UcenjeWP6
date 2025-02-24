using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojProjekat.KonzolnaAplikacija.Modeli
{
    internal class Kupac : Entitet
    {
        public string Ime { get; set; } = "";
        public string Prezime { get; set; } = "";
        public string Adresa { get; set; } = "";
        public string Telefon { get; set; } = "";
        public DateOnly Datum_rod { get; set; }

        public int CompareTo(Kupac? other)
        {
            return Prezime.CompareTo(other.Prezime);
        }
    }
}
