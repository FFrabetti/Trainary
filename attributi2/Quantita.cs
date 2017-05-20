using System;

namespace Trainary.attributi2
{
    static partial class QuantitaFactory
    {
        private abstract class Quantita : IQuantita
        {
            public abstract TipoQuantita Tipo { get; }
            public abstract double toStandard();

            public static string FormatDouble(double value)
            {
                return FormatUtils.ToMaxTwoDecimals(value);
            }

            public override bool Equals(object obj)
            {
                if (!(obj is IQuantita))
                    throw new ArgumentException("obj is not IQuantita");

                IQuantita that = (IQuantita)obj;
                return Tipo == that.Tipo && toStandard() == that.toStandard();
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }
    }
}
