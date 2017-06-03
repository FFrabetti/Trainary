using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
