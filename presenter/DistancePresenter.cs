using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainary.attributi;
using Trainary.view;

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
