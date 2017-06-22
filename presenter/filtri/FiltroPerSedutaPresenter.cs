using System;
using System.Windows.Forms;
using Trainary.model;
using Trainary.utils;
using Trainary.view;

namespace Trainary.presenter.filtri
{
    [Label("Filtro per seduta")]
    public class FiltroPerSedutaPresenter : FiltroPresenter
    {
        private SelezionaSedutaControl _control = new SelezionaSedutaControl();


        public FiltroPerSedutaPresenter()
        {
            InizializeSchedeCombo();
            SelectedSchedaCombo(_control.ComboSchede, EventArgs.Empty);
        }

        private void InizializeSchedeCombo()
        {
            _control.ComboSchede.DataSource = GestoreSchede.GetInstance().GetSchede();
            _control.ComboSchede.SelectedIndexChanged += SelectedSchedaCombo;
        }

        private void InizializeSeduteCombo()
        {
            Scheda scheda = (Scheda)_control.ComboSchede.SelectedItem;
            _control.ComboSedute.DataSource = scheda.Sedute;
        }

        public override void DrawControls(Panel panel)
        {
            panel.Controls.Add(_control);
            InizializeSeduteCombo();
        }

        public override object GetOpzione()
        {
            return (Seduta)_control.ComboSedute.SelectedItem;
        }

        private void SelectedSchedaCombo(object sender, EventArgs e)
        {
            InizializeSeduteCombo();
        }
    }
}
