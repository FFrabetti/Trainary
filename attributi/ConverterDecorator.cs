using System;

namespace Trainary
{
    class ConverterDecorator : AttributoDecorator
    {
        private readonly IMeasureConverter _converter;

        public ConverterDecorator(IAttributo attributo, IMeasureConverter converter)
            : base(attributo)
        {
            if (converter == null)
                throw new ArgumentNullException("converter");

            _converter = converter;
        }

        public override Units Unita
        {
            get { return _converter.Unita; }
        }

        public override double Valore
        {
            get { return _converter.Convert(Attributo.Valore); }
        }
    }
}
