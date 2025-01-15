using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18NasljedivanjePolimorfizam
{
    public class Smjer:Entitet // klasa smjer nasljeduje javna i zasticena svojstva i metode iz klase Entitet
    {
        public string Naziv { get; set; } = "";

        public override string ToString()
        {
            return Naziv;
        }
        // ovo nije bas pametno, naziv ne odreduje jednoznacno smjer
        public override bool Equals(object? obj)
        {
            return ((Smjer)obj).Naziv.Equals(Naziv);
        }
    }
}
