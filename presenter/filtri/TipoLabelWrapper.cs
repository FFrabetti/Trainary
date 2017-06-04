using System;
using System.Reflection;
using Trainary.utils;

namespace Trainary.presenter.filtri
{
    public class TipoLabelWrapper
    {
        private Type _tipo;

        public TipoLabelWrapper(Type tipo)
        {
            _tipo = tipo;
        }

        public Type Tipo
        {
            get { return _tipo; }
        }

        public string Label
        {
            get
            {
                LabelAttribute la = (LabelAttribute)_tipo.GetCustomAttribute(typeof(LabelAttribute));
                if (la == null)
                    return _tipo.Name;
                else
                    return la.Label;
            }
        }
    }
}
