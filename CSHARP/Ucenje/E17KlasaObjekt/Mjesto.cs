using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt
{
    public class Mjesto
    {
        public string Naziv { get; set; } = "";

        public string PostanskiBroj { get; set; } = ""; // sada svojstvo nije null nego je prazno

        public Zupanija Zupanija { get; set; }
    }
}
