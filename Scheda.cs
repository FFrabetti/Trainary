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
        private PeriodoDiValidità _periodoDiValidita;
        private string _descrizione;
        private ISet<Seduta> _sedute;
		
        public Scheda(string nome, PeriodoDiValidità periodoDiValidita, ISet<Seduta> sedute)
        {
            if (nome == null)
                throw new ArgumentNullException("nome");
            if (sedute == null)
                throw new ArgumentNullException("sedute");
            _nome = nome;
            _periodoDiValidita = periodoDiValidita;
            _sedute = sedute;
        }
		
        public Scheda(string nome, PeriodoDiValidità periodoDiValidita, ISet<Seduta> sedute, ScopoDellaScheda scopo, string descrizione) : this(nome,periodoDiValidita, sedute)
        {
			_scopo = scopo;
            _descrizione = descrizione;
        }
		
        public Scheda(string nome, PeriodoDiValidità periodoDiValidita, ISet<Seduta> sedute, string descrizione) : this(nome, periodoDiValidita, sedute)
        {
            _descrizione = descrizione;
        }
		
        public Scheda(string nome, PeriodoDiValidità periodoDiValidita, ISet<Seduta> sedute, ScopoDellaScheda scopo) : this(nome, periodoDiValidita, sedute, scopo, null)
        {
        }

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
        public ISet<Seduta> Sedute { get
            {
                return _sedute;
            }
        }

        public bool isValida(DateTime giorno)
        {
            return PeriodoDiValidita.IsNelPeriodo(giorno);
        }

        public override string ToString()
        {
            return _nome;
        }
    }
}
