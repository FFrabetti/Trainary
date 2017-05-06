using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
    public class Categoria
    {
        private string _nome;
        private ISet<Attivita> _attivita;
        private ISet<Categoria> _sottoCategorie;

        public Categoria(string nome, ISet<Attivita> attivita, ISet<Categoria> sottoCategorie)
        {
            if (nome == null)
                throw new ArgumentNullException("nome");
            if (attivita == null)
                throw new ArgumentNullException("attivita");

            _nome = nome;
            _attivita = attivita;
            _sottoCategorie = sottoCategorie;
        }

        public Categoria(string nome, ISet<Attivita> attivita) 
            : this(nome, attivita, null) { }

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
    }
}
