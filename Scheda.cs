using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainary;

namespace Trainary
{
    public class Scheda
    {
        private string _nome;
        private ScopoDellaScheda _scopo;
        private string _descrizione;
        private PeriodoDiValidità _periodoDiValidita;
        private readonly ISet<Seduta> _sedute;
		
        public Scheda(string nome, ScopoDellaScheda scopo, string descrizione, PeriodoDiValidità periodoDiValidita, ISet<Seduta> sedute)
        {
            if (String.IsNullOrEmpty(nome))
                throw new ArgumentNullException("nome");
            if (sedute == null)
                throw new ArgumentNullException("sedute");

            _nome = nome;
            _scopo = scopo;
            _descrizione = descrizione;
            _periodoDiValidita = periodoDiValidita;
            _sedute = sedute;
        }

        public Scheda(string nome, ScopoDellaScheda scopo, PeriodoDiValidità periodoDiValidita, ISet<Seduta> sedute)
            : this(nome, scopo, null, periodoDiValidita, sedute) { }

        public Scheda(string nome, string descrizione, PeriodoDiValidità periodoDiValidita, ISet<Seduta> sedute)
            : this(nome, ScopoDellaScheda.None, descrizione, periodoDiValidita, sedute) { }

        public Scheda(string nome, PeriodoDiValidità periodoDiValidita, ISet<Seduta> sedute)
            : this(nome, ScopoDellaScheda.None, null, periodoDiValidita, sedute) { }

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

        public PeriodoDiValidità PeriodoDiValidita {
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

        public ISet<Seduta> Sedute {
            get
            {
                return _sedute;
            }
        }

        public bool isValida(DateTime giorno)
        {
            if (giorno == null)
                throw new ArgumentNullException("giorno");
            return PeriodoDiValidita.IsNelPeriodo(giorno);
        }

        public override string ToString()
        {
            return _nome;
        }
    }
}