namespace Trainary.attributi
{
    static partial class QuantitaFactory
    {
        private class NumeroPuro : Quantita
        {
            private double _value;

            public NumeroPuro(double value)
            {
                _value = value;
            }

            public override TipoQuantita Tipo
            {
                get { return TipoQuantita.PURE_NUMBER; }
            }

            public override double toStandard()
            {
                return _value;
            }

            public override string ToString()
            {
                return FormatDouble(_value);
            }
        }
    }
}
