using System.Collections.Generic;

namespace Trainary.model
{
    public class CircuitoSvolto : EsercizioSvolto
    {
        List<EsercizioSvolto> _sottoEserciziSvolti = new List<EsercizioSvolto>();

        public CircuitoSvolto(Circuito esercizio) : base(esercizio)
        {
        }

        public override List<EsercizioSvolto> SottoEserciziSvolti
        {
            get
            {
                return _sottoEserciziSvolti;
            }
        }

    }
}
