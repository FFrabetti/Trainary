using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainary.model;
using Trainary.model.attributi;
using Trainary.Presentation;

namespace Trainary.presenter
{
    class VisualizzaSchedaPresenter
    {
        private SchedaForm _form;
        private Scheda _scheda;
        private TextBox _scopoTextBox = new TextBox();
        private InserisciDataEserciziPresenter _presenter;
        public VisualizzaSchedaPresenter(SchedaForm form,Scheda scheda)
        {
            if (form == null)
                throw new ArgumentNullException("form");
            if (scheda == null)
                throw new ArgumentNullException("scheda");
            _form = form;
            _scheda = scheda;
            _presenter = new InserisciDataEserciziPresenter(_form.TreeView);
            Inizializza();
            VisualizzaScheda();
        }

        private void Inizializza()
        {
            _form.Nome.Enabled = false;
            _scopoTextBox.Dock = DockStyle.Fill;
            _form.Scopo.Controls.Add(_scopoTextBox);
            _scopoTextBox.Enabled = false;
            _form.Scopo.Enabled = false;
            _form.Descrizione.Enabled = false;
            _form.DataInizio.Enabled = false;
            _form.DataFine.Enabled = false;
            _form.DurataRadioButton.Visible = false;
            _form.DataFineRadioButton.Visible = false;
            _form.Durata.Enabled = false;
            _form.EliminaEsercizioButton.Visible = false;
            _form.NuovoEsercizioButton.Visible = false;
            _form.NuovoCircuitoButton.Visible = false;
            _form.RimuoviSedutaButton.Visible = false;
            _form.NuovaSedutaButton.Visible = false;
            _form.RinominaSedutaButton.Visible = false;
            _form.Buttons.Visible = false;
            _form.CambiObbligatori.Visible = false;
            _form.NomeLabel.Text = "Nome:";
            _form.DataInizioLabel.Text = "DataInizio:";
            _form.SeduteLabel.Text = "Sedute:";
        }

        private void VisualizzaScheda()
        {
            _form.Nome.Text = _scheda.Nome;
           
            _scopoTextBox.Text = _scheda.Scopo.ToString();
           
            _form.Descrizione.Text = _scheda.Descrizione;
           
            _form.DataInizio.Value = _scheda.PeriodoDiValidita.DataInizio;
           
            _form.DataFine.Value = _scheda.PeriodoDiValidita.DataFine;
           
            _form.Durata.Text = _scheda.PeriodoDiValidita.Durata.Days.ToString();
           
            _presenter.VisualizzaSedute(_scheda.Sedute);
           
        }
       
    }
}
