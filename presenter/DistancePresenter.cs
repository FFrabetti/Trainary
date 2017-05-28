using System.Windows.Forms;
using Trainary.model.attributi;
using Trainary.utils;

namespace Trainary.presenter
{
    [Label("Distanza")]
    public class DistancePresenter : UnitValuePresenter
    {
        public override void DrawControls(Panel panel)
        {
            base.DrawControls(panel);

            ComboBox.DataSource = UnitaDiMisura.GetAllOfType(TipoQuantita.LENGTH);
            ComboBox.DisplayMember = "Simbolo";
        }
    }
}
