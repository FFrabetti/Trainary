using System;

namespace Trainary.attributi2
{
    public class Quantita
    {
        private readonly double _valore;
        private readonly UnitaDiMisura _unita;

        public Quantita(double valore, UnitaDiMisura unita)
        {
            if (unita == null)
                throw new ArgumentNullException("unita");

            _valore = valore;
            _unita = unita;
        }

        public double Valore { get { return _valore; } }

        public UnitaDiMisura Unita { get { return _unita; } }

        public Quantita toSI()
        {
            if (_unita.isBase())
                return this;

            return new Quantita(_unita.toSI(_valore), _unita.getBase());
        }

        // Add ?

        //public override bool Equals(object obj)
        //{
            
        //}
    }
}