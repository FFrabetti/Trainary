using System;

namespace Trainary.model.attributi
{
    public abstract class UnitaDiMisura
    {
        private readonly string _nome;
        private readonly string _simbolo;
        private readonly TipoQuantita _tipo;
        private readonly UnitaDiMisura _unitaSuper;

        protected UnitaDiMisura(string nome, string simbolo, TipoQuantita tipo, UnitaDiMisura unitaSuper)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("nome is null or empty");
            if (simbolo == null)
                throw new ArgumentNullException("simbolo");
            if (unitaSuper != null && unitaSuper.Tipo != tipo)
                throw new ArgumentException("unitaSuper.Tipo != tipo");

            _nome = nome;
            _simbolo = simbolo;
            _tipo = tipo;
            _unitaSuper = unitaSuper;
        }

        public UnitaDiMisura(string nome, string simbolo, TipoQuantita tipo)
            : this(nome, simbolo, tipo, UnitaFactory.GetBase(tipo)) { }

        public UnitaDiMisura(string nome, string simbolo, UnitaDiMisura unitaSuper)
            : this(nome, simbolo, unitaSuper.Tipo, unitaSuper) { }

        public string Nome { get { return _nome; } }

        public string Simbolo { get { return _simbolo; } }

        public TipoQuantita Tipo { get { return _tipo; } }

        public UnitaDiMisura Super { get { return _unitaSuper; } }

        public UnitaDiMisura Base // ricorsiva
        {
            get
            {
                if (IsBase())
                    return this;
                else
                    return _unitaSuper.Base;
            }
        }

        public bool IsBase()
        {
            return _unitaSuper == null;
        }

        public abstract double ToSI(double value);
        public abstract double FromSI(double value);
    }

}