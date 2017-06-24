using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Trainary.model.attributi
{
    public static partial class UnitaFactory
    {
        private static readonly Dictionary<string, UnitaDiMisura> _dictionary = new Dictionary<string, UnitaDiMisura>();

        private static void AddToDictionary(UnitaDiMisura u)
        {
            _dictionary.Add(u.Simbolo, u);
        }

        static UnitaFactory()
        {
            try
            {
                UnitaDiMisura number = new UnitaDiMisuraBase("numero puro", "", TipoQuantita.NUMERO_PURO);
                UnitaDiMisura metre = new UnitaDiMisuraBase("metro", "m", TipoQuantita.LUNGHEZZA);
                UnitaDiMisura kilogram = new UnitaDiMisuraBase("kilogrammo", "kg", TipoQuantita.MASSA);
                UnitaDiMisura second = new UnitaDiMisuraBase("secondo", "s", TipoQuantita.TEMPO);

                UnitaDiMisura gram = new UnitaDiMisuraDerivata("grammo", "g", kilogram, 0.001);
                UnitaDiMisura kilometre = new UnitaDiMisuraDerivata("kilometro", "km", metre, 1000);

                AddToDictionary(number);
                AddToDictionary(metre);
                AddToDictionary(kilogram);
                AddToDictionary(second);
                AddToDictionary(gram);
                AddToDictionary(kilometre);

                InitializeDictionary();
            }
            catch
            {
                // static constructors cannot throw exceptions!
            }
        }

        private static void InitializeDictionary()
        {
            ConstructorInfo constructor = null;
            UnitaDiMisura u = null;
            foreach (Type t in typeof(UnitaFactory).GetNestedTypes())
            {
                if (
                     t.IsSubclassOf(typeof(UnitaDiMisura)) &&
                     !t.IsAbstract &&
                     (constructor = t.GetConstructor(Type.EmptyTypes)) != null
                  )
                {
                    try
                    {
                        u = (UnitaDiMisura)constructor.Invoke(null);
                        if (u != null)
                            _dictionary.Add(u.Simbolo, u);
                    }
                    catch
                    {
                        // skip
                    }
                }
            }
        }

        public static UnitaDiMisura Get(string simbolo)
        {
            return _dictionary[simbolo];
        }

        public static UnitaDiMisura GetBase(TipoQuantita tipo)
        {
            return _dictionary.Values.SingleOrDefault(unita => unita.TipoQuantita == tipo && unita.IsBase());
        }

        public static IEnumerable<UnitaDiMisura> GetAllOfType(TipoQuantita tipo)
        {
            return _dictionary.Values.Where(unita => unita.TipoQuantita == tipo);
        }

 
        private class UnitaDiMisuraBase : UnitaDiMisura
        {
            public UnitaDiMisuraBase(string nome, string simbolo, TipoQuantita tipo)
                : base(nome, simbolo, tipo)
            { }

            public override UnitaDiMisura UnitaBase
            {
                get { return this; }
            }

            public override double FromUnitaBase(double value) { return value; }

            public override double ToUnitaBase(double value) { return value; }
        }

        private class UnitaDiMisuraDerivata : UnitaDiMisura
        {
            private readonly UnitaDiMisura _unitaSuper;
            private readonly double _k;

            public UnitaDiMisuraDerivata(string nome, string simbolo, UnitaDiMisura unitaSuper, double k)
                : base(nome, simbolo, unitaSuper.TipoQuantita)
            {
                if (k == 0)
                    throw new ArgumentException("k == 0");

                _unitaSuper = unitaSuper;
                _k = k;
            }

            public override UnitaDiMisura UnitaBase
            {
                get { return _unitaSuper.UnitaBase; }
            }

            public override double ToUnitaBase(double value)
            {
                return _unitaSuper.ToUnitaBase(value * _k);
            }

            public override double FromUnitaBase(double value)
            {
                return _unitaSuper.FromUnitaBase(value) / _k;
            }
        }
    }
}
