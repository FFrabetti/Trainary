namespace Trainary.model.attributi
{
    public abstract class Quantita
    {
        public abstract TipoQuantita Tipo { get; }
        public abstract double toStandard();

        public static string ToMaxTwoDecimals(double value)
        {
            return value.ToString("0.##");
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Quantita))
                return false;

            Quantita that = (Quantita)obj;
            return Tipo == that.Tipo && toStandard() == that.toStandard();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}