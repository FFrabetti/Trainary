using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
    class AttributoTempo : IAttributo
    {
        private readonly TimeSpan _timeSpan;

        private static readonly Units UNITA = Units.SECOND;

        public AttributoTempo(TimeSpan timeSpan)
        {
            if (timeSpan == null)
                throw new ArgumentNullException("timeSpan");

            _timeSpan = timeSpan;
        }

        public AttributoTempo(int h, int m, int s) : this(new TimeSpan(h, m, s))
        {
            // negative values?
        }

        public Units Unita
        {
            get { return UNITA; }
        }

        public double Valore
        {
            get { return _timeSpan.TotalSeconds; }
        }

        public TimeSpan TimeSpan
        {
            get { return _timeSpan; }
        }

        public IAttributo Add(IAttributo that)
        {
            if (that == null)
                throw new ArgumentNullException("that");
            if (!(that is AttributoTempo))
                throw new ArgumentException("that is not AttributoTempo");

            return new AttributoTempo(_timeSpan.Add(((AttributoTempo)that).TimeSpan));
        }

        public IAttributo ToStandard()
        {
            return this;
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
                sb.Append((_timeSpan.Seconds + _timeSpan.Milliseconds/1000.0) + "s");

            return sb.ToString().TrimEnd();
        }

    }
}
