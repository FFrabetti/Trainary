namespace Trainary.model.attributi
{
    static partial class QuantitaFactory
    {
        public class NumeroPuro : Quantita
        {
            private readonly double _valore;

            public NumeroPuro(double valore)
            {
                _valore = valore;
            }

            public override TipoQuantita Tipo
            {
                get { return TipoQuantita.NUMERO_PURO; }
            }

            public override double ToStandard()
            {
                return _valore;
            }

            public override string ToString()
            {
                return ToMaxTwoDecimals(_valore);
            }
        }
    }
}
