using System;

namespace Trainary.model.attributi
{
    public abstract class UnitaDiMisura
    {
        private readonly string _nome;
        private readonly string _simbolo;
        private readonly TipoQuantita _tipo;

        public UnitaDiMisura(string nome, string simbolo, TipoQuantita tipo)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("nome is null or empty");
            if (simbolo == null)
                throw new ArgumentNullException("simbolo");

            _nome = nome;
            _simbolo = simbolo;
            _tipo = tipo;
        }

        public string Nome { get { return _nome; } }

        public string Simbolo { get { return _simbolo; } }

        public TipoQuantita TipoQuantita { get { return _tipo; } }

        public abstract UnitaDiMisura UnitaBase { get; }

        public bool IsBase()
        {
            return this == UnitaBase;
        }

        public abstract double ToUnitaBase(double value);
        public abstract double FromUnitaBase(double value);

        public override string ToString()
        {
            string simbolo = Simbolo.Length > 0 ? " (" + Simbolo + ")" : String.Empty;
            return _nome + simbolo;
        }
    }

}