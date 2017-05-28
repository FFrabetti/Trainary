using Trainary.model.attributi;

namespace Trainary.model
{
    public class EsercizioSingolo : Esercizio
    {
        public EsercizioSingolo(Attivita attivita, Attributo[] targets) : base(attivita, targets)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    
}
