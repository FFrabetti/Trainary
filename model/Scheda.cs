using System;
using System.Collections.Generic;
using System.Linq;

namespace Trainary.model
{
    public abstract class Scheda
    {
        private string _nome;
        private ScopoDellaScheda _scopo;
        private string _descrizione;
        private Periodo _periodoDiValidita;
        private readonly IList<Seduta> _sedute;

        public Scheda(string nome, ScopoDellaScheda scopo, string descrizione, Periodo periodoDiValidita)
        {
            Nome = nome;
            _scopo = scopo;
            Descrizione = descrizione;
            _periodoDiValidita = periodoDiValidita;
            _sedute = new List<Seduta>();
        }

        public Scheda(string nome, ScopoDellaScheda scopo, Periodo periodoDiValidita)
        : this(nome, scopo, null, periodoDiValidita)
        { }

        public Scheda(string nome, string descrizione, Periodo periodoDiValidita)
        : this(nome, ScopoDellaScheda.Nessuno, descrizione, periodoDiValidita)
        { }

        public Scheda(string nome, Periodo periodoDiValidita)
        : this(nome, null, periodoDiValidita)
        { }

        public virtual string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("nome is null or empty");

                _nome = value;
            }
        }

        public virtual ScopoDellaScheda Scopo
        {
            get
            {
                return _scopo;
            }
            set
            {
                _scopo = value;
            }
        }

        public virtual Periodo PeriodoDiValidita
        {
            get
            {
                return _periodoDiValidita;
            }
            set
            {
                _periodoDiValidita = value;
            }
        }

        public virtual string Descrizione
        {
            get
            {
                return _descrizione;
            }
            set
            {
                _descrizione = value == null ? String.Empty : value;
            }
        }

        public virtual Seduta[] Sedute
        {
            get
            {
                return _sedute.ToArray();
            }
        }

        public virtual Seduta AggiungiSeduta(IList<Esercizio> esercizi)
        {
            return new Seduta(this, esercizi);
            // il costruttore di Seduta chiama RegisterSeduta,
            // aggiungendosi alla lista _sedute
        }

        internal virtual void RegistraSeduta(Seduta s)
        {
            if (s.Scheda != this)
                throw new ArgumentException("La seduta non appartiene a questa scheda");

            if (!_sedute.Contains(s))
                _sedute.Add(s);
        }

        public virtual bool RimuoviSeduta(Seduta seduta)
        {
            return _sedute.Remove(seduta);
        }

        public virtual bool IsValida(DateTime giorno)
        {
            return PeriodoDiValidita.IsNelPeriodo(giorno);
        }

        public abstract bool IsNomeSedutaValido(string nome);

        public abstract string GetCodiceSeduta(Seduta seduta);

        public override string ToString()
        {
            return _nome;
        }

    }
}