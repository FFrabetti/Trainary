using System;
using System.Collections.Generic;
using System.Linq;

namespace Trainary.model
{
    public class CircuitoSvolto : EsercizioSvolto
    {
        private readonly List<EsercizioSvolto> _sottoEserciziSvolti;

        public CircuitoSvolto(Circuito circuito, List<EsercizioSvolto> sottoEserciziSvolti) : base(circuito)
        {
            if (sottoEserciziSvolti == null)
                throw new ArgumentNullException("sottoEserciziSvolti");
            if (sottoEserciziSvolti.Count < 2)
                throw new ArgumentException("Un circuito deve contenere almeno 2 esercizi");
            if (sottoEserciziSvolti.Any(esSvolto => !circuito.Esercizi.Contains(esSvolto.Esercizio)))
                throw new ArgumentException("Gli esercizi svolti devono riferirsi ad esercizi del circuito");

            _sottoEserciziSvolti = sottoEserciziSvolti;
        }

        public override EsercizioSvolto[] SottoEserciziSvolti
        {
            get
            {
                return _sottoEserciziSvolti.ToArray();
            }
        }

    }
}
