using System;
using System.Windows.Forms;
using Trainary.attributi;
using Trainary.view;

namespace Trainary.presenter
{
    public abstract class QuantitaPresenter
    {
        public Exception LastException { get; set; }

        public abstract Quantita GetNewQuantita();

        public abstract void Refresh();

        public abstract void DrawControls(Panel panel);

        private string _label;

        public string Label
        {
            get
            {
                if (_label == null)
                    InizializeLabel();
                return _label;
            }
        }

        private void InizializeLabel()
        {
            object[] attributes = GetType().GetCustomAttributes(typeof(LabelAttribute), false);
            int pos;

            if (attributes.Length > 0)
            {
                LabelAttribute labelAttr = (LabelAttribute)attributes[0];
                _label = labelAttr.Label;
            }
            else if ((pos = GetType().Name.IndexOf("Presenter")) > 0)
            {
                _label = GetType().Name.Substring(0, GetType().Name.Length - pos - 1);
            }
            else
                _label = GetType().Name;
        }
    }
}
