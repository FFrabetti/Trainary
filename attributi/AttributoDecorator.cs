using System;

namespace Trainary
{
    public abstract class AttributoDecorator : IAttributo
    {
        private static string FormatDouble(double value)
        {
            return FormatUtils.ToMaxTwoDecimals(value);
        }

        private readonly IAttributo _attributo;

        protected AttributoDecorator(IAttributo attributo)
        {
            if (attributo == null)
                throw new ArgumentNullException("attributo");

            _attributo = attributo;
        }

        public IAttributo Attributo
        {
            get { return _attributo;  }
        }

        public abstract Units Unita { get; }
        public abstract double Valore { get; }

        public override string ToString()
        {
            return FormatDouble(Valore) + Unita.GetSymbol();
        }

        public IAttributo Add(IAttributo that)
        {
            return Attributo.Add(that);
        }

        public IAttributo ToStandard()
        {
            return Attributo.ToStandard();
        }
    }
}
