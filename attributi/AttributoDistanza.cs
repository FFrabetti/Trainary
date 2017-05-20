using System;

namespace Trainary
{
    class AttributoDistanza : SingleValueAttributo
    {
        private readonly static Units UNITA = Units.METRE;

        public AttributoDistanza(double valore) : base(valore)
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

            return new AttributoDistanza(Valore + that.ToStandard().Valore);
        }

        // togliere o tenere?
        #region operatori

        public static AttributoDistanza operator +(AttributoDistanza a1, AttributoDistanza a2)
        {
            return new AttributoDistanza(a1.Valore + a2.ToStandard().Valore);
        }

        public static implicit operator double(AttributoDistanza a)
        {
            return a.Valore;
        }

        // explicit: it can throw an exception if v < 0 
        public static explicit operator AttributoDistanza(double v)
        {
            return new AttributoDistanza(v);
        }

        #endregion

    }
}
