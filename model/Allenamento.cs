using System;

namespace Trainary.model
{
    public abstract class Allenamento
    {
        private readonly DateTime _data;
        private readonly EsercizioSvolto[] _eserciziSvolti;

        public Allenamento(DateTime data, EsercizioSvolto[] eserciziSvolti)
        {
            if (data == null)
                throw new ArgumentNullException("data");
            if (eserciziSvolti == null || eserciziSvolti.Length == 0)
                throw new ArgumentException("esercizi svolti");
            _data = data;
            _eserciziSvolti = eserciziSvolti;
        }

        public DateTime Data
        {
            get
            {
                return _data;
            }
        }

        public EsercizioSvolto[] EserciziSvolti
        {
            get
            {
                return _eserciziSvolti;
            }
        }
     }
}
