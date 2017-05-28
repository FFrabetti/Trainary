using System;
using Trainary.model.attributi;

namespace Trainary.model
{
    public class Circuito : Esercizio
    {
        private readonly Esercizio[] _esercizi;

        public Circuito(Attivita attivita, Attributo[] targets, Esercizio[] esercizi) : base(attivita, targets)
        {
            if (esercizi == null)
                throw new ArgumentNullException("esercizi");
            if (esercizi.Length < 2)
                throw new ArgumentException("un circuito deve contenere almeno 2 esercizi");

            _esercizi = esercizi;
        }

        public Esercizio[] Esercizi {
            get
            {
               return _esercizi;
            }
        }

        public string FullToString()
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
