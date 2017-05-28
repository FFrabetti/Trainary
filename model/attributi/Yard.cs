namespace Trainary.model.attributi
{
    public abstract partial class UnitaDiMisura
    {
        public class Yard : UnitaDiMisura
        {
            // it has to have a constructor with no arguments
            public Yard() : base("yard", "yd", TipoQuantita.LENGTH) { }

            public override double fromSI(double value)
            {
                return value / 0.9144;
            }

            public override double toSI(double value)
            {
                return value * 0.9144;
            }
        }
    }
}
