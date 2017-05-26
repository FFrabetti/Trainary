using System;
using System.Collections.Generic;
using System.Reflection;

namespace Trainary.attributi
{
    public abstract partial class UnitaDiMisura
    {

        #region Factory (static)

        private static readonly Dictionary<string, UnitaDiMisura> _dictionary = new Dictionary<string, UnitaDiMisura>();

        static UnitaDiMisura()
        {
            try {
                UnitaDiMisura number = new UnitaBase("numero puro", "", TipoQuantita.PURE_NUMBER);
                UnitaDiMisura metre = new UnitaBase("metro", "m", TipoQuantita.LENGTH);
                UnitaDiMisura kilogram = new UnitaBase("kilogrammo", "kg", TipoQuantita.MASS);
                UnitaDiMisura second = new UnitaBase("secondo", "s", TipoQuantita.TIME);

                UnitaDiMisura gram = new LinearUnita("grammo", "g", TipoQuantita.MASS, kilogram, 0.001);
                UnitaDiMisura kilometre = new LinearUnita("kilometro", "km", TipoQuantita.LENGTH, metre, 1000);

                _dictionary.Add("", number);
                _dictionary.Add("m", metre);
                _dictionary.Add("kg", kilogram);
                _dictionary.Add("s", second);
                _dictionary.Add("g", gram);
                _dictionary.Add("km", kilometre);

                InitializeDictionary();
            }
            catch (Exception e)
            {
                // static constructors cannot throw exceptions!
            }
        }

        private static void InitializeDictionary()
        {
            ConstructorInfo constructor;
            UnitaDiMisura u = null;
            foreach (Type t in typeof(UnitaDiMisura).GetNestedTypes())
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
                        if (u != null && u.Simbolo != null)
                            _dictionary.Add(u.Simbolo, u);
                    }
                    catch (Exception e)
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
            foreach (UnitaDiMisura u in _dictionary.Values)
            {
                if (u.Tipo == tipo && u.isBase())
                    return u;
            }
            return null;
        }

        public static IEnumerable<UnitaDiMisura> GetAllOfType(TipoQuantita tipo)
        {
            List<UnitaDiMisura> lista = new List<UnitaDiMisura>();
            foreach (UnitaDiMisura u in _dictionary.Values)
            {
                if (u.Tipo == tipo)
                    lista.Add(u);
            }
            return lista;
        }

        #endregion

        #region Scope: instance

        private readonly string _nome;
        private readonly string _simbolo;
        private readonly TipoQuantita _tipo;
        private readonly UnitaDiMisura _unitaSuper;

        private UnitaDiMisura(string nome, string simbolo, TipoQuantita tipo, UnitaDiMisura unitaSuper)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("nome is null or empty");
            if (simbolo == null)
                throw new ArgumentNullException("simbolo");

            _nome = nome;
            _simbolo = simbolo;
            _tipo = tipo;
            _unitaSuper = unitaSuper;
        }

        private UnitaDiMisura(string nome, string simbolo, TipoQuantita tipo)
            : this(nome, simbolo, tipo, GetBase(tipo)) { }

        public string Nome { get { return _nome; } }

        public string Simbolo { get { return _simbolo; } }

        public TipoQuantita Tipo { get { return _tipo; } }

        public UnitaDiMisura Super { get { return _unitaSuper; } }

        public UnitaDiMisura Base // ricorsiva
        {
            get
            {
                if (isBase())
                    return this;
                else
                    return _unitaSuper.Base;
            }
        }

        public bool isBase()
        {
            return _unitaSuper == null;
        }

        public abstract double toSI(double value);
        public abstract double fromSI(double value);

        #endregion

        private class UnitaBase : UnitaDiMisura
        {
            public UnitaBase(string nome, string simbolo, TipoQuantita tipo)
                : base(nome, simbolo, tipo, null) { }

            public override double fromSI(double value) { return value; }

            public override double toSI(double value) { return value; }
        }

        private class LinearUnita : UnitaDiMisura
        {
            private readonly double _k;

            public LinearUnita(string nome, string simbolo, TipoQuantita tipo, UnitaDiMisura unitaSuper, double k)
                : base(nome, simbolo, tipo, unitaSuper)
            {
                if (k == 0)
                    throw new ArgumentException("k == 0");

                _k = k;
            }

            public override double toSI(double value)
            {
                return value * _k;
            }

            public override double fromSI(double value)
            {
                return value / _k;
            }
        }
    }

}