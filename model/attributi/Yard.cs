namespace Trainary.model.attributi
{
    public abstract partial class UnitaDiMisura
    {
        public class Yard : UnitaDiMisura
        {
            // it has to have a constructor with no arguments
            public Yard() : base("yard", "yd", TipoQuantita.LENGTH) { }

            public override double FromSI(double value)
            {
                return value / 0.9144;
            }

            public override double ToSI(double value)
            {
                return value * 0.9144;
            }
        }
    }
}
