using System;

namespace Trainary.model
{
    public class AllenamentoProgrammato : Allenamento
    {
        private readonly Seduta _seduta;

        public AllenamentoProgrammato(DateTime data, EsercizioSvolto[] eserciziSvolti, Seduta seduta)
            : base(data, eserciziSvolti)
        {
            if (seduta == null)
                throw new ArgumentNullException("seduta");

            _seduta = seduta;
        }

        public Seduta Seduta
        {
            get
            {
                return _seduta;
            }
        }
    }
}
