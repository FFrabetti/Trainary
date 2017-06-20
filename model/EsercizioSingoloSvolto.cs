using System.Collections.Generic;

namespace Trainary.model
{
    public class EsercizioSingoloSvolto : EsercizioSvolto
    {
        private static readonly List<EsercizioSvolto> EMPTY = new List<EsercizioSvolto>(); 

        public EsercizioSingoloSvolto(EsercizioSingolo esercizio) : base(esercizio)
        {
        }

        public override List<EsercizioSvolto> SottoEserciziSvolti
        {
            get
            {
                return EMPTY;
            }
        }

    }
}
