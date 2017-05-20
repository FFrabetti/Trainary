using System;

namespace Trainary.attributi2
{
    public class Attributo : IAttributo
    {
        private readonly string _nome;
        private readonly IQuantita _quantita;

        public Attributo(string nome, IQuantita quantita)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("nome");
            if (quantita == null)
                throw new ArgumentNullException("quantita");

            _nome = nome;
            _quantita = quantita;
        }

        public string Nome
        {
            get { return _nome; }
        }

        public IQuantita Quantita
        {
            get { return _quantita; }
        }

        public override string ToString()
        {
            return _nome + ": " + _quantita;
        }
    }
}
