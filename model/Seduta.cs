using System;
using System.Collections.Generic;

namespace Trainary.model
{
    public class Seduta
    {
        private readonly IList<Esercizio> _esercizi;
        private readonly Scheda _scheda;
        private string _nome;

        public Seduta(Scheda scheda, IList<Esercizio> esercizi, string nome = null)
        {
            if (scheda == null)
                throw new ArgumentNullException("scheda");
            if (esercizi == null)
                throw new ArgumentNullException("esercizi");

            _scheda = scheda;
            _scheda.RegistraSeduta(this);
            _esercizi = esercizi;
            Nome = nome;
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
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    _nome = String.Empty;
                else if (_scheda.IsNomeSedutaValido(value))
                    _nome = value;
                else
                    throw new ArgumentException("Nome seduta non valido");
            }
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
            return (string.IsNullOrEmpty(_nome) ? "Seduta " + _scheda.GetCodiceSeduta(this) : _nome);
        }

    }
}
