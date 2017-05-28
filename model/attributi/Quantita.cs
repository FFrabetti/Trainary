namespace Trainary.model.attributi
{
    public abstract class Quantita
    {
        public abstract TipoQuantita Tipo { get; }
        public abstract double ToStandard();

        public static string ToMaxTwoDecimals(double value)
        {
            return value.ToString("0.##");
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Quantita))
                return false;

            Quantita that = (Quantita)obj;
            return Tipo == that.Tipo && ToStandard() == that.ToStandard();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}