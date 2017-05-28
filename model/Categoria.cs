using System;
using System.Collections.Generic;
using System.Text;

namespace Trainary.model
{
    public class Categoria : IComparable<Categoria>
    {
        private readonly string _nome;
        private readonly SortedSet<Attivita> _attivita;
        private readonly SortedSet<Categoria> _sottoCategorie;

        public Categoria(string nome, IEnumerable<Attivita> attivita, IEnumerable<Categoria> sottoCategorie)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("nome is null or empty");

            _nome = nome;
            _attivita = attivita != null ? new SortedSet<Attivita>(attivita) : new SortedSet<Attivita>();
            _sottoCategorie = sottoCategorie != null ? new SortedSet<Categoria>(sottoCategorie) : new SortedSet<Categoria>();
        }

        public Categoria(string nome, IEnumerable<Attivita> attivita) 
            : this(nome, attivita, null) { }

        public Categoria(string nome, IEnumerable<Categoria> sottoCategorie)
            : this(nome, null, sottoCategorie) { }

        // per la radice
        public Categoria(string nome) : this(nome, null, null) { }

        public string Nome
        {
            get { return _nome; }
        }

        public IEnumerable<Attivita> Attivita
        {
            get { return _attivita; }
        }

        public IEnumerable<Categoria> SottoCategorie
        {
            get { return _sottoCategorie; }
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

            foreach(Categoria c in SottoCategorie)
                sb.Append("\n- " + c);
            foreach(Attivita a in Attivita)
                sb.Append("\n" + a.FullToString());

            return sb.ToString();
        }

        // per IComparable<Categoria>
        public int CompareTo(Categoria other)
        {
            return _nome.CompareTo(other.Nome);
        }
    }
}
