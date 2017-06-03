using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Trainary.utils;

namespace Trainary.presenter
{
    public abstract class FiltroPresenter
    {
        public IFiltroAllenamenti NewFiltro
        {
            get { return FiltroFactory.GetFiltroAllenamento(LabelAttribute); }
        }

        //public abstract IFiltroAllenamenti GetNewFiltro();

        public abstract void DrawControls(Panel panel);

        public abstract object GetOpzione();

        public string LabelAttribute
        {
            get { return this.GetLabelAttribute(); }
        }
    }
}
 