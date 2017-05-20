using System;
using System.Text;

namespace Trainary.attributi
{
    static partial class QuantitaFactory
    {
        private class Durata : Quantita
        {
            private readonly TimeSpan _timeSpan;

            public Durata(TimeSpan timeSpan)
            {
                if (timeSpan == null)
                    throw new ArgumentNullException("timeSpan");

                _timeSpan = timeSpan;
            }

            public Durata(int h, int m, int s) : this(new TimeSpan(h, m, s))
            {
                // negative values?
            }

            public TimeSpan TimeSpan
            {
                get { return _timeSpan; }
            }

            public override TipoQuantita Tipo
            {
                get { return TipoQuantita.TIME; }
            }

            public override double toStandard()
            {
                return _timeSpan.TotalSeconds;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                if (_timeSpan.Days != 0)
                    sb.Append(_timeSpan.Days + " days ");
                if (_timeSpan.Hours != 0)
                    sb.Append(_timeSpan.Hours + "h ");
                if (_timeSpan.Minutes != 0)
                    sb.Append(_timeSpan.Minutes + "m ");
                if (_timeSpan.Seconds != 0 || _timeSpan.Milliseconds != 0)
                    sb.Append((_timeSpan.Seconds + _timeSpan.Milliseconds / 1000.0) + "s");

                return sb.ToString().TrimEnd();
            }
        }
    }
}
