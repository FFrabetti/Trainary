using System;
using Trainary.model.attributi;

namespace Trainary.model
{
    public class EsercizioSingolo : Esercizio
    {
        public EsercizioSingolo(Attivita attivita, Attributo[] targets) : base(attivita, targets)
        {

        }

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    
}
