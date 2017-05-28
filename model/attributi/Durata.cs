using System;
using System.Text;

namespace Trainary.model.attributi
{
    static partial class QuantitaFactory
    {
        public class Durata : Quantita
        {
            private readonly TimeSpan _durata;

            public Durata(TimeSpan durata)
            {
                if (durata == null)
                    throw new ArgumentNullException("durata");

                _durata = durata;
            }

            public Durata(int h, int m, int s) : this(new TimeSpan(h, m, s))
            {
                // negative values?
            }

            public override TipoQuantita Tipo
            {
                get { return TipoQuantita.TIME; }
            }

            public override double toStandard()
            {
                return _durata.TotalSeconds;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                if (_durata.Days != 0)
                    sb.Append(_durata.Days + " days ");
                if (_durata.Hours != 0)
                    sb.Append(_durata.Hours + "h ");
                if (_durata.Minutes != 0)
                    sb.Append(_durata.Minutes + "m ");
                if (_durata.Seconds != 0 || _durata.Milliseconds != 0)
                    sb.Append((_durata.Seconds + _durata.Milliseconds/1000.0) + "s");

                return sb.ToString().TrimEnd();
            }
        }
    }
}
