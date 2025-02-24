using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MojProjekat.KonzolnaAplikacija;

namespace MojProjekat.KonzolnaAplikacija.Modeli
{
    internal class Grupa : Entitet
    {
        public string Naziv { get; set; } = "";
        public string Opis { get; set; } = "";
        public string Vodic { get; set; }
        public int VelicinaGrupe { get; set; }
        public List<Kupac>? Kupci { get; set; }
    }
}
