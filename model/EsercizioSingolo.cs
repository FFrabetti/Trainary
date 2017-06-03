using System;
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
        public EsercizioSingolo(Attivita attivita) : this(attivita,new Attributo[0])
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
            return base.ToString();
        }
    }
    
}
