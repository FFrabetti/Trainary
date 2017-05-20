using System;
using System.Collections.Generic;

namespace Trainary
{
    public class EsercizioSvolto
    {
        private readonly Esercizio _esercizio;
        private readonly List<Attributo> _dati;

        public EsercizioSvolto(Esercizio esercizio)
        {
            if (esercizio == null)
                throw new ArgumentNullException("esercizio");
            _esercizio = esercizio;
            _dati = new List<Attributo>();
        }

        public Esercizio Esercizio
        {
            get { return _esercizio; }
        }

        public List<Attributo> Dati
        {
            get { return _dati; }
        }
    }
}
