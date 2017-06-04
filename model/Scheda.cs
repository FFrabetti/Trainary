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
            if (String.IsNullOrEmpty(nome))
                throw new ArgumentException("nome");

            _nome = nome;
            _scopo = scopo;
            _descrizione = descrizione;
            _periodoDiValidita = periodoDiValidita;
            _sedute = new List<Seduta>();
        }

        public Scheda(string nome, ScopoDellaScheda scopo, Periodo periodoDiValidita)
            : this(nome, scopo, null, periodoDiValidita) { }

        public Scheda(string nome, string descrizione, Periodo periodoDiValidita)
            : this(nome, ScopoDellaScheda.Nessuno, descrizione, periodoDiValidita) { }

        public Scheda(string nome, Periodo periodoDiValidita)
            : this(nome, ScopoDellaScheda.Nessuno, null, periodoDiValidita) { }

        public string Nome {
            get
            {
                return _nome;
            }
            set
            {
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
                _descrizione = value;
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
            Seduta s = new Seduta(this, esercizi);
            _sedute.Add(s);
            return s;
        }

       public int GetCodiceProgressivo(Seduta seduta)
        {
            int i = _sedute.IndexOf(seduta);
            if (i < 0)
                throw new ArgumentException("La seduta non è presente.");
            return i;
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