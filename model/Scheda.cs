using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trainary.model
{
    public class Scheda
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
            : this(nome, scopo, null, periodoDiValidita) { }

        public Scheda(string nome, string descrizione, Periodo periodoDiValidita)
            : this(nome, ScopoDellaScheda.Nessuno, descrizione, periodoDiValidita) { }

        public Scheda(string nome, Periodo periodoDiValidita)
            : this(nome, null, periodoDiValidita) { }

        public string Nome {
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

        public ScopoDellaScheda Scopo {
            get
            {
                return _scopo;
            }
            set
            {
                _scopo = value;
            }
        }

        public Periodo PeriodoDiValidita {
            get
            {
               return _periodoDiValidita;
            }
            set
            {
                if (value.DataInizio != _periodoDiValidita.DataInizio || value.DataFine < _periodoDiValidita.DataFine)
                    throw new ArgumentException("Il periodo di validità può solo essere esteso.");

                _periodoDiValidita = value;
            }
        }

        public string Descrizione {
            get
            {
                return _descrizione;
            }
            set
            {
                _descrizione = value == null ? String.Empty : value;
            }
        }

        public Seduta[] Sedute {
            get
            {
                return _sedute.ToArray();
            }
        }

        public Seduta AggiungiSeduta(IList<Esercizio> esercizi)
        {
            return new Seduta(this, esercizi);
            // il costruttore di Seduta chiama RegisterSeduta,
            // aggiungendosi alla lista _sedute
        }

        internal void RegisterSeduta(Seduta s)
        {
            if (s.Scheda != this)
                throw new ArgumentException("La seduta non appartiene a questa scheda");

            if (!_sedute.Contains(s))
                _sedute.Add(s);
        }

        public bool RimuoviSeduta(Seduta seduta)
        {
            return _sedute.Remove(seduta);
        }

        public bool IsNomeUnivoco(string nome)
        {
            return ! _sedute.Any(s => s.Nome == nome);
        }

        public int GetCodiceProgressivo(Seduta seduta)
        {
            int i = _sedute.IndexOf(seduta);
            if (i < 0)
                throw new ArgumentException("La seduta non è presente.");

            return i+1;
        }

        public bool isValida(DateTime giorno)
        {
            return PeriodoDiValidita.IsNelPeriodo(giorno);
        }

        public override string ToString()
        {
            return _nome;
        }

        // debug only
        public string ToFullString()
        {
            StringBuilder sb = new StringBuilder(_nome + " ");
            if (_scopo != ScopoDellaScheda.Nessuno)
            {
                sb.Append("(");
                sb.Append(_scopo);
                sb.Append(") ");
            }
            sb.Append(_periodoDiValidita.ToFullString());

            return sb.ToString();
        }
    }
}