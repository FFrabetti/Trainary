using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary.model
{
    class CircuitoSvolto : EsercizioSvolto
    {
        List<EsercizioSvolto> _sottoEserciziSvolti = new List<EsercizioSvolto>();

        public CircuitoSvolto(Circuito esercizio) : base(esercizio)
        {
        }
        public List<EsercizioSvolto> SottoEserciziSvolti
        {
            get
            {
                return _sottoEserciziSvolti;
            }
        }
    }
}
