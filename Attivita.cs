using System;

namespace Trainary
{
    public class Attivita
    {
        private string _nome;
        private string _descrizione;
        private string[] _attrezzi;
        private Categoria _categoria;

        public Attivita(string nome, Categoria categoria, string descrizione, string[] attrezzi)
        {
            if (nome == null)
                throw new ArgumentNullException("nome");
            if (categoria == null)
                throw new ArgumentNullException("categoria");
            if (attrezzi == null)
                throw new ArgumentNullException("attrezzi");

            _nome = nome;
            _categoria = categoria;
            _descrizione = descrizione;
            _attrezzi = attrezzi;
        }

        public Attivita(string nome, Categoria categoria, string descrizione)
            : this(nome, categoria, descrizione, new string[0]) { }

        public Attivita(string nome, Categoria categoria, string[] attrezzi)
            : this(nome, categoria, null, attrezzi) { }

        public Attivita(string nome, Categoria categoria)
            : this(nome, categoria, (string)null) { }

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

        public Categoria Categoria
        {
            get
            {
                return _categoria;
            }
        }

        public override string ToString()
        {
            return _nome;
        }
    }
}