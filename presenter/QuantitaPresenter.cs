using System;
using System.Windows.Forms;
using Trainary.model.attributi;
using Trainary.utils;

namespace Trainary.presenter
{
    public abstract class QuantitaPresenter
    {
        public Exception LastException { get; set; }

        public abstract Quantita GetNewQuantita();

        public abstract void Refresh();

        public abstract void DrawControls(Panel panel);

        public string LabelAttribute
        {
            get { return this.GetLabelAttribute(); }
        }
    }
}
