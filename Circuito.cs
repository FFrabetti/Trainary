using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
    public class Circuito : Esercizio
    {
        private readonly Esercizio[] _esercizi;
        public Circuito(Attivita attivita, Attributo[] targets, Esercizio[] esercizi) : base(attivita, targets)
        {
            if (esercizi == null)
                throw new ArgumentNullException("esercizi");
            _esercizi = esercizi;
        }

        public Esercizio[] Esercizi {
            get
            {
               return _esercizi;
            }
        }

        public override string ToString()
        {
            String circuitoToPrint = "";
            int i = 1;
            foreach(Esercizio e in _esercizi)
            {
                circuitoToPrint += (i++) + ") ";
                circuitoToPrint += e;
                circuitoToPrint += "\n";
            }
            return circuitoToPrint;
        }
    }
}
