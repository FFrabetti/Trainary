using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Trainary.model.attributi
{
    public static partial class UnitaFactory
    {
        private static readonly Dictionary<string, UnitaDiMisura> _dictionary = new Dictionary<string, UnitaDiMisura>();

        static UnitaFactory()
        {
            try
            {
                UnitaDiMisura number = new UnitaBase("numero puro", "", TipoQuantita.PURE_NUMBER);
                UnitaDiMisura metre = new UnitaBase("metro", "m", TipoQuantita.LENGTH);
                UnitaDiMisura kilogram = new UnitaBase("kilogrammo", "kg", TipoQuantita.MASS);
                UnitaDiMisura second = new UnitaBase("secondo", "s", TipoQuantita.TIME);

                UnitaDiMisura gram = new LinearUnita("grammo", "g", kilogram, 0.001);
                UnitaDiMisura kilometre = new LinearUnita("kilometro", "km", metre, 1000);

                _dictionary.Add("", number);
                _dictionary.Add("m", metre);
                _dictionary.Add("kg", kilogram);
                _dictionary.Add("s", second);
                _dictionary.Add("g", gram);
                _dictionary.Add("km", kilometre);

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
            return _dictionary.Values.SingleOrDefault(unita => unita.Tipo == tipo && unita.IsBase());
        }

        public static IEnumerable<UnitaDiMisura> GetAllOfType(TipoQuantita tipo)
        {
            return _dictionary.Values.Where(unita => unita.Tipo == tipo);
        }


        private class UnitaBase : UnitaDiMisura
        {
            public UnitaBase(string nome, string simbolo, TipoQuantita tipo)
                : base(nome, simbolo, tipo, null)
            { }

            public override double FromSI(double value) { return value; }

            public override double ToSI(double value) { return value; }
        }

        private class LinearUnita : UnitaDiMisura
        {
            private readonly double _k;

            public LinearUnita(string nome, string simbolo, UnitaDiMisura unitaSuper, double k)
                : base(nome, simbolo, unitaSuper)
            {
                if (k == 0)
                    throw new ArgumentException("k == 0");

                _k = k;
            }

            public override double ToSI(double value)
            {
                return value * _k;
            }

            public override double FromSI(double value)
            {
                return value / _k;
            }
        }
    }
}
