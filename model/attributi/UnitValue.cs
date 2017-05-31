using System;

namespace Trainary.model.attributi
{
    static partial class QuantitaFactory
    {
        public class UnitValue : Quantita
        {
            private readonly double _valore;
            private readonly UnitaDiMisura _unita;

            public UnitValue(double valore, UnitaDiMisura unita)
            {
                if (unita == null)
                    throw new ArgumentNullException("unita");

                _valore = valore;
                _unita = unita;
            }

            public UnitValue(double valore, TipoQuantita tipo) : 
                this(valore, UnitaFactory.GetBase(tipo)) { }

            public UnitValue(double valore, string simbolo) :
                this(valore, UnitaFactory.Get(simbolo)) { }

            public override TipoQuantita Tipo
            {
                get { return _unita.Tipo; }
            }

            public override double ToStandard()
            {
                return _unita.ToSI(_valore);
            }

            public override string ToString()
            {
                return ToMaxTwoDecimals(_valore) + _unita.Simbolo;
            }
        }
    }
}