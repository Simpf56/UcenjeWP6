using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojProjekat.KonzolnaAplikacije.Modeli
{
    internal class Grupa : Entitet
    {
        public string Naziv { get; set; }
        public Smjer? smjer { get; set; }
        public string Predavac { get; set; }
        public int VelicinaGrupe { get; set; }
        public List<Polaznik>? Polaznici { get; set; }
    }
}
