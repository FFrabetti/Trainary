using System.Collections.Generic;
using System.Windows.Forms;
using Trainary.model.attributi;
using Trainary.utils;

namespace Trainary.presenter.attributi
{
    [Label("Distanza")]
    public class DistancePresenter : UnitValuePresenter
    {
        private IList<UnitaDiMisura> _unitaList;

        public DistancePresenter()
        {
            _unitaList = new List<UnitaDiMisura>(UnitaFactory.GetAllOfType(TipoQuantita.LENGTH));
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
