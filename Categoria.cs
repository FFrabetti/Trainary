﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Trainary
{
    public class Categoria : IComparable<Categoria>
    {
        private readonly string _nome;
        private readonly IEnumerable<Attivita> _attivita;
        private readonly IEnumerable<Categoria> _sottoCategorie;

        private static readonly IEnumerable<Attivita> EMPTY_ATTIVITA = new Attivita[0];
        private static readonly IEnumerable<Categoria> EMPTY_CATEGORIA = new Categoria[0];

        public Categoria(string nome, IEnumerable<Attivita> attivita, IEnumerable<Categoria> sottoCategorie)
        {
            if (nome == null)
                throw new ArgumentNullException("nome");
            if (nome.Length == 0)
                throw new ArgumentException("empty nome");

            // categoria vuota, senza attività e senza sottoCategorie ???
            //if (attivita == null && sottoCategorie == null)
            // nel caso bisogna anche controllare se sono empty
            //    throw new ArgumentNullException("attivita==null && sottoCategoria==null");

            _nome = nome;
            _attivita = attivita != null ? new SortedSet<Attivita>(attivita) : EMPTY_ATTIVITA;
            _sottoCategorie = sottoCategorie != null ? new SortedSet<Categoria>(sottoCategorie) : EMPTY_CATEGORIA;
        }

        public Categoria(string nome, IEnumerable<Attivita> attivita) 
            : this(nome, attivita, null) { }

        public Categoria(string nome, IEnumerable<Categoria> sottoCategorie)
            : this(nome, null, sottoCategorie) { }

        //public Categoria(string nome) : this(nome, null, null) { }

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
