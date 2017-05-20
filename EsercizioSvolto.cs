using System;
using System.Collections.Generic;
using Trainary.attributi;

namespace Trainary
{
    public class EsercizioSvolto
    {
        private readonly Esercizio _esercizio;
        private readonly List<IAttributo> _dati;

        public EsercizioSvolto(Esercizio esercizio)
        {
            if (esercizio == null)
                throw new ArgumentNullException("esercizio");
            _esercizio = esercizio;
            _dati = new List<IAttributo>();
        }

        public Esercizio Esercizio
        {
            get { return _esercizio; }
        }

        public List<IAttributo> Dati
        {
            get { return _dati; }
        }
    }
}
