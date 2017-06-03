using System;
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

            foreach (EsercizioSvolto esercizioSvolto in eserciziSvolti)
            {

                if (!seduta.Esercizi.Contains(esercizioSvolto.Esercizio))
                    throw new ArgumentException("Tutti gli esercizi svolti devono appartenere alla seduta.");
            }

            if (!seduta.Scheda.PeriodoDiValidita.IsNelPeriodo(data))
                throw new ArgumentException("un allenamento programmato non può essere fatto in una data in cui la scheda non è valida");

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
            return "Allenamento " + _seduta;
        }
    }
}
