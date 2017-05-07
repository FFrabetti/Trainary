using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
    public class Categoria : IComparable<Categoria>
    {
        private readonly string _nome;
        private readonly ISet<Attivita> _attivita;
        private readonly ISet<Categoria> _sottoCategorie;

        public Categoria(string nome, Attivita[] attivita, Categoria[] sottoCategorie)
        {
            if (nome == null)
                throw new ArgumentNullException("nome");
            //if (attivita == null && sottoCategorie == null)
            //    throw new ArgumentNullException("attivita==null && sottoCategoria==null");

            _nome = nome;
            _attivita = attivita != null ? new SortedSet<Attivita>(attivita) : new SortedSet<Attivita>();
            _sottoCategorie = sottoCategorie != null ? new SortedSet<Categoria>(sottoCategorie) : new SortedSet<Categoria>();
        }

        public Categoria(string nome, Attivita[] attivita) 
            : this(nome, attivita, null) { }

        public Categoria(string nome, Categoria[] sottoCategorie)
            : this(nome, null, sottoCategorie) { }

        // Potrebbe starci?
//        public Categoria(string nome) : this(nome, null, null) { }

        public string Nome
        {
            get
            {
                return _nome;
            }
        }

        public ISet<Attivita> Attivita
        {
            get
            {
                return _attivita;
            }
        }

        public ISet<Categoria> SottoCategorie
        {
            get
            {
                return _sottoCategorie;
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
            sb.Append(Nome);

            foreach(Categoria c in SottoCategorie)
            {
                sb.Append("\n- " + c);
            }

            foreach(Attivita a in Attivita)
            {
                sb.Append("\n" + a.FullToString());
            }

            return sb.ToString();
        }

        // per IComparable<Categoria>
        public int CompareTo(Categoria other)
        {
            return Nome.CompareTo(other.Nome);
        }
    }
}
