using System;

namespace Trainary
{
    class AttributoPeso : SingleValueAttributo
    {
        private readonly static Units UNITA = Units.KILOGRAM;

        public AttributoPeso(double valore) : base(valore)
        { }

        public override Units Unita
        {
            get { return UNITA; }
        }

        public override IAttributo Add(IAttributo that)
        {
            if (that == null)
                throw new ArgumentNullException("that");
            if (Unita != that.ToStandard().Unita)
                throw new ArgumentException("this.Unita != that.Unita");

            return new AttributoPeso(Valore + that.ToStandard().Valore);
        }

        // togliere o tenere?
        #region operatori

        public static AttributoPeso operator +(AttributoPeso a1, AttributoPeso a2)
        {
            return new AttributoPeso(a1.Valore + a2.ToStandard().Valore);
        }

        public static implicit operator double (AttributoPeso a)
        {
            return a.Valore;
        }

        // explicit: it can throw an exception if v < 0 
        public static explicit operator AttributoPeso(double v)
        {
            return new AttributoPeso(v);
        }

        #endregion

    }
}
