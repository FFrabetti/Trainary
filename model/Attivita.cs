using System;
using System.Text;

namespace Trainary.model
{
    public class Attivita : IComparable<Attivita>
    {
        private readonly string _nome;
        private string _descrizione;
        private string[] _attrezzi;

        public Attivita(string nome, string descrizione, string[] attrezzi)
        {
            if (nome == null)
                throw new ArgumentNullException("nome");
            if (nome.Length == 0)
                throw new ArgumentException("empty nome");

            _nome = nome;
            // attributi opzionali
            // usano il micro-pattern nella get
            _descrizione = descrizione;
            _attrezzi = attrezzi;
        }

        public Attivita(string nome, string descrizione)
            : this(nome, descrizione, null) { }

        public Attivita(string nome, string[] attrezzi)
            : this(nome, null, attrezzi) { }

        public Attivita(string nome)
            : this(nome, null, null) { }

        public string Nome
        {
            get { return _nome; }
        }

        public string Descrizione
        {
            get
            {
                if (_descrizione == null)
                    _descrizione = "";
                return _descrizione;
            }
        }

        public string[] Attrezzi
        {
            get
            {
                if (_attrezzi == null)
                    _attrezzi = new string[0];
                return _attrezzi;
            }
        }

        public override string ToString()
        {
            return _nome;
        }

        // debug only
        internal string FullToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(_nome);

            if (Descrizione.Length > 0)
                sb.Append(" (" + Descrizione + ")");
            if (Attrezzi.Length > 0)
                sb.Append(" [" + AttrezziToString() + "]");

            return sb.ToString();
        }

        private string AttrezziToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Attrezzi.Length; i++)
            {
                if (i != 0)
                    sb.Append(", ");
                sb.Append(Attrezzi[i]);
            }
            return sb.ToString();
        }

        // per IComparable<Attivita>
        public int CompareTo(Attivita other)
        {
            return _nome.CompareTo(other.Nome);
        }
    }
}