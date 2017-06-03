using System;
using System.Collections.Generic;
using System.Linq;

namespace Trainary.model
{
    public class Scheda
    {
        private string _nome;
        private ScopoDellaScheda _scopo;
        private string _descrizione;
        private Periodo _periodoDiValidita;
        private readonly ISet<Seduta> _sedute = new HashSet<Seduta>();
		
        public Scheda(string nome, ScopoDellaScheda scopo, string descrizione, Periodo periodoDiValidita)
        {
            if (String.IsNullOrEmpty(nome))
                throw new ArgumentException("nome");

            _nome = nome;
            _scopo = scopo;
            _descrizione = descrizione;
            _periodoDiValidita = periodoDiValidita;
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

        public void AggiungiSeduta(ISet<Esercizio> esercizi)
        {
            _sedute.Add(new Seduta(OttieniCodice(), esercizi));
        }

        public void ModificaNomeSeduta(string vecchioCodice, string nuovoCodice)
        {
            if (!isCodiceUnivocoNellaScheda(nuovoCodice))
                throw new ArgumentException("Esiste già una seduta con questo codice");
            if (!isCodiceEsistente(vecchioCodice))
                throw new ArgumentException("Non c'è una seduta nella scheda con il codice che si cerca di modificare.");

            foreach (Seduta s in _sedute)
            {
                if (s.Codice.Equals(vecchioCodice))
                {
                    s.Codice = nuovoCodice;
                    break;
                }
            }
        }

        private bool isCodiceEsistente(string vecchioCodice)
        {
            IEnumerable<string> codiciPresenti = from Seduta s in _sedute
                                                 select s.Codice;

            return codiciPresenti.Contains(vecchioCodice);
        }

        private bool isCodiceUnivocoNellaScheda(string nuovoCodice)
        {
            return !isCodiceEsistente(nuovoCodice);
        }

        private string OttieniCodice()
        {
            throw new NotImplementedException();
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