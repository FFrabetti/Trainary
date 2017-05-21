using System;

namespace Trainary.attributi
{
    static partial class QuantitaFactory
    {
        private class SingleValue : Quantita
        {
            private readonly double _valore;
            private readonly UnitaDiMisura _unita;

            public SingleValue(double valore, UnitaDiMisura unita)
            {
                if (unita == null)
                    throw new ArgumentNullException("unita");

                _valore = valore;
                _unita = unita;
            }

            public override TipoQuantita Tipo
            {
                get { return _unita.Tipo; }
            }

            public override double toStandard()
            {
                return _unita.toSI(_valore);
            }

            public override string ToString()
            {
                return FormatDouble(_valore) + _unita.Simbolo;
            }
        }
    }
}