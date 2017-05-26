using System;

namespace Trainary.attributi
{
    public class Attributo
    {
        private readonly string _nome;
        private readonly Quantita _quantita;

        public Attributo(string nome, Quantita quantita)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("nome is null or empty");
            if (quantita == null)
                throw new ArgumentNullException("quantita");

            _nome = nome;
            _quantita = quantita;
        }

        public string Nome
        {
            get { return _nome; }
        }

        public Quantita Quantita
        {
            get { return _quantita; }
        }

        public override string ToString()
        {
            return _nome + ": " + _quantita;
        }
    }
}
