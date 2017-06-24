using System;
using System.Collections.Generic;
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
            _control.ComboSchede.DataSource = new List<Scheda>(GestoreSchede.GetInstance().GetSchede());
            _control.ComboSchede.SelectedIndexChanged += SelectedSchedaCombo;
        }

        private void InizializeSeduteCombo()
        {
            Scheda scheda = (Scheda)_control.ComboSchede.SelectedItem;
            if (scheda != null)
                _control.ComboSedute.DataSource = scheda.Sedute;
            else
                _control.ComboSedute.DataSource = new List<Seduta>();
        }

        public override void DrawControls(Panel panel)
        {
            panel.Controls.Add(_control);
            InizializeSeduteCombo();
        }

        public override object GetOpzione()
        {
            Seduta seduta = (Seduta)_control.ComboSedute.SelectedItem;
            if (seduta == null)
                throw new ArgumentException("nessuna seduta selezionata");
            return seduta;
        }

        private void SelectedSchedaCombo(object sender, EventArgs e)
        {
            InizializeSeduteCombo();
        }
    }
}
