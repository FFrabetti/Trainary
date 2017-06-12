namespace Trainary.model.attributi
{
    public abstract class Quantita
    {
        public abstract TipoQuantita Tipo { get; }
        public abstract double ToStandard();

        protected string ToMaxTwoDecimals(double value)
        {
            return value.ToString("0.##");
        }

        public override bool Equals(object obj)
        {
            Quantita that = obj as Quantita;
            return that != null && Tipo == that.Tipo && ToStandard() == that.ToStandard();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Quantita thisQ, Quantita thatQ)
        {
            if ((object)thisQ == null)
                return (object)thatQ == null;

            return thisQ.Equals(thatQ);
        }

        public static bool operator !=(Quantita thisQ, Quantita thatQ)
        {
            return !(thisQ == thatQ);
        }
    }
}