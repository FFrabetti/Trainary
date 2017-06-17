using System;

namespace Trainary.model
{
    public abstract class Allenamento
    {
        private readonly DateTime _data;
        private readonly EsercizioSvolto[] _eserciziSvolti;

        public Allenamento(DateTime data, EsercizioSvolto[] eserciziSvolti)
        {
            if (eserciziSvolti == null)
                throw new ArgumentNullException("esercizi svolti");
            if (eserciziSvolti.Length == 0)
                throw new ArgumentException("empty esercizi svolti");
            if(data > DateTime.Today)
                throw new ArgumentException("data futura");

            _data = data.Date;
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
        public override string ToString()
        {
            return ToStringDate(this.Data);
        }
        private string ToStringDate(DateTime dateTime)
        {
            return dateTime.ToString("d")+"                           ";
        }
    }
}
