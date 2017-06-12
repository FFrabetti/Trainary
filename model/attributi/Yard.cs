namespace Trainary.model.attributi
{
    public static partial class UnitaFactory
    {
        public class Yard : UnitaDiMisura
        {
            private UnitaDiMisura _base;

            // it has to have a constructor with no arguments
            public Yard() : base("yard", "yd", TipoQuantita.LENGTH)
            {
                _base = GetBase(TipoQuantita);
            }

            public override UnitaDiMisura UnitaBase
            {
                get { return _base; }
            }

            public override double FromUnitaBase(double value)
            {
                return value / 0.9144;
            }

            public override double ToUnitaBase(double value)
            {
                return value * 0.9144;
            }
        }
    }
}
