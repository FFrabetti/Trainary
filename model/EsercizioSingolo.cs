using System;
using System.Text;
using Trainary.model.attributi;

namespace Trainary.model
{
    public class EsercizioSingolo : Esercizio
    {
        private readonly Attivita _attivita;

        public EsercizioSingolo(Attivita attivita, Attributo[] targets) : base(targets)
        {
            if (attivita == null)
                throw new ArgumentNullException("attivita");
            
            _attivita = attivita;
        }

        public EsercizioSingolo(Attivita attivita) : this(attivita, null)
        {
            
        }

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public Attivita Attivita
        {
            get
            {
                return _attivita;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(_attivita);
            
            for(int i=0; i<Targets.Length; i++)
            {
                if (i == 0)
                    sb.Append(" [");
                else
                    sb.Append("; ");

                sb.Append(Targets[i]);

                if (i == Targets.Length - 1)
                    sb.Append("]");
            }

            return sb.ToString();
        }
    }
    
}
