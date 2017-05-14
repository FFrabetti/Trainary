using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
    class LinearConverter : IMeasureConverter
    {
        private readonly Units _unita;
        private readonly double _k;

        public LinearConverter(Units unita, double k)
        {
            if (k == 0)
                throw new ArgumentException("k == 0");

            _unita = unita;
            _k = k;
        }

        public Units Unita { get { return _unita; } }

        public double Convert(double value)
        {
            return value * _k;
        }

        public double Revert(double value)
        {
            return value / _k;
        }
    }
}
