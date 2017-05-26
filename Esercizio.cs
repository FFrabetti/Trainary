using System;
using System.Text;
using Trainary.attributi;

namespace Trainary
{
    public abstract class Esercizio
	{
        private readonly Attivita _attivita;
        private readonly Attributo[] _targets;

        public Esercizio(Attivita attivita, Attributo[] targets)
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

        public Attributo[] Targets
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

        public override string ToString()
        {
            StringBuilder esBuilder = new StringBuilder(_attivita.ToString() + " [");

            for (int i=0; i < _targets.Length; i++)
            {
                if (i!=0)
                    esBuilder.Append(", ");
                esBuilder.Append(_targets[i]);
            }
            esBuilder.Append(']');

            return esBuilder.ToString();
        }
    }
}
