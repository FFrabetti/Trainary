using System;
using System.Collections.Generic;

namespace Trainary.attributi2
{
    public abstract partial class UnitaDiMisura
    {

        #region Factory - scope: class (static)

        private static readonly Dictionary<string, UnitaDiMisura> _dictionary = new Dictionary<string, UnitaDiMisura>();

        static UnitaDiMisura()
        {
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
        }

        public static UnitaDiMisura Get(string simbolo)
        {
            return _dictionary[simbolo];
        }

        public static UnitaDiMisura GetBase(TipoQuantita type)
        {
            foreach (UnitaDiMisura u in _dictionary.Values)
            {
                if (u.Tipo == type && u.isBase())
                    return u;
            }
            return null;
        }

        public static IEnumerable<UnitaDiMisura> GetOfType(TipoQuantita type)
        {
            List<UnitaDiMisura> lista = new List<UnitaDiMisura>();
            foreach (UnitaDiMisura u in _dictionary.Values)
            {
                if (u.Tipo == type)
                    lista.Add(u);
            }
            return lista;
        }

        #endregion

        #region scope: instance

        private readonly string _nome;
        private readonly string _simbolo;
        private readonly TipoQuantita _tipo;
        private readonly UnitaDiMisura _base;

        private UnitaDiMisura(string nome, string simbolo, TipoQuantita tipo, UnitaDiMisura uBase)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("nome");
            if (simbolo == null)
                throw new ArgumentNullException("simbolo");

            _nome = nome;
            _simbolo = simbolo;
            _tipo = tipo;
            _base = uBase;
        }

        public string Nome { get { return _nome; } }

        public string Simbolo { get { return _simbolo; } }

        public TipoQuantita Tipo { get { return _tipo; } }

        public bool isBase()
        {
            return _base == null;
        }

        public UnitaDiMisura getBase() // ricorsivo
        {
            if (isBase())
                return this;
            else
                return _base.getBase();
        }

        public bool isOmogenea(UnitaDiMisura that)
        {
            return getBase() == that.getBase();
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

            public LinearUnita(string nome, string simbolo, TipoQuantita tipo, UnitaDiMisura uBase, double k)
                : base(nome, simbolo, tipo, uBase)
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