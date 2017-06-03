using System.Windows.Forms;
using Trainary.model.filtri;
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
 