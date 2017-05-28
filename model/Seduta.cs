using System;
using System.Collections.Generic;

namespace Trainary.model
{
    public class Seduta
    {
        private string _codice;
        private readonly ISet<Esercizio> _esercizi;

        public Seduta(string codice, ISet<Esercizio> esercizi)
        {
            if (String.IsNullOrEmpty(codice))
                throw new ArgumentNullException("codice");
            if (esercizi == null)
                throw new ArgumentNullException("esercizi");

            _codice = codice;
            _esercizi = esercizi;
        }

        public string Codice
        {
            get
            {
                return _codice;
            }

            set
            {
                _codice = value;
            }
        }

        public ISet<Esercizio> Esercizi
        {
            get
            {
                return _esercizi;
            }
        }

        public override string ToString()
        {
            return _codice;
        }
    }
}