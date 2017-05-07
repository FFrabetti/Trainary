using System;
using System.Text;

namespace Trainary
{
    public class Attivita : IComparable<Attivita>
    {
        private string _nome;
        private string _descrizione;
        private string[] _attrezzi;
        //private Categoria _categoria;

        public Attivita(string nome, string descrizione, string[] attrezzi)
        {
            if (nome == null)
                throw new ArgumentNullException("nome");
            //if (categoria == null)
            //    throw new ArgumentNullException("categoria");
            if (attrezzi == null)
                throw new ArgumentNullException("attrezzi");

            _nome = nome;
            //_categoria = categoria;
            _descrizione = descrizione != null ? descrizione : "";
            _attrezzi = attrezzi;
        }

        public Attivita(string nome, string descrizione)
            : this(nome, descrizione, new string[0]) { }

        public Attivita(string nome, string[] attrezzi)
            : this(nome, null, attrezzi) { }

        public Attivita(string nome)
            : this(nome, (string)null) // usa Attivita(string nome, string descrizione)
        { }

        public string Nome
        {
            get
            {
                return _nome;
            }
        }

        public string Descrizione
        {
            get
            {
                return _descrizione;
            }
        }

        public string[] Attrezzi
        {
            get
            {
                return _attrezzi;
            }
        }

        //public Categoria Categoria
        //{
        //    get
        //    {
        //        return _categoria;
        //    }
        //}

        public override string ToString()
        {
            return _nome;
        }

        // debug only
        internal string FullToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Nome);

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
            return Nome.CompareTo(other.Nome);
        }
    }
}