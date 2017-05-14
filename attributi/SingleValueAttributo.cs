using System;

namespace Trainary
{
    public abstract class SingleValueAttributo : IAttributo
    {
        private static string FormatDouble(double value)
        {
            return FormatUtils.ToMaxTwoDecimals(value);
        }

        private readonly double _valore;

        public SingleValueAttributo(double valore)
        {
            if (valore < 0)
                throw new ArgumentException("negative valore");

            _valore = valore;
        }

        public abstract Units Unita { get; }

        public double Valore
        {
            get { return _valore; }
        }

        public abstract IAttributo Add(IAttributo that);

        public IAttributo ToStandard()
        {
            return this;
        }

        public override string ToString()
        {
            return FormatDouble(Valore) + Unita.GetSymbol();
        }
    }
}
