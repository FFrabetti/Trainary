namespace Trainary.attributi
{
    static partial class QuantitaFactory
    {
        private class NumeroPuro : Quantita
        {
            private readonly double _valore;

            public NumeroPuro(double valore)
            {
                _valore = valore;
            }

            public override TipoQuantita Tipo
            {
                get { return TipoQuantita.PURE_NUMBER; }
            }

            public override double toStandard()
            {
                return _valore;
            }

            public override string ToString()
            {
                return FormatDouble(_valore);
            }
        }
    }
}
