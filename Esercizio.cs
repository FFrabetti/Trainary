using System;
using Trainary.attributi;

namespace Trainary
{
    public abstract class Esercizio
	{
        private readonly Attivita _attivita;
        private readonly IAttributo[] _targets;

        public Esercizio(Attivita attivita, IAttributo[] targets)
        {
            if (attivita == null)
                throw new ArgumentNullException("attivita");
            if (targets == null)
                throw new ArgumentNullException("targets");
            _attivita = attivita;
            _targets = targets;
        }

        public Attivita Attivita
        {
            get
            {
                return _attivita;
            }
        }

        public IAttributo[] Targets
        {
            get
            {
                return _targets;
            }
        }

        public EsercizioSvolto Svolgi()
        {
            return new EsercizioSvolto(this);
        }

        public string FullToString()
        {
            String targetsToPrint = _attivita.ToString();
            foreach (IAttributo a in _targets)
            {
                targetsToPrint += a;
                targetsToPrint += " ";
            }
            return targetsToPrint;
        }
    }
}
