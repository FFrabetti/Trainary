using System;
using System.Linq;
using Trainary.utils;

namespace Trainary.model
{
    [Label("Allenamento programmato")]
    public class AllenamentoProgrammato : Allenamento
    {
        private readonly Seduta _seduta;

        public AllenamentoProgrammato(DateTime data, EsercizioSvolto[] eserciziSvolti, Seduta seduta)
            : base(data, eserciziSvolti)
        {
            if (seduta == null)
                throw new ArgumentNullException("seduta");

            if (!seduta.Scheda.PeriodoDiValidita.IsNelPeriodo(data))
                throw new ArgumentException("La data non rientra nel periodo di validità della scheda.");

            if(eserciziSvolti.Any(esSvolto => !seduta.Esercizi.Contains(esSvolto.Esercizio)))
                throw new ArgumentException("Tutti gli esercizi svolti devono appartenere alla seduta.");
 
            _seduta = seduta;
        }

        public Seduta Seduta
        {
            get
            {
                return _seduta;
            }
        }

        public override string ToString()
        {
            return ToStringData() + " - Allenamento " + _seduta + " (" + _seduta.Scheda + ")";
        }
    }
}
