using System;

namespace Trainary
{
    class AttributoRipetizione : IAttributo
    {
        private readonly Units UNITA = Units.NONE;

        private readonly int _valore;

        public AttributoRipetizione(int valore)
        {
            if (valore <= 0)
                throw new ArgumentException("valore <= 0");

            _valore = valore;
        }

        public Units Unita
        {
            get { return UNITA; }
        }

        public double Valore
        {
            get { return _valore; }
        }

        public IAttributo Add(IAttributo that)
        {
            if (that == null)
                throw new ArgumentNullException("that");
            if (!(that is AttributoRipetizione))
                throw new ArgumentException("that is not AttributoRipetizione");

            return new AttributoRipetizione((int)Valore + (int)that.ToStandard().Valore);
        }

        public IAttributo ToStandard()
        {
            return this;
        }

        public override string ToString()
        {
            return _valore.ToString();
        }

        // togliere o tenere?
        #region operatori

        public static AttributoRipetizione operator +(AttributoRipetizione a1, AttributoRipetizione a2)
        {
            return new AttributoRipetizione((int)a1.Valore + (int)a2.ToStandard().Valore);
        }

        public static implicit operator int (AttributoRipetizione a)
        {
            return (int)a.Valore;
        }

        // explicit: it can throw an exception if v <= 0 
        public static explicit operator AttributoRipetizione(int v)
        {
            return new AttributoRipetizione(v);
        }

        #endregion
    }
}
