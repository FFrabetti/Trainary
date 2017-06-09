using System.Collections.Generic;
using System.Windows.Forms;
using Trainary.model.attributi;
using Trainary.utils;

namespace Trainary.presenter.attributi
{
    [Label("Peso")]
    public class WeightPresenter : UnitValuePresenter
    {
        private IList<UnitaDiMisura> _unitaList;

        public WeightPresenter()
        {
            _unitaList = new List<UnitaDiMisura>(UnitaFactory.GetAllOfType(TipoQuantita.MASS));
        }

        public override void DrawControls(Panel panel)
        {
            base.DrawControls(panel);

            // richiede una IList o una IListSource
            ComboBox.DataSource = _unitaList;
            ComboBox.DisplayMember = "Simbolo";
        }
    }
}
