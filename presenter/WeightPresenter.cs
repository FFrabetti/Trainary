using System.Windows.Forms;
using Trainary.model.attributi;
using Trainary.utils;

namespace Trainary.presenter
{
    [Label("Peso")]
    public class WeightPresenter : UnitValuePresenter
    {
        public override void DrawControls(Panel panel)
        {
            base.DrawControls(panel);

            ComboBox.DataSource = UnitaDiMisura.GetAllOfType(TipoQuantita.MASS);
            ComboBox.DisplayMember = "Simbolo";
        }
    }
}
