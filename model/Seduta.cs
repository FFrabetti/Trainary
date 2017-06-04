using System;
using System.Collections.Generic;
using System.Text;

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

        public string Nome
        {
            get; set;
        }

        public Scheda Scheda
        {
            get
            {
                return _scheda;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder("Seduta ");
            if (!string.IsNullOrEmpty(_nome))
                result.Append(_nome);
            else
                result.Append(_scheda.GetCodiceProgressivo(this));

            result.Append(" (" + _scheda + ")");
            return result.ToString();
        }
    }
}