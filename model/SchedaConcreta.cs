using System;
using System.Linq;

namespace Trainary.model
{
    public class SchedaConcreta : Scheda
    {
        public SchedaConcreta(string nome, ScopoDellaScheda scopo, string descrizione, Periodo periodoDiValidita)
            : base(nome, scopo, descrizione, periodoDiValidita)
        { }

        public SchedaConcreta(string nome, ScopoDellaScheda scopo, Periodo periodoDiValidita)
        : this(nome, scopo, null, periodoDiValidita)
        { }

        public SchedaConcreta(string nome, string descrizione, Periodo periodoDiValidita)
        : this(nome, ScopoDellaScheda.Nessuno, descrizione, periodoDiValidita)
        { }

        public SchedaConcreta(string nome, Periodo periodoDiValidita)
        : this(nome, null, periodoDiValidita)
        { }

        // il periodo di validità può solo essere esteso (con data di inizio fissa)
        public override Periodo PeriodoDiValidita
        {
            get
            {
                return base.PeriodoDiValidita;
            }
            set
            {
                if (value.DataInizio != base.PeriodoDiValidita.DataInizio ||
                    value.DataFine < base.PeriodoDiValidita.DataFine)
                    throw new ArgumentException("Il periodo di validità può solo essere esteso.");

                base.PeriodoDiValidita = value;
            }
        }

        // nome univoco
        public override bool IsNomeSedutaValido(string nome)
        {
            return !Sedute.Any(s => s.Nome == nome);
        }

        // usa codici progressivi
        public override string GetCodiceSeduta(Seduta seduta)
        {
            int i = Array.IndexOf(Sedute, seduta);
            if (i < 0)
                return " -- ";

            return (i + 1).ToString();
        }

    }
}