using System;

namespace Trainary.model
{
    public abstract class Allenamento : IComparable<Allenamento>
    {
        private readonly DateTime _data;
        private readonly EsercizioSvolto[] _eserciziSvolti;

        public Allenamento(DateTime data, EsercizioSvolto[] eserciziSvolti)
        {
            _data = data.Date;

            if (eserciziSvolti == null)
                throw new ArgumentNullException("esercizi svolti");
            if (eserciziSvolti.Length == 0)
                throw new ArgumentException("empty esercizi svolti");
            if(_data > DateTime.Today)
                throw new ArgumentException("data futura");

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

        public int CompareTo(Allenamento other)
        {
            return Data.CompareTo(other.Data);
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
