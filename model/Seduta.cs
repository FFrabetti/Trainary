using System;
using System.Collections.Generic;

namespace Trainary.model
{
    public class Seduta
    {
        
        private readonly IList<Esercizio> _esercizi;
        private readonly Scheda _scheda;
        private readonly string _nome;

        public Seduta(Scheda scheda,IList<Esercizio> esercizi,string nome)
        {
            if (scheda == null)
                throw new ArgumentNullException("scheda");
            if (esercizi == null)
                throw new ArgumentNullException("esercizi");

            _scheda = scheda;
            _esercizi = esercizi;
            _nome = nome;
        }

        public Seduta(Scheda scheda, IList<Esercizio> esercizi) : this(scheda,esercizi,null)
        {

        }

        public IList<Esercizio> Esercizi
        {
            get
            {
                return _esercizi;
            }
        }

        public override string ToString()
        {
            string result = "Seduta ";
            if (_nome != null)
                result += _nome;
            else
                result += _scheda.GetCodiceProgressivo(this).ToString();

            return result + " (" + _scheda + ")";
        }
    }
}